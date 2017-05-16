using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace SetTool
{
    class TCPHandler
    {
        public TcpClient tcpclient = null;
        protected NetworkStream tcpstream = null;

        public static byte[] ReceiveData = null;
        public static string State = "";

        public TCPHandler(string IP, int Port)
        {
            tcpstream = null;
            tcpclient = new TcpClient();
            tcpclient.BeginConnect(IPAddress.Parse(IP), Port, new AsyncCallback(Connected), tcpclient);
        }

        protected void Connected(IAsyncResult result)
        {
            try
            {
                TcpClient tcpclt = (TcpClient)result.AsyncState;
                if (tcpclt.Connected)
                {
                    tcpstream = tcpclt.GetStream();
                    byte[] data = new byte[2000];
                    tcpstream.BeginRead(data, 0, 2000, new AsyncCallback(DataRec), data);
                    State = "连接成功！";
                }
                else
                {
                    State = "连接超时！";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("<连接异常> " + ex.Message, "系统提示");
            }
        }

        protected void DataRec(IAsyncResult result)
        {
            try
            {
                if (tcpstream != null)
                {
                    int length = tcpstream.EndRead(result);
                    List<byte> data = new List<byte>();
                    data.AddRange((byte[])result.AsyncState);
                    data.RemoveRange(length, data.Count - length);
                    if (length != 0)
                    {
                        ReceiveData = data.ToArray();
                    }
                    byte[] data2 = new byte[2000];
                    tcpstream.BeginRead(data2, 0, 2000, new AsyncCallback(DataRec), data2);
                }
            }
            catch (Exception)
            {

            }
        }

        public void SendData(byte[] data)
        {
            if (tcpstream != null)
            {
                tcpstream.Write(data, 0, data.Length);
            }
        }

        public void Close()
        {
            if (tcpstream != null)
            {
                tcpstream.Dispose();
            }
            if (tcpclient != null)
            {
                tcpclient.Close();
            }
        }
    }
}
