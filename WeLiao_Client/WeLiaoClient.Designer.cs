namespace WeLiao_Client
{
    partial class WeLiaoClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.button_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_UserList = new System.Windows.Forms.ListBox();
            this.listBox_Chats = new System.Windows.Forms.ListBox();
            this.button_SendMsg = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_ChatUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户名：";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(73, 13);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(136, 21);
            this.textBox_UserName.TabIndex = 4;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(460, 12);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(85, 23);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "登录服务器";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(237, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名：";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(296, 13);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(136, 21);
            this.textBox_Password.TabIndex = 4;
            // 
            // textBox_Content
            // 
            this.textBox_Content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Content.Location = new System.Drawing.Point(12, 252);
            this.textBox_Content.Multiline = true;
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.Size = new System.Drawing.Size(364, 101);
            this.textBox_Content.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(439, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "（0人）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(380, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "在线用户";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "聊天记录";
            // 
            // listBox_UserList
            // 
            this.listBox_UserList.FormattingEnabled = true;
            this.listBox_UserList.ItemHeight = 12;
            this.listBox_UserList.Location = new System.Drawing.Point(382, 61);
            this.listBox_UserList.Name = "listBox_UserList";
            this.listBox_UserList.Size = new System.Drawing.Size(162, 292);
            this.listBox_UserList.TabIndex = 6;
            // 
            // listBox_Chats
            // 
            this.listBox_Chats.FormattingEnabled = true;
            this.listBox_Chats.ItemHeight = 12;
            this.listBox_Chats.Location = new System.Drawing.Point(12, 61);
            this.listBox_Chats.Name = "listBox_Chats";
            this.listBox_Chats.Size = new System.Drawing.Size(364, 184);
            this.listBox_Chats.TabIndex = 7;
            // 
            // button_SendMsg
            // 
            this.button_SendMsg.Location = new System.Drawing.Point(85, 368);
            this.button_SendMsg.Name = "button_SendMsg";
            this.button_SendMsg.Size = new System.Drawing.Size(85, 23);
            this.button_SendMsg.TabIndex = 5;
            this.button_SendMsg.Text = "发送消息";
            this.button_SendMsg.UseVisualStyleBackColor = true;
            this.button_SendMsg.Click += new System.EventHandler(this.button_SendMsg_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(195, 368);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(85, 23);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "退出聊天";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_ChatUser
            // 
            this.label_ChatUser.AutoSize = true;
            this.label_ChatUser.BackColor = System.Drawing.Color.Transparent;
            this.label_ChatUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_ChatUser.Location = new System.Drawing.Point(71, 42);
            this.label_ChatUser.Name = "label_ChatUser";
            this.label_ChatUser.Size = new System.Drawing.Size(161, 12);
            this.label_ChatUser.TabIndex = 10;
            this.label_ChatUser.Tag = "当前聊天对象：{0}";
            this.label_ChatUser.Text = "聊天对象当前聊天对象：张三";
            // 
            // WeicheClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 412);
            this.Controls.Add(this.textBox_Content);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ChatUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_UserList);
            this.Controls.Add(this.listBox_Chats);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_SendMsg);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label4);
            this.Name = "WeicheClient";
            this.Text = "WeicheServer";
            this.Load += new System.EventHandler(this.WeicheServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_UserList;
        private System.Windows.Forms.ListBox listBox_Chats;
        private System.Windows.Forms.Button button_SendMsg;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_ChatUser;
    }
}