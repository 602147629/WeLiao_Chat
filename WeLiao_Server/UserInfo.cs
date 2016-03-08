using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace WeLiao_Server
{
    /// <summary>
    /// 用户
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 提供客户端连接的TCP网络服务
        /// </summary>
        public TcpClient _TcpClient { get; private set; }
        /// <summary>
        /// 网络中的二进制读取流
        /// </summary>
        public BinaryReader _BinaryReader { get; private set; }
        /// <summary>
        /// 网络中的二进制写入流
        /// </summary>
        public BinaryWriter _BinaryWriter { get; private set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="client"></param>
        public UserInfo(TcpClient client)
        {
            this._TcpClient = client;
            //网络中的收发数据流
            NetworkStream networkStream = client.GetStream();
            //基于网络数据流创建二进制读写流
            this._BinaryReader = new BinaryReader(networkStream);
            this._BinaryWriter = new BinaryWriter(networkStream);
        }
        /// <summary>
        /// 关闭用户事件
        /// </summary>
        public void Close()
        {
            this._BinaryReader.Close();
            this._BinaryWriter.Close();
            this._TcpClient.Close();
        }
    }
}
