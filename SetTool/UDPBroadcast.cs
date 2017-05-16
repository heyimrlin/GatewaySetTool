using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace SetTool
{
    class UDPBroadcast
    {
        public static List<string> gwIP = new List<string>();
        protected Thread receiveThread;

        public static string ReceiveData = "msg";
        public static string Handshake = "握手：发送 0；接收 0 ";
        public static int send = 0;
        public static int receive = 0;

        public void SendThread()
        {
            try
            {
                UdpClient UDPSend = new UdpClient(new IPEndPoint(IPAddress.Any, 0));
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Broadcast, 8800);

                byte[] buf = Utils.parseData("FD", JsonData.JsonHandshake());

                receiveThread = new Thread(new ThreadStart(RecvThread));
                receiveThread.IsBackground = true;
                receiveThread.Start();

                while (true)
                {
                    UDPSend.Send(buf, buf.Length, endpoint);
                    send++;
                    Handshake = "握手：发送 " + send + "；接收 " + receive;
                    Thread.Sleep(1000);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("握手失败！", "系统提示");
            }
        }

        protected void RecvThread()
        {
            try
            {
                UdpClient UDPReceive = new UdpClient(new IPEndPoint(IPAddress.Any, 8800));
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);

                while (true)
                {
                    byte[] buf = UDPReceive.Receive(ref endpoint);
                    receive++;
                    Handshake = "握手：发送 " + send + "；接收 " + receive;

                    JObject jo = Utils.analysisData(buf);
                    if (jo != null)
                    {
                        string name = (string)jo.GetValue("name");
                        string gatewayIP = (string)jo.GetValue("gateway_ip");

                        if (name == "pc")
                        {
                            receive--;
                            Handshake = "握手：发送 " + send + "；接收 " + receive;
                        }

                        if (name == "leelen_gw" && gatewayIP != null && gwIP.Contains(gatewayIP) != true)
                        {
                            gwIP.Add(gatewayIP);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("8800端口已被占用！","系统提示");
                Application.Exit();
            }
        }
    }
}
