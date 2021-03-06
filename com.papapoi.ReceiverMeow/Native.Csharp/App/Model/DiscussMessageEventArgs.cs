﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Native.Csharp.App.Model
{
	public class DiscussMessageEventArgs : EventArgs
	{
		/// <summary>
		/// 消息Id
		/// </summary>
		public int MsgId { get; set; }
		/// <summary>
		/// 来源讨论组
		/// </summary>
		public long FromDiscuss { get; set; }
		/// <summary>
		/// 来源QQ
		/// </summary>
		public long FromQQ { get; set; }
		/// <summary>
		/// 消息内容
		/// </summary>
		public string Msg { get; set; }
		///// <summary>
		///// 字体指针
		///// </summary>
		//[Obsolete("此参数酷Q已不回传")]
		//public int Font { get; set; }

		/// <summary>
		/// 获取或设置一个值，该值指示是否处理过此事件
		/// </summary>
		public bool Handled { get; set; }
	}
}
