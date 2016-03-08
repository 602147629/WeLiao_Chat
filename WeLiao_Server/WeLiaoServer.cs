using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WeLiao_Commom;

namespace WeLiao_Server
{
    public partial class WeLiaoServer : Form
    {
        /// <summary>
        /// 保存连接的所有用户
        /// </summary>
        private List<UserInfo> UserList = new List<UserInfo>();
        /// <summary>
        /// 服务器IP地址
        /// </summary>;
        private string ServerIP;
        /// <summary>
        /// 监听端口
        /// </summary>
        private int Port;
        /// <summary>
        /// 侦听TCP网络客户端连接对象
        /// </summary>
        private TcpListener _TcpListener;
        /// <summary>
        /// 是否退出所有接收线程
        /// </summary>
        bool IsExit = false;

        public WeLiaoServer()
        {
            InitializeComponent();
            this.toolStripButton_Stop.Enabled = false;
            SetServerIPAndPort();
        }

        #region 控件相关事件
        private void WeicheServer_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 工具栏点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_Click(object sender, EventArgs e)
        {
            ToolStripButton item = (ToolStripButton)sender;
            switch (item.Name)
            {
                case "toolStripButton_Start":
                    //开启服务器
                    StartService();
                    break;
                case "toolStripButton_Stop":
                    //停止服务器
                    StopServer();
                    break;
            }
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeicheServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        #endregion
        
        #region 相关方法
        /// <summary>
        /// 设置IP地址及端口
        /// </summary>
        private void SetServerIPAndPort()
        {
            try
            {
                ServerIP = ConfigurationManager.AppSettings["ServerIP"].ToString(); //设定IP
                Port = int.Parse(ConfigurationManager.AppSettings["ServerPort"].ToString()); //设定端口
            }
            catch (Exception ex)
            {
                Utils.SaveLog("设置IP地址及端口异常", ex.Message);
            }
        }
        /// <summary>
        /// 开启服务（开始监听客户端连接）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartService()
        {
            _TcpListener = new TcpListener(IPAddress.Parse(ServerIP), Port);
            _TcpListener.Start();
            AddChatsToListBox(string.Format("侦听客户连接，服务器IP地址:{0},端口{1}", ServerIP, Port));
            //创建一个线程接收客户端连接请求
            Thread myThread = new Thread(ClientConnect);
            myThread.Start();
            toolStripButton_Start.Enabled = false;
            toolStripButton_Stop.Enabled = true;
        }
        /// <summary>
        /// 停止服务（停止监听客户端连接）
        /// </summary>
        private void StopServer()
        {
            AddChatsToListBox("开始停止服务，并依次使用户退出！");
            IsExit = true;
            for (int i = UserList.Count - 1; i >= 0; i--)
            {
                RemoveUser(UserList[i]);
            }
            //通过停止监听让 myListener.AcceptTcpClient() 产生异常退出监听线程
            _TcpListener.Stop();
            this.toolStripButton_Start.Enabled = true;
            this.toolStripButton_Stop.Enabled = false;
        }
        /// <summary>
        /// 接收客户端连接
        /// </summary>
        private void ClientConnect()
        {
            TcpClient newClient = null;
            while (true)
            {
                try
                {
                    newClient = _TcpListener.AcceptTcpClient();
                }
                catch
                {
                    //当单击‘停止监听’或者退出此窗体时 AcceptTcpClient() 会产生异常
                    //因此可以利用此异常退出循环
                    break;
                }
                //每接收一个客户端连接，就创建一个对应的线程循环接收该客户端发来的信息；
                UserInfo user = new UserInfo(newClient);
                Thread threadReceive = new Thread(ReceiveData);
                threadReceive.Start(user);
                UserList.Add(user);
                AddChatsToListBox(string.Format("[{0}]进入微聊", newClient.Client.RemoteEndPoint));
                this.label_UserCount.Text = string.Format("（{0}人）", UserList.Count);
            }
        }
        /// <summary>
        /// 处理接收的客户端信息
        /// </summary>
        /// <param name="userState">客户端信息</param>
        private void ReceiveData(object userState)
        {
            UserInfo user = (UserInfo)userState;
            TcpClient client = user._TcpClient;
            while (IsExit == false)
            {
                string receiveData = null;
                try
                {
                    //从网络流中读出字符串，此方法会自动判断字符串长度前缀
                    receiveData = user._BinaryReader.ReadString();
                }
                catch (Exception)
                {
                    if (IsExit == false)
                    {
                        AddChatsToListBox(string.Format("与[{0}]断开连接，已终止接收该用户信息", client.Client.RemoteEndPoint));
                        //RemoveUser(user);
                    }
                    break;
                }
                AddChatsToListBox(string.Format("来自[{0}]：{1}", user._TcpClient.Client.RemoteEndPoint, receiveData));
                string[] arrData = receiveData.Split(',');
                switch (arrData[0])
                {
                    case "Login"://登录消息
                        user.UserName = arrData[1];
                        AddOnline(user.UserName);
                        SendToAllClient(user, receiveData);
                        break;
                    case "Logout"://退出消息
                        SendToAllClient(user, receiveData);
                        RemoveUser(user);
                        return;
                    case "Talk"://聊天消息
                        AddChatsToListBox(string.Format("{0}对{1}说：{2}", user.UserName, arrData[1], arrData[2]));
                        //SendToClient(user, "talk," + user.userName + "," + talkString);
                        foreach (UserInfo target in UserList)
                        {
                            //if (target.UserName == arrData[1] && user.UserName != arrData[1])
                            //{
                                SendToClient(target, "talk," + user.UserName + "," + arrData[2]);
                                break;
                            //}
                        }
                        break;
                    default:
                        AddChatsToListBox("什么意思啊：" + receiveData);
                        break;
                }
            }
        }
        /// <summary>
        /// 发送消息给所有客户
        /// </summary>
        /// <param name="user">指定发给哪个用户</param>
        /// <param name="message">信息内容</param>
        private void SendToAllClient(UserInfo user, string message)
        {
            string command = message.Split(',')[0].ToLower();
            if (command == "login")
            {
                //将所有用户在线状态通知到当前登录用户
                for (int i = 0; i < UserList.Count; i++)
                {
                    SendToClient(user, "login," + UserList[i].UserName);
                }
                //将当前登录用户上线状态，发送给所有客户端
                for (int i = 0; i < UserList.Count; i++)
                {
                    if (user.UserName != UserList[i].UserName)
                    {
                        SendToClient(UserList[i], "login," + user.UserName);
                    }
                }
            }
            else if (command == "logout")
            {
                for (int i = 0; i < UserList.Count; i++)
                {
                    if (UserList[i].UserName != user.UserName)
                    {
                        //将当前退出用户下线状态，发送给所有客户端
                        SendToClient(UserList[i], message);
                    }
                }
            }
        }

        /// <summary>
        /// 发送 message 给 user
        /// </summary>
        /// <param name="user">指定发给哪个用户</param>
        /// <param name="message">信息内容</param>
        private void SendToClient(UserInfo user, string message)
        {
            try
            {
                //将字符串写入网络流，此方法会自动附加字符串长度前缀
                user._BinaryWriter.Write(message);
                user._BinaryWriter.Flush();
                AddChatsToListBox(string.Format("向[{0}]发送：{1}", user.UserName, message));
            }
            catch
            {
                AddChatsToListBox(string.Format("向[{0}]发送信息失败", user.UserName));
            }
        }
        /// <summary>
        /// 移除用户
        /// </summary>
        /// <param name="user">指定要移除的用户</param>
        private void RemoveUser(UserInfo user)
        {
            UserList.Remove(user);
            user.Close();
            this.label_UserCount.Text = string.Format("（{0}人）", UserList.Count);
            RemoveUserByName(user.UserName);
        }
        private delegate void AddItemToListBoxDelegate(string str);
        /// <summary>
        /// 在listBox_Chats消息记录中追加信息
        /// </summary>
        /// <param name="str">要追加的信息</param>
        private void AddChatsToListBox(string str)
        {
            if (listBox_Chats.InvokeRequired)
            {
                AddItemToListBoxDelegate d = AddChatsToListBox;
                listBox_Chats.Invoke(d, str);
            }
            else
            {
                listBox_Chats.Items.Add(str);
                listBox_Chats.SelectedIndex = listBox_Chats.Items.Count - 1;
                listBox_Chats.ClearSelected();
            }
        }
        private delegate void AddOnlineDelegate(string message);
        /// <summary>
        /// 在在线框（lst_Online)中添加其他客户端信息
        /// </summary>
        /// <param name="userName"></param>
        private void AddOnline(string userName)
        {
            if (this.listBox_UserList.InvokeRequired)
            {
                AddOnlineDelegate d = new AddOnlineDelegate(AddOnline);
                listBox_UserList.Invoke(d, new object[] { userName });
            }
            else
            {
                listBox_UserList.Items.Add(userName);
                listBox_UserList.SelectedIndex = listBox_UserList.Items.Count - 1;
                listBox_UserList.ClearSelected();
            }
        }
        private delegate void RemoveUserNameDelegate(string userName);
        /// <summary>
        /// 移除指定Name的下线的用户
        /// </summary>
        /// <param name="userName"></param>
        private void RemoveUserByName(string userName)
        {
            if (listBox_UserList.InvokeRequired)
            {
                RemoveUserNameDelegate d = new RemoveUserNameDelegate(RemoveUserByName);
                listBox_UserList.Invoke(d, userName);
            }
            else
            {
                listBox_UserList.Items.Remove(userName);
                listBox_UserList.SelectedIndex = listBox_UserList.Items.Count - 1;
                listBox_UserList.ClearSelected();
            }
        }
       
        #endregion
    }
}
