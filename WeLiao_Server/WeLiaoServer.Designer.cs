namespace WeLiao_Server
{
    partial class WeLiaoServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeLiaoServer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Chats = new System.Windows.Forms.ListBox();
            this.label_UserCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_UserList = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Start,
            this.toolStripSeparator1,
            this.toolStripButton_Stop});
            this.toolStrip1.Location = new System.Drawing.Point(9, 7);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(475, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Start.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Start.Image")));
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton_Start.Text = "启动服务器";
            this.toolStripButton_Start.Click += new System.EventHandler(this.toolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Stop
            // 
            this.toolStripButton_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Stop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Stop.Image")));
            this.toolStripButton_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Stop.Name = "toolStripButton_Stop";
            this.toolStripButton_Stop.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton_Stop.Text = "停止服务器";
            this.toolStripButton_Stop.Click += new System.EventHandler(this.toolStrip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "消息记录";
            // 
            // listBox_Chats
            // 
            this.listBox_Chats.FormattingEnabled = true;
            this.listBox_Chats.ItemHeight = 12;
            this.listBox_Chats.Location = new System.Drawing.Point(11, 62);
            this.listBox_Chats.Name = "listBox_Chats";
            this.listBox_Chats.Size = new System.Drawing.Size(283, 244);
            this.listBox_Chats.TabIndex = 5;
            // 
            // label_UserCount
            // 
            this.label_UserCount.AutoSize = true;
            this.label_UserCount.BackColor = System.Drawing.Color.Transparent;
            this.label_UserCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_UserCount.ForeColor = System.Drawing.Color.Red;
            this.label_UserCount.Location = new System.Drawing.Point(399, 44);
            this.label_UserCount.Name = "label_UserCount";
            this.label_UserCount.Size = new System.Drawing.Size(51, 12);
            this.label_UserCount.TabIndex = 9;
            this.label_UserCount.Text = "（0人）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(314, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "当前在线用户：";
            // 
            // listBox_UserList
            // 
            this.listBox_UserList.FormattingEnabled = true;
            this.listBox_UserList.ItemHeight = 12;
            this.listBox_UserList.Location = new System.Drawing.Point(315, 62);
            this.listBox_UserList.Name = "listBox_UserList";
            this.listBox_UserList.Size = new System.Drawing.Size(180, 244);
            this.listBox_UserList.TabIndex = 7;
            // 
            // WeicheServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 325);
            this.Controls.Add(this.label_UserCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_UserList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Chats);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WeicheServer";
            this.Text = "WeicheServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WeicheServer_FormClosed);
            this.Load += new System.EventHandler(this.WeicheServer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Start;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Chats;
        private System.Windows.Forms.Label label_UserCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_UserList;
    }
}