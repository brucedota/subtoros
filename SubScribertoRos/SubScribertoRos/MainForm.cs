using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

/// <summary>
///主要实现了WinForm与ROS进行socket通信的功能，
///ROS作为Server，Winform进行Client
/// </summary>

namespace SubScribertoRos
{
    public partial class MainForm : Form
    {
        private TcpClients tcpclient ;

        private string _mess = string.Empty;

        private string strPath = string.Empty;

        private delegate void UpdateUI();
        private UpdateUI updateUi;

        public MainForm()
        {
            InitializeComponent();
            btnDisconn.Enabled = false;
        }

        private void ReceiveMess(Sockets sks)
        {
            ControlInvoker.Invoke(this, new ThreadStart(delegate
            {
                if (sks.ex != null)
                {
                    if (sks.ClientDispose == true)
                    {
                        //由于未知原因引发异常.导致客户端下线.   比如网络故障.或服务器断开连接.
                        //SetClientState(string.Format("客户端下线.!异常消息：{0}\r\n", sks.ex));
                    }
                    else
                    {
                        //SetClientState(string.Format("异常消息：{0}\r\n", sks.ex));
                    }
                    //timerConnect.Enabled = true;
                }
                else if (sks.Offset == 0)
                {
                    //客户端主动下线
                    // SetClientState("客户端下线.!");
                }
                else
                {
                    byte[] buffer = new byte[sks.Offset];
                    Array.Copy(sks.RecBuffer, buffer, sks.Offset);
                    string str = Encoding.UTF8.GetString(buffer);

                    strPath = Directory.GetParent( Environment.CurrentDirectory).Parent.FullName;
                    //此方式针对vs运行的程序有效，如果为直接启动exe，需要注意图片的路径

                    switch (str.Substring(0,1))
                    {
                        case "1":
                            strPath += @"/dnf.png";
                            
                            break;
                        case "2":
                            strPath += @"/lol.png";
                            break;
                        case "3":
                            strPath += @"/ahead.png";
                            
                            break;
                    }
                    updateUi?.Invoke(); //同步更新Panel
                    if (sks.Client.Client.Available > 0)//判断消息是否发送完成，socket的数据大小限制，分多个包发送
                    {
                        Console.Write(str);
                        _mess += str;
                    }
                    else
                    {
                        _mess = "";
                        _mess += str;
                       
                    }
                }
            }));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (tcpclient == null)
            {
                tcpclient = new TcpClients();
                tcpclient.pushSockets = ReceiveMess;
            }
            tcpclient.InitSocket(txtIP.Text, Convert.ToInt32(txtPort.Text));
            if (tcpclient.Start())
            {
                btnConnect.Enabled = false;
                btnDisconn.Enabled = true;
            }
            else
            {
                MessageBox.Show("IP、Port Not correct");
            }
           


        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            tcpclient.SendData(rtxSend.Text);
        }

        private void btnDisconn_Click(object sender, EventArgs e)
        {
            if(tcpclient !=null)
            {
                tcpclient.Stop();
                tcpclient = null;
                btnConnect.Enabled = true;
                btnDisconn.Enabled = false;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (_mess != string.Empty)
            {
                rtxRecv.Text = _mess;
                _mess = "";
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            updateUi = updatePanel; //用委托进行子线程更新UI
        }

        private void updatePanel()
        {
            //利用GDI画图
            Bitmap b = new Bitmap(strPath);
            Graphics g = Graphics.FromImage(b);
            panel1.BackgroundImage = b;
        }

        private void MainForm_load(object sender, EventArgs e)
        {
            //初始化client对象 ，并对委托进行client的委托初始化
            tcpclient = new TcpClients();
            tcpclient.pushSockets = ReceiveMess;
        }
    }
}
