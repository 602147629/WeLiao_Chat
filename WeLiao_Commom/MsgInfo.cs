using System;
using System.Collections.Generic;
using System.Text;

namespace WeLiao_Commom
{
    /// <summary>
    /// 通讯间的消息实体
    /// </summary>
    [Serializable]
    public class MsgInfo
    {
        /// <summary>
        /// 类别
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 命令
        /// </summary>
        public string Command { get; set; }
        /// <summary>
        /// 消息发送的来源
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// 消息发至的目标
        /// </summary>
        public string Target { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; set; }
    }
}
