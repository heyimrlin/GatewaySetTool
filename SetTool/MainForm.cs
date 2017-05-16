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
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;

namespace SetTool
{
    public partial class MainForm : Form
    {
        UDPBroadcast broadcast = null;
        Thread Thread_Broadcast = null;
        TCPHandler handler = null;

        public MainForm()
        {
            InitializeComponent();
            broadcast = new UDPBroadcast();
            Thread_Broadcast = new Thread(new ThreadStart(broadcast.SendThread));
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Thread_Broadcast.IsBackground = true;
            Thread_Broadcast.Start();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (handler != null)
            {
                handler.Close();
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.Checked = true;
            中文ToolStripMenuItem.Checked = false;
        }

        private void 中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.Checked = false;
            中文ToolStripMenuItem.Checked = true;
        }

        private void btn_broadcast_Click(object sender, EventArgs e)    //搜索网关设备
        {
            if (btn_broadcast.Text == "开始搜索")
            {
                Thread_Broadcast.Resume();
                btn_broadcast.Text = "停止搜索";
            }
            else if (btn_broadcast.Text == "停止搜索")
            {
                Thread_Broadcast.Suspend();
                btn_broadcast.Text = "开始搜索";
            }
        }

        private void Timer_RefreshIPList_Tick(object sender, EventArgs e)    // 加载网关设备IP地址列表
        {
            dg_gw_IPList.Rows.Clear();

            List<string> IPList = new List<string>();
            foreach (DataGridViewRow row in dg_gw_IPList.Rows)
            {
                if (row.Cells["column_gw_ip"].Value != null)
                {
                    IPList.Add(row.Cells["column_gw_ip"].Value.ToString());
                }
            }

            for (int i = 0; i < UDPBroadcast.gwIP.Count; i++)
            {
                string ip = UDPBroadcast.gwIP.ElementAt(i).ToString();
                if (IPList.Contains(ip) != true)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    int index = dg_gw_IPList.Rows.Add(row);
                    dg_gw_IPList.Rows[index].Cells[0].Value = ip;
                    //txt_DevIP.Text = ip;
                }
            }

            if (btn_broadcast.Text == "停止搜索")
            {
                UDPBroadcast.gwIP.Clear();
            }
        }

        private void Timer_sbTips_Tick(object sender, EventArgs e)    //状态栏
        {
            sb_tips0.Text = UDPBroadcast.Handshake;
            sb_tips1.Text = TCPHandler.State;
        }

        private void btn_login_Click(object sender, EventArgs e)    // 连接并登录网关设备
        {
            IPAddress ip;
            try
            {
                ip = IPAddress.Parse(txt_DevIP.Text);//当前网关设备IP地址是否合法
            }
            catch (Exception error)
            {
                MessageBox.Show("<当前网关设备IP地址输入格式错误> " + error.Message, "系统提示");
                txt_DevIP.Focus();
                return;
            }

            string name = txt_user.Text;
            string passwd = txt_passwd.Text;

            handler = new TCPHandler(txt_DevIP.Text, 8811);
            if (handler != null)
            {
                Thread.Sleep(100);
                byte[] buf = Utils.parseData("FE", JsonData.JsonLogin(name, passwd));
                handler.SendData(buf);
                Thread.Sleep(100);
                byte[] data = TCPHandler.ReceiveData;

                if (data != null)
                {
                    JObject jo = Utils.analysisData(data);
                    if (jo != null)
                    {
                        string confirm = (string)jo.GetValue("confirm");
                        switch (confirm)
                        {
                            case "yes":
                                TCPHandler.State = "用户登录成功！";
                                panel_set.Location = new Point(14, 38);
                                btn_get_Click(sender, e);
                                break;
                            case "name error":
                                TCPHandler.State = "用户登录失败！";
                                handler.Close();
                                MessageBox.Show("<用户登录失败> 用户名错误！", "系统提示");
                                break;
                            case "passwd error":
                                TCPHandler.State = "用户登录失败！";
                                handler.Close();
                                MessageBox.Show("<用户登录失败> 密码错误！", "系统提示");
                                break;
                        }
                    }
                    TCPHandler.ReceiveData = null;
                }
                else
                {
                    handler.Close();
                    MessageBox.Show("<用户登录失败> 网关设备无响应！", "系统提示");
                }
            }
            else
            {
                MessageBox.Show("连接失败，请重试！", "系统提示");
            }
        }

        private void btn_get_Click(object sender, EventArgs e)      // 获取网关配置信息
        {
            if (handler != null)
            {
                Thread.Sleep(100);
                byte[] buf = Utils.parseData("FA", JsonData.JsonGetSysInfo());
                handler.SendData(buf);
                Thread.Sleep(100);
                byte[] data = TCPHandler.ReceiveData;

                if (data != null)
                {
                    data = TCPHandler.ReceiveData;
                    JObject jo = Utils.analysisData(data);
                    if (jo != null)
                    {
                        jo = (JObject)jo.GetValue("gateway_info");
                        if (jo != null)
                        {
                            txt_gwIP.Text = (string)jo.GetValue("ip");
                            txt_gwMask.Text = (string)jo.GetValue("mask");
                            txt_gwBcast.Text = (string)jo.GetValue("bcast");
                            txt_gwMac.Text = (string)jo.GetValue("mac");
                            txt_gwPermit.Text = (string)jo.GetValue("pro_info");
                            txt_authority.Text = (string)jo.GetValue("authority");
                            txt_gwIPMode.Text = (string)jo.GetValue("ip_mode");
                            txt_swVersion.Text = (string)jo.GetValue("version");
                            text_user.Text = (string)jo.GetValue("name");
                            text_passwd.Text = (string)jo.GetValue("passwd");

                            TCPHandler.State = "获取网关配置信息成功！";
                        }
                        else
                        {
                            TCPHandler.State = "获取网关配置信息失败！";
                            MessageBox.Show("<获取网关配置信息失败> 数据解析出错！", "系统提示");
                        }
                        TCPHandler.ReceiveData = null;
                    }
                }
                else
                {
                    MessageBox.Show("<获取网关配置信息失败> 网关设备无响应！", "系统提示");
                }
            }
            else
            {
                MessageBox.Show("连接失败，请重试！", "系统提示");
                panel_set.Location = new Point(599, 38);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)    //退出
        {
            panel_set.Location = new Point(599, 38);
            if (handler != null)
            {
                handler.Close();
            }
        }

        private void btn_set_Click(object sender, EventArgs e)    //上传网关配置信息
        {
            IPAddress ip;

            //IP地址是否合法
            try
            {
                ip = IPAddress.Parse(txt_gwIP.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("<IP地址输入格式错误> " + error.Message, "系统提示");
                txt_gwIP.Focus();
                return;
            }

            //子网掩码是否合法
            try
            {
                ip = IPAddress.Parse(txt_gwMask.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("<子网掩码输入格式错误> " + error.Message, "系统提示");
                txt_gwMask.Focus();
                return;
            }

            //广播地址是否合法
            try
            {
                ip = IPAddress.Parse(txt_gwBcast.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("<广播地址输入格式错误> " + error.Message, "系统提示");
                txt_gwBcast.Focus();
                return;
            }

            if (handler != null)
            {
                Thread.Sleep(100);
                byte[] buf = Utils.parseData("FA", JsonData.JsonSetSysInfo(txt_gwIP.Text, txt_gwMask.Text, txt_gwBcast.Text, txt_gwMac.Text,
                        txt_gwPermit.Text, txt_authority.Text, txt_gwIPMode.Text, txt_swVersion.Text, text_user.Text, text_passwd.Text));
                handler.SendData(buf);
                Thread.Sleep(100);
                byte[] data = TCPHandler.ReceiveData;

                if (data != null)
                {
                    data = TCPHandler.ReceiveData;
                    JObject jo = Utils.analysisData(data);
                    if (jo != null)
                    {
                        string confirm = (string)jo.GetValue("set_ret");
                        if (confirm == "yes")
                        {
                            TCPHandler.State = "上传网关配置信息成功！";
                            panel_set.Location = new Point(599, 38);
                            handler.Close();
                        }
                        else
                        {
                            MessageBox.Show(confirm, "系统提示");
                        }
                    }
                    TCPHandler.ReceiveData = null;
                }
                else
                {
                    MessageBox.Show("<上传网关配置信息失败> 网关设备无响应！", "系统提示");
                }
            }
            else
            {
                MessageBox.Show("连接失败，请重试！", "系统提示");
                panel_set.Location = new Point(599, 38);
            }
        }

        private void btn_swupdate_Click(object sender, EventArgs e)    //软件升级
        {
            if (OpenfileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileUrl = OpenfileDialog.FileName;
                byte[] swfile = AuthGetFileData(fileUrl);

                if (handler != null)
                {
                    Thread.Sleep(100);
                    byte[] buf = Utils.parseData("FC", JsonData.JsonUpdate("sf_update", swfile.Length));
                    handler.SendData(buf);
                    Thread.Sleep(100);
                    byte[] data = TCPHandler.ReceiveData;

                    if (data != null)
                    {
                        data = TCPHandler.ReceiveData;
                        JObject jo = Utils.analysisData(data);
                        if (jo != null)
                        {
                            string confirm = (string)jo.GetValue("confirm");
                            if (confirm == "yes")
                            {
                                int i = swfile.Length % 1460;
                                byte[] buf1 = swfile.Skip(0).Take(swfile.Length - i).ToArray();
                                byte[] buf2 = swfile.Skip(swfile.Length - i).Take(i).ToArray();
                                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                                handler.SendData(buf1);
                                handler.SendData(buf2);
                                this.Cursor = System.Windows.Forms.Cursors.Arrow;

                                TCPHandler.State = "上传软件升级文件成功！";

                                panel_set.Location = new Point(599, 38);
                                if (handler != null)
                                {
                                    handler.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show(confirm, "系统提示");
                            }
                        }
                        TCPHandler.ReceiveData = null;
                    }
                    else
                    {
                        MessageBox.Show("<上传软件升级文件失败> 网关设备无响应！", "系统提示");
                    }
                }
                else
                {
                    MessageBox.Show("连接失败，请重试！", "系统提示");
                    panel_set.Location = new Point(599, 38);
                }
            }
            else
            {
                return;
            }
        }

        private void btn_sysupdate_Click(object sender, EventArgs e)   //系统更新
        {
            if (OpenfileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileUrl = OpenfileDialog.FileName;
                byte[] swfile = AuthGetFileData(fileUrl);

                if (handler != null)
                {
                    Thread.Sleep(100);
                    byte[] buf = Utils.parseData("FC", JsonData.JsonUpdate("sy_update", swfile.Length));
                    handler.SendData(buf);
                    Thread.Sleep(100);
                    byte[] data = TCPHandler.ReceiveData;

                    if (data != null)
                    {
                        data = TCPHandler.ReceiveData;
                        JObject jo = Utils.analysisData(data);
                        if (jo != null)
                        {
                            string confirm = (string)jo.GetValue("confirm");
                            if (confirm == "yes")
                            {
                                int i = swfile.Length % 1460;
                                byte[] buf1 = swfile.Skip(0).Take(swfile.Length - i).ToArray();
                                byte[] buf2 = swfile.Skip(swfile.Length - i).Take(i).ToArray();
                                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                                handler.SendData(buf1);
                                handler.SendData(buf2);
                                this.Cursor = System.Windows.Forms.Cursors.Arrow;

                                TCPHandler.State = "上传系统更新文件成功！";

                                panel_set.Location = new Point(599, 38);
                                if (handler != null)
                                {
                                    handler.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show(confirm, "系统提示");
                            }
                        }
                        TCPHandler.ReceiveData = null;
                    }
                    else
                    {
                        MessageBox.Show("<上传系统更新文件失败> 网关设备无响应！", "系统提示");
                    }
                }
                else
                {
                    MessageBox.Show("连接失败，请重试！", "系统提示");
                    panel_set.Location = new Point(599, 38);
                }
            }
            else
            {
                return;
            }
        }

        private void btn_refactory_Click(object sender, EventArgs e)    //恢复出厂设置
        {
            Confirm result = new Confirm();
            result.msg = "是否恢复出厂设置？";
            result.Text = "恢复出厂设置";
            result.ShowDialog();
            if (result.DialogResult == DialogResult.OK)
            {
                result.Close();

                if (handler != null)
                {
                    Thread.Sleep(100);
                    byte[] buf = Utils.parseData("FB", JsonData.JsonRefactory());
                    handler.SendData(buf);
                    Thread.Sleep(100);
                    byte[] data = TCPHandler.ReceiveData;

                    if (data != null)
                    {
                        data = TCPHandler.ReceiveData;
                        JObject jo = Utils.analysisData(data);
                        if (jo != null)
                        {
                            string confirm = (string)jo.GetValue("rep_refactory");
                            if (confirm == "yes")
                            {
                                TCPHandler.State = "恢复出厂设置成功！";

                                panel_set.Location = new Point(599, 38);
                                if (handler != null)
                                {
                                    handler.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show(confirm, "系统提示");
                            }
                        }
                        TCPHandler.ReceiveData = null;
                    }
                    else
                    {
                        MessageBox.Show("<恢复出厂设置失败> 网关设备无响应！", "系统提示");
                    }
                }
                else
                {
                    MessageBox.Show("连接失败，请重试！", "系统提示");
                    panel_set.Location = new Point(599, 38);
                }
            }
            else
            {
                result.Close();
                return;
            }
        }

        private void btn_reboot_Click(object sender, EventArgs e)    //重启设备
        {
            Confirm result = new Confirm();
            result.msg = "是否重启设备？";
            result.Text = "重启设备";
            result.ShowDialog();
            if (result.DialogResult == DialogResult.OK)
            {
                result.Close();

                if (handler != null)
                {
                    Thread.Sleep(100);
                    byte[] buf = Utils.parseData("FB", JsonData.JsonReboot());
                    handler.SendData(buf);
                    TCPHandler.State = "重启设备成功！";

                    panel_set.Location = new Point(599, 38);
                    if (handler != null)
                    {
                        handler.Close();
                    }
                }
                else
                {
                    MessageBox.Show("连接失败，请重试！", "系统提示");
                    panel_set.Location = new Point(599, 38);
                }
            }
            else
            {
                result.Close();
                return;
            }
        }

        private byte[] AuthGetFileData(string fileUrl)      // 文件转换为字节数组
        {
            using (FileStream fs = new FileStream(fileUrl, FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] buffer = new byte[fs.Length];
                using (BinaryReader br = new BinaryReader(fs))
                {
                    br.Read(buffer, 0, buffer.Length);
                    br.Close();
                }
                return buffer;
            }
        }

        private void dg_gw_IPList_DoubleClick(object sender, EventArgs e)
        {
            if (dg_gw_IPList.CurrentCell.Value != null)
            {
                txt_DevIP.Text = dg_gw_IPList.CurrentCell.Value.ToString();
            }
        }
    }
}
