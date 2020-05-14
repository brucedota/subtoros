﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace SubScribertoRos
{
    /// <summary>
    /// 自定义Socket对象
    /// </summary>
    public class Sockets
    {
        /// <summary>
        /// 空构造
        /// </summary>
        /// 
        
        public Sockets()
        {
        }
        /// <summary>
        /// 创建Sockets对象
        /// </summary>
        /// <param name="ip">Ip地址</param>
        /// <param name="client">TcpClient</param>
        /// <param name="ns">承载客户端Socket的网络流</param>
        public Sockets(IPEndPoint ip, TcpClient client, NetworkStream ns)
        {
            Ip = ip;
            Client = client;
            nStream = ns;
        }
        /// <summary>
        /// 创建Sockets对象
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pass">密码</param>
        /// <param name="ip">Ip地址</param>
        /// <param name="client">TcpClient</param>
        /// <param name="ns">承载客户端Socket的网络流</param>
        public Sockets(string name, string pass, IPEndPoint ip, TcpClient client, NetworkStream ns)
        {
            UserName = name;
            Password = pass;
            Ip = ip;
            Client = client;
            nStream = ns;
        }

        /// <summary>
        /// 接收缓冲区
        /// </summary>
        public byte[] RecBuffer = new byte[8 * 1024];
        /// <summary>
        /// 发送缓冲区
        /// </summary>
        public byte[] SendBuffer = new byte[8 * 1024];
        /// <summary>
        /// 异步接收后包的大小
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 当前IP地址,端口号
        /// </summary>
        public IPEndPoint Ip { get; set; }
        /// <summary>
        /// 客户端主通信程序
        /// </summary>
        public TcpClient Client { get; set; }
        /// <summary>
        /// 承载客户端Socket的网络流
        /// </summary>
        public NetworkStream nStream { get; set; }
        /// <summary>
        /// 发生异常时不为null.
        /// </summary>
        public Exception ex { get; set; }
        /// <summary>
        /// 新客户端标识.如果推送器发现此标识为true,那么认为是客户端上线
        /// 仅服务端有效
        /// </summary>
        public bool NewClientFlag { get; set; }
        /// <summary>
        /// 客户端退出标识.如果服务端发现此标识为true,那么认为客户端下线
        /// 客户端接收此标识时,认为客户端异常.
        /// </summary>
        public bool ClientDispose { get; set; }
    }


    /// <summary>
    /// Socket基类(抽象类)
    /// 抽象3个方法,初始化Socket(含一个构造),停止,启动方法.
    /// 此抽象类为TcpServer与TcpClient的基类,前者实现后者抽象方法.
    /// </summary>
    public abstract class SocketObject
    {
        public abstract void InitSocket(IPAddress ipaddress, int port);
        public abstract void InitSocket(string ipaddress, int port);
        public abstract bool Start();
        public abstract void Stop();
    }
}
