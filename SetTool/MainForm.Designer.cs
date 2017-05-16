namespace SetTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.语言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dg_gw_IPList = new System.Windows.Forms.DataGridView();
            this.column_gw_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_broadcast = new System.Windows.Forms.Button();
            this.txt_DevIP = new System.Windows.Forms.TextBox();
            this.lab_DevIP = new System.Windows.Forms.Label();
            this.txt_passwd = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lab_passwd = new System.Windows.Forms.Label();
            this.lab_user = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.sb_tips0 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sb_tips1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer_RefreshIPList = new System.Windows.Forms.Timer(this.components);
            this.Timer_sbTips = new System.Windows.Forms.Timer(this.components);
            this.panel_set = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_reboot = new System.Windows.Forms.Button();
            this.btn_sysupdate = new System.Windows.Forms.Button();
            this.btn_refactory = new System.Windows.Forms.Button();
            this.btn_swupdate = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.txt_gwPermit = new System.Windows.Forms.MaskedTextBox();
            this.text_passwd = new System.Windows.Forms.TextBox();
            this.text_user = new System.Windows.Forms.TextBox();
            this.txt_gwBcast = new System.Windows.Forms.TextBox();
            this.txt_gwMask = new System.Windows.Forms.TextBox();
            this.txt_gwIP = new System.Windows.Forms.TextBox();
            this.txt_gwMac = new System.Windows.Forms.Label();
            this.txt_authority = new System.Windows.Forms.Label();
            this.txt_gwIPMode = new System.Windows.Forms.Label();
            this.txt_swVersion = new System.Windows.Forms.Label();
            this.label_passwd = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.lab_swVersion = new System.Windows.Forms.Label();
            this.lab_gwIPMode = new System.Windows.Forms.Label();
            this.lab_authority = new System.Windows.Forms.Label();
            this.lab_gwPermit = new System.Windows.Forms.Label();
            this.lab_gwMac = new System.Windows.Forms.Label();
            this.lab_gwBcast = new System.Windows.Forms.Label();
            this.lab_gwMask = new System.Windows.Forms.Label();
            this.lab_gwIP = new System.Windows.Forms.Label();
            this.OpenfileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menu_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_gw_IPList)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_main
            // 
            this.menu_main.BackColor = System.Drawing.Color.White;
            this.menu_main.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.语言ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(594, 27);
            this.menu_main.TabIndex = 0;
            // 
            // 语言ToolStripMenuItem
            // 
            this.语言ToolStripMenuItem.Checked = true;
            this.语言ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.语言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.语言ToolStripMenuItem.Name = "语言ToolStripMenuItem";
            this.语言ToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.语言ToolStripMenuItem.Text = "语言";
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Checked = true;
            this.中文ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.中文ToolStripMenuItem.Text = "中文";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.中文ToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // dg_gw_IPList
            // 
            this.dg_gw_IPList.BackgroundColor = System.Drawing.Color.White;
            this.dg_gw_IPList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_gw_IPList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_gw_ip});
            this.dg_gw_IPList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_gw_IPList.Location = new System.Drawing.Point(14, 79);
            this.dg_gw_IPList.Name = "dg_gw_IPList";
            this.dg_gw_IPList.RowTemplate.Height = 23;
            this.dg_gw_IPList.Size = new System.Drawing.Size(245, 349);
            this.dg_gw_IPList.TabIndex = 4;
            this.dg_gw_IPList.DoubleClick += new System.EventHandler(this.dg_gw_IPList_DoubleClick);
            // 
            // column_gw_ip
            // 
            this.column_gw_ip.HeaderText = "网关设备IP地址列表";
            this.column_gw_ip.Name = "column_gw_ip";
            this.column_gw_ip.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "在线列表";
            // 
            // btn_broadcast
            // 
            this.btn_broadcast.AutoSize = true;
            this.btn_broadcast.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_broadcast.Location = new System.Drawing.Point(184, 38);
            this.btn_broadcast.Name = "btn_broadcast";
            this.btn_broadcast.Size = new System.Drawing.Size(75, 30);
            this.btn_broadcast.TabIndex = 39;
            this.btn_broadcast.Text = "停止搜索";
            this.btn_broadcast.UseVisualStyleBackColor = true;
            this.btn_broadcast.Click += new System.EventHandler(this.btn_broadcast_Click);
            // 
            // txt_DevIP
            // 
            this.txt_DevIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_DevIP.Location = new System.Drawing.Point(437, 187);
            this.txt_DevIP.Name = "txt_DevIP";
            this.txt_DevIP.Size = new System.Drawing.Size(141, 29);
            this.txt_DevIP.TabIndex = 63;
            // 
            // lab_DevIP
            // 
            this.lab_DevIP.AutoSize = true;
            this.lab_DevIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_DevIP.Location = new System.Drawing.Point(275, 191);
            this.lab_DevIP.Name = "lab_DevIP";
            this.lab_DevIP.Size = new System.Drawing.Size(157, 21);
            this.lab_DevIP.TabIndex = 62;
            this.lab_DevIP.Text = "当前网关设备IP地址:";
            // 
            // txt_passwd
            // 
            this.txt_passwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_passwd.Location = new System.Drawing.Point(366, 281);
            this.txt_passwd.MaxLength = 30;
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.PasswordChar = '*';
            this.txt_passwd.Size = new System.Drawing.Size(141, 29);
            this.txt_passwd.TabIndex = 67;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_user.Location = new System.Drawing.Point(366, 239);
            this.txt_user.MaxLength = 30;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(141, 29);
            this.txt_user.TabIndex = 66;
            // 
            // lab_passwd
            // 
            this.lab_passwd.AutoSize = true;
            this.lab_passwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_passwd.Location = new System.Drawing.Point(286, 283);
            this.lab_passwd.Name = "lab_passwd";
            this.lab_passwd.Size = new System.Drawing.Size(58, 21);
            this.lab_passwd.TabIndex = 65;
            this.lab_passwd.Text = "密码：";
            // 
            // lab_user
            // 
            this.lab_user.AutoSize = true;
            this.lab_user.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_user.Location = new System.Drawing.Point(286, 243);
            this.lab_user.Name = "lab_user";
            this.lab_user.Size = new System.Drawing.Size(74, 21);
            this.lab_user.TabIndex = 64;
            this.lab_user.Text = "用户名：";
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.Location = new System.Drawing.Point(524, 280);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(52, 31);
            this.btn_login.TabIndex = 68;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb_tips0,
            this.sb_tips1});
            this.StatusBar.Location = new System.Drawing.Point(0, 436);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(594, 26);
            this.StatusBar.TabIndex = 69;
            // 
            // sb_tips0
            // 
            this.sb_tips0.AutoToolTip = true;
            this.sb_tips0.Name = "sb_tips0";
            this.sb_tips0.Size = new System.Drawing.Size(50, 21);
            this.sb_tips0.Text = "sbtips0";
            // 
            // sb_tips1
            // 
            this.sb_tips1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sb_tips1.Name = "sb_tips1";
            this.sb_tips1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sb_tips1.Size = new System.Drawing.Size(54, 21);
            this.sb_tips1.Text = "sbtips1";
            // 
            // Timer_RefreshIPList
            // 
            this.Timer_RefreshIPList.Enabled = true;
            this.Timer_RefreshIPList.Interval = 1000;
            this.Timer_RefreshIPList.Tick += new System.EventHandler(this.Timer_RefreshIPList_Tick);
            // 
            // Timer_sbTips
            // 
            this.Timer_sbTips.Enabled = true;
            this.Timer_sbTips.Tick += new System.EventHandler(this.Timer_sbTips_Tick);
            // 
            // panel_set
            // 
            this.panel_set.Controls.Add(this.btn_back);
            this.panel_set.Controls.Add(this.btn_reboot);
            this.panel_set.Controls.Add(this.btn_sysupdate);
            this.panel_set.Controls.Add(this.btn_refactory);
            this.panel_set.Controls.Add(this.btn_swupdate);
            this.panel_set.Controls.Add(this.btn_get);
            this.panel_set.Controls.Add(this.btn_set);
            this.panel_set.Controls.Add(this.txt_gwPermit);
            this.panel_set.Controls.Add(this.text_passwd);
            this.panel_set.Controls.Add(this.text_user);
            this.panel_set.Controls.Add(this.txt_gwBcast);
            this.panel_set.Controls.Add(this.txt_gwMask);
            this.panel_set.Controls.Add(this.txt_gwIP);
            this.panel_set.Controls.Add(this.txt_gwMac);
            this.panel_set.Controls.Add(this.txt_authority);
            this.panel_set.Controls.Add(this.txt_gwIPMode);
            this.panel_set.Controls.Add(this.txt_swVersion);
            this.panel_set.Controls.Add(this.label_passwd);
            this.panel_set.Controls.Add(this.label_user);
            this.panel_set.Controls.Add(this.lab_swVersion);
            this.panel_set.Controls.Add(this.lab_gwIPMode);
            this.panel_set.Controls.Add(this.lab_authority);
            this.panel_set.Controls.Add(this.lab_gwPermit);
            this.panel_set.Controls.Add(this.lab_gwMac);
            this.panel_set.Controls.Add(this.lab_gwBcast);
            this.panel_set.Controls.Add(this.lab_gwMask);
            this.panel_set.Controls.Add(this.lab_gwIP);
            this.panel_set.Location = new System.Drawing.Point(599, 38);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(564, 390);
            this.panel_set.TabIndex = 70;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_back.ForeColor = System.Drawing.Color.Green;
            this.btn_back.Location = new System.Drawing.Point(477, 353);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 31);
            this.btn_back.TabIndex = 90;
            this.btn_back.Text = "退出";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_reboot
            // 
            this.btn_reboot.AutoSize = true;
            this.btn_reboot.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reboot.Location = new System.Drawing.Point(379, 240);
            this.btn_reboot.Name = "btn_reboot";
            this.btn_reboot.Size = new System.Drawing.Size(84, 31);
            this.btn_reboot.TabIndex = 89;
            this.btn_reboot.Text = "重启设备";
            this.btn_reboot.UseVisualStyleBackColor = true;
            this.btn_reboot.Click += new System.EventHandler(this.btn_reboot_Click);
            // 
            // btn_sysupdate
            // 
            this.btn_sysupdate.AutoSize = true;
            this.btn_sysupdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sysupdate.Location = new System.Drawing.Point(379, 140);
            this.btn_sysupdate.Name = "btn_sysupdate";
            this.btn_sysupdate.Size = new System.Drawing.Size(84, 31);
            this.btn_sysupdate.TabIndex = 88;
            this.btn_sysupdate.Text = "系统更新";
            this.btn_sysupdate.UseVisualStyleBackColor = true;
            this.btn_sysupdate.Click += new System.EventHandler(this.btn_sysupdate_Click);
            // 
            // btn_refactory
            // 
            this.btn_refactory.AutoSize = true;
            this.btn_refactory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_refactory.Location = new System.Drawing.Point(379, 190);
            this.btn_refactory.Name = "btn_refactory";
            this.btn_refactory.Size = new System.Drawing.Size(84, 31);
            this.btn_refactory.TabIndex = 87;
            this.btn_refactory.Text = "恢复出厂";
            this.btn_refactory.UseVisualStyleBackColor = true;
            this.btn_refactory.Click += new System.EventHandler(this.btn_refactory_Click);
            // 
            // btn_swupdate
            // 
            this.btn_swupdate.AutoSize = true;
            this.btn_swupdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_swupdate.Location = new System.Drawing.Point(379, 90);
            this.btn_swupdate.Name = "btn_swupdate";
            this.btn_swupdate.Size = new System.Drawing.Size(84, 31);
            this.btn_swupdate.TabIndex = 86;
            this.btn_swupdate.Text = "软件升级";
            this.btn_swupdate.UseVisualStyleBackColor = true;
            this.btn_swupdate.Click += new System.EventHandler(this.btn_swupdate_Click);
            // 
            // btn_get
            // 
            this.btn_get.AutoSize = true;
            this.btn_get.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_get.Location = new System.Drawing.Point(379, 40);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(84, 31);
            this.btn_get.TabIndex = 84;
            this.btn_get.Text = "获取配置";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_set
            // 
            this.btn_set.AutoSize = true;
            this.btn_set.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_set.ForeColor = System.Drawing.Color.Green;
            this.btn_set.Location = new System.Drawing.Point(289, 353);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(84, 31);
            this.btn_set.TabIndex = 83;
            this.btn_set.Text = "上传配置";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // txt_gwPermit
            // 
            this.txt_gwPermit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gwPermit.Location = new System.Drawing.Point(121, 160);
            this.txt_gwPermit.Name = "txt_gwPermit";
            this.txt_gwPermit.PromptChar = ' ';
            this.txt_gwPermit.Size = new System.Drawing.Size(141, 29);
            this.txt_gwPermit.TabIndex = 80;
            // 
            // text_passwd
            // 
            this.text_passwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_passwd.Location = new System.Drawing.Point(105, 360);
            this.text_passwd.MaxLength = 30;
            this.text_passwd.Name = "text_passwd";
            this.text_passwd.Size = new System.Drawing.Size(141, 29);
            this.text_passwd.TabIndex = 82;
            // 
            // text_user
            // 
            this.text_user.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_user.Location = new System.Drawing.Point(105, 320);
            this.text_user.MaxLength = 30;
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(141, 29);
            this.text_user.TabIndex = 81;
            // 
            // txt_gwBcast
            // 
            this.txt_gwBcast.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gwBcast.Location = new System.Drawing.Point(121, 80);
            this.txt_gwBcast.Name = "txt_gwBcast";
            this.txt_gwBcast.Size = new System.Drawing.Size(141, 29);
            this.txt_gwBcast.TabIndex = 79;
            // 
            // txt_gwMask
            // 
            this.txt_gwMask.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gwMask.Location = new System.Drawing.Point(121, 40);
            this.txt_gwMask.Name = "txt_gwMask";
            this.txt_gwMask.Size = new System.Drawing.Size(141, 29);
            this.txt_gwMask.TabIndex = 78;
            // 
            // txt_gwIP
            // 
            this.txt_gwIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gwIP.Location = new System.Drawing.Point(92, 0);
            this.txt_gwIP.Name = "txt_gwIP";
            this.txt_gwIP.Size = new System.Drawing.Size(141, 29);
            this.txt_gwIP.TabIndex = 77;
            // 
            // txt_gwMac
            // 
            this.txt_gwMac.AutoSize = true;
            this.txt_gwMac.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gwMac.Location = new System.Drawing.Point(127, 123);
            this.txt_gwMac.Name = "txt_gwMac";
            this.txt_gwMac.Size = new System.Drawing.Size(0, 21);
            this.txt_gwMac.TabIndex = 76;
            // 
            // txt_authority
            // 
            this.txt_authority.AutoSize = true;
            this.txt_authority.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_authority.Location = new System.Drawing.Point(121, 203);
            this.txt_authority.Name = "txt_authority";
            this.txt_authority.Size = new System.Drawing.Size(0, 21);
            this.txt_authority.TabIndex = 75;
            // 
            // txt_gwIPMode
            // 
            this.txt_gwIPMode.AutoSize = true;
            this.txt_gwIPMode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gwIPMode.Location = new System.Drawing.Point(136, 243);
            this.txt_gwIPMode.Name = "txt_gwIPMode";
            this.txt_gwIPMode.Size = new System.Drawing.Size(0, 21);
            this.txt_gwIPMode.TabIndex = 74;
            // 
            // txt_swVersion
            // 
            this.txt_swVersion.AutoSize = true;
            this.txt_swVersion.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_swVersion.Location = new System.Drawing.Point(121, 283);
            this.txt_swVersion.Name = "txt_swVersion";
            this.txt_swVersion.Size = new System.Drawing.Size(0, 21);
            this.txt_swVersion.TabIndex = 73;
            // 
            // label_passwd
            // 
            this.label_passwd.AutoSize = true;
            this.label_passwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_passwd.Location = new System.Drawing.Point(25, 363);
            this.label_passwd.Name = "label_passwd";
            this.label_passwd.Size = new System.Drawing.Size(58, 21);
            this.label_passwd.TabIndex = 72;
            this.label_passwd.Text = "密码：";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_user.Location = new System.Drawing.Point(25, 323);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(74, 21);
            this.label_user.TabIndex = 71;
            this.label_user.Text = "用户名：";
            // 
            // lab_swVersion
            // 
            this.lab_swVersion.AutoSize = true;
            this.lab_swVersion.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_swVersion.Location = new System.Drawing.Point(25, 283);
            this.lab_swVersion.Name = "lab_swVersion";
            this.lab_swVersion.Size = new System.Drawing.Size(90, 21);
            this.lab_swVersion.TabIndex = 70;
            this.lab_swVersion.Text = "软件版本：";
            // 
            // lab_gwIPMode
            // 
            this.lab_gwIPMode.AutoSize = true;
            this.lab_gwIPMode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gwIPMode.Location = new System.Drawing.Point(25, 243);
            this.lab_gwIPMode.Name = "lab_gwIPMode";
            this.lab_gwIPMode.Size = new System.Drawing.Size(105, 21);
            this.lab_gwIPMode.TabIndex = 69;
            this.lab_gwIPMode.Text = "当前IP模式：";
            // 
            // lab_authority
            // 
            this.lab_authority.AutoSize = true;
            this.lab_authority.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_authority.Location = new System.Drawing.Point(25, 203);
            this.lab_authority.Name = "lab_authority";
            this.lab_authority.Size = new System.Drawing.Size(90, 21);
            this.lab_authority.TabIndex = 68;
            this.lab_authority.Text = "控制权限：";
            // 
            // lab_gwPermit
            // 
            this.lab_gwPermit.AutoSize = true;
            this.lab_gwPermit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gwPermit.Location = new System.Drawing.Point(25, 163);
            this.lab_gwPermit.Name = "lab_gwPermit";
            this.lab_gwPermit.Size = new System.Drawing.Size(90, 21);
            this.lab_gwPermit.TabIndex = 67;
            this.lab_gwPermit.Text = "许可信息：";
            // 
            // lab_gwMac
            // 
            this.lab_gwMac.AutoSize = true;
            this.lab_gwMac.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gwMac.Location = new System.Drawing.Point(25, 123);
            this.lab_gwMac.Name = "lab_gwMac";
            this.lab_gwMac.Size = new System.Drawing.Size(96, 21);
            this.lab_gwMac.TabIndex = 66;
            this.lab_gwMac.Text = "MAC地址：";
            // 
            // lab_gwBcast
            // 
            this.lab_gwBcast.AutoSize = true;
            this.lab_gwBcast.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gwBcast.Location = new System.Drawing.Point(25, 83);
            this.lab_gwBcast.Name = "lab_gwBcast";
            this.lab_gwBcast.Size = new System.Drawing.Size(90, 21);
            this.lab_gwBcast.TabIndex = 65;
            this.lab_gwBcast.Text = "广播地址：";
            // 
            // lab_gwMask
            // 
            this.lab_gwMask.AutoSize = true;
            this.lab_gwMask.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gwMask.Location = new System.Drawing.Point(25, 43);
            this.lab_gwMask.Name = "lab_gwMask";
            this.lab_gwMask.Size = new System.Drawing.Size(90, 21);
            this.lab_gwMask.TabIndex = 64;
            this.lab_gwMask.Text = "子网掩码：";
            // 
            // lab_gwIP
            // 
            this.lab_gwIP.AutoSize = true;
            this.lab_gwIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gwIP.Location = new System.Drawing.Point(25, 3);
            this.lab_gwIP.Name = "lab_gwIP";
            this.lab_gwIP.Size = new System.Drawing.Size(61, 21);
            this.lab_gwIP.TabIndex = 63;
            this.lab_gwIP.Text = "IP地址:";
            // 
            // OpenfileDialog
            // 
            this.OpenfileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 462);
            this.Controls.Add(this.panel_set);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_passwd);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lab_passwd);
            this.Controls.Add(this.lab_user);
            this.Controls.Add(this.txt_DevIP);
            this.Controls.Add(this.lab_DevIP);
            this.Controls.Add(this.btn_broadcast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_gw_IPList);
            this.Controls.Add(this.menu_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu_main;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简易网管配置工具V1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_gw_IPList)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem 语言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dg_gw_IPList;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_gw_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_broadcast;
        private System.Windows.Forms.TextBox txt_DevIP;
        private System.Windows.Forms.Label lab_DevIP;
        private System.Windows.Forms.TextBox txt_passwd;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lab_passwd;
        private System.Windows.Forms.Label lab_user;
        private System.Windows.Forms.Button btn_login;
        public System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel sb_tips0;
        private System.Windows.Forms.ToolStripStatusLabel sb_tips1;
        private System.Windows.Forms.Timer Timer_RefreshIPList;
        private System.Windows.Forms.Timer Timer_sbTips;
        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.MaskedTextBox txt_gwPermit;
        private System.Windows.Forms.TextBox text_passwd;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.TextBox txt_gwBcast;
        private System.Windows.Forms.TextBox txt_gwMask;
        private System.Windows.Forms.TextBox txt_gwIP;
        private System.Windows.Forms.Label txt_gwMac;
        private System.Windows.Forms.Label txt_authority;
        private System.Windows.Forms.Label txt_gwIPMode;
        private System.Windows.Forms.Label txt_swVersion;
        private System.Windows.Forms.Label label_passwd;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label lab_swVersion;
        private System.Windows.Forms.Label lab_gwIPMode;
        private System.Windows.Forms.Label lab_authority;
        private System.Windows.Forms.Label lab_gwPermit;
        private System.Windows.Forms.Label lab_gwMac;
        private System.Windows.Forms.Label lab_gwBcast;
        private System.Windows.Forms.Label lab_gwMask;
        private System.Windows.Forms.Label lab_gwIP;
        private System.Windows.Forms.Button btn_reboot;
        private System.Windows.Forms.Button btn_sysupdate;
        private System.Windows.Forms.Button btn_refactory;
        private System.Windows.Forms.Button btn_swupdate;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.OpenFileDialog OpenfileDialog;
    }
}

