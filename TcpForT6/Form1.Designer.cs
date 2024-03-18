namespace TcpForT6
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.WarpPanel = new System.Windows.Forms.Panel();
            this.BTNPanel = new System.Windows.Forms.Panel();
            this.HomeTB = new System.Windows.Forms.TextBox();
            this.MotorOffTB = new System.Windows.Forms.TextBox();
            this.MotorOnTB = new System.Windows.Forms.TextBox();
            this.ResetAlmTB = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.SetMemIOWordTB = new System.Windows.Forms.TextBox();
            this.GetMemIOWordTB = new System.Windows.Forms.TextBox();
            this.SetMemIOByteTB = new System.Windows.Forms.TextBox();
            this.GetMemIOByteTB = new System.Windows.Forms.TextBox();
            this.SetMemIOTB = new System.Windows.Forms.TextBox();
            this.GetMemIOTB = new System.Windows.Forms.TextBox();
            this.SetIOWordTB = new System.Windows.Forms.TextBox();
            this.GetIOWordTB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.GetIOWordBTN = new System.Windows.Forms.Button();
            this.SetIOWordBTN = new System.Windows.Forms.Button();
            this.GetMemIOBTN = new System.Windows.Forms.Button();
            this.SetMemIOBTN = new System.Windows.Forms.Button();
            this.GetMemIOByteBTN = new System.Windows.Forms.Button();
            this.SetMemIOByteBTN = new System.Windows.Forms.Button();
            this.GetMemIOWordBTN = new System.Windows.Forms.Button();
            this.SetMemIOWordBTN = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.GetStatusBTN = new System.Windows.Forms.Button();
            this.AbortBTN = new System.Windows.Forms.Button();
            this.GetAlmBTN = new System.Windows.Forms.Button();
            this.ResetAlmBTN = new System.Windows.Forms.Button();
            this.SetIOByteTB = new System.Windows.Forms.TextBox();
            this.GetIOByteTB = new System.Windows.Forms.TextBox();
            this.SetIOTB = new System.Windows.Forms.TextBox();
            this.GetBitTB = new System.Windows.Forms.TextBox();
            this.SetCurRobotTB = new System.Windows.Forms.TextBox();
            this.StartTB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.StartBTN = new System.Windows.Forms.Button();
            this.StopBTN = new System.Windows.Forms.Button();
            this.PauseBTN = new System.Windows.Forms.Button();
            this.ContinueBTN = new System.Windows.Forms.Button();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.MotorOnBTN = new System.Windows.Forms.Button();
            this.MotorOffBTN = new System.Windows.Forms.Button();
            this.GetCurRobotBTN = new System.Windows.Forms.Button();
            this.SetCurRobotBTN = new System.Windows.Forms.Button();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.GetBitBTN = new System.Windows.Forms.Button();
            this.SetIOBTN = new System.Windows.Forms.Button();
            this.GetIOByteBTN = new System.Windows.Forms.Button();
            this.SetIOByteBTN = new System.Windows.Forms.Button();
            this.CommandPanel = new System.Windows.Forms.Panel();
            this.ExecuteTB = new System.Windows.Forms.TextBox();
            this.ReciveRTB = new System.Windows.Forms.RichTextBox();
            this.CMDTB = new System.Windows.Forms.TextBox();
            this.SendBTN = new System.Windows.Forms.Button();
            this.ExecuteBTN = new System.Windows.Forms.Button();
            this.CommandLBL = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.PasswordLBL = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.LogoutBTN = new System.Windows.Forms.Button();
            this.ConnectBTN = new System.Windows.Forms.Button();
            this.PortTB = new System.Windows.Forms.TextBox();
            this.PortLBL = new System.Windows.Forms.Label();
            this.IPTB = new System.Windows.Forms.TextBox();
            this.IPLBL = new System.Windows.Forms.Label();
            this.WarpPanel.SuspendLayout();
            this.BTNPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.CommandPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 466);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // WarpPanel
            // 
            this.WarpPanel.Controls.Add(this.BTNPanel);
            this.WarpPanel.Controls.Add(this.CommandPanel);
            this.WarpPanel.Controls.Add(this.LoginPanel);
            this.WarpPanel.Controls.Add(this.ConnectBTN);
            this.WarpPanel.Controls.Add(this.PortTB);
            this.WarpPanel.Controls.Add(this.PortLBL);
            this.WarpPanel.Controls.Add(this.IPTB);
            this.WarpPanel.Controls.Add(this.IPLBL);
            this.WarpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarpPanel.Location = new System.Drawing.Point(0, 0);
            this.WarpPanel.Name = "WarpPanel";
            this.WarpPanel.Size = new System.Drawing.Size(812, 466);
            this.WarpPanel.TabIndex = 2;
            // 
            // BTNPanel
            // 
            this.BTNPanel.Controls.Add(this.HomeTB);
            this.BTNPanel.Controls.Add(this.MotorOffTB);
            this.BTNPanel.Controls.Add(this.MotorOnTB);
            this.BTNPanel.Controls.Add(this.ResetAlmTB);
            this.BTNPanel.Controls.Add(this.textBox18);
            this.BTNPanel.Controls.Add(this.textBox19);
            this.BTNPanel.Controls.Add(this.SetMemIOWordTB);
            this.BTNPanel.Controls.Add(this.GetMemIOWordTB);
            this.BTNPanel.Controls.Add(this.SetMemIOByteTB);
            this.BTNPanel.Controls.Add(this.GetMemIOByteTB);
            this.BTNPanel.Controls.Add(this.SetMemIOTB);
            this.BTNPanel.Controls.Add(this.GetMemIOTB);
            this.BTNPanel.Controls.Add(this.SetIOWordTB);
            this.BTNPanel.Controls.Add(this.GetIOWordTB);
            this.BTNPanel.Controls.Add(this.flowLayoutPanel2);
            this.BTNPanel.Controls.Add(this.SetIOByteTB);
            this.BTNPanel.Controls.Add(this.GetIOByteTB);
            this.BTNPanel.Controls.Add(this.SetIOTB);
            this.BTNPanel.Controls.Add(this.GetBitTB);
            this.BTNPanel.Controls.Add(this.SetCurRobotTB);
            this.BTNPanel.Controls.Add(this.StartTB);
            this.BTNPanel.Controls.Add(this.flowLayoutPanel1);
            this.BTNPanel.Enabled = false;
            this.BTNPanel.Location = new System.Drawing.Point(375, 9);
            this.BTNPanel.Name = "BTNPanel";
            this.BTNPanel.Size = new System.Drawing.Size(436, 427);
            this.BTNPanel.TabIndex = 43;
            // 
            // HomeTB
            // 
            this.HomeTB.Location = new System.Drawing.Point(101, 269);
            this.HomeTB.Name = "HomeTB";
            this.HomeTB.Size = new System.Drawing.Size(52, 21);
            this.HomeTB.TabIndex = 40;
            // 
            // MotorOffTB
            // 
            this.MotorOffTB.Location = new System.Drawing.Point(101, 182);
            this.MotorOffTB.Name = "MotorOffTB";
            this.MotorOffTB.Size = new System.Drawing.Size(52, 21);
            this.MotorOffTB.TabIndex = 39;
            // 
            // MotorOnTB
            // 
            this.MotorOnTB.Location = new System.Drawing.Point(101, 153);
            this.MotorOnTB.Name = "MotorOnTB";
            this.MotorOnTB.Size = new System.Drawing.Size(52, 21);
            this.MotorOnTB.TabIndex = 38;
            // 
            // ResetAlmTB
            // 
            this.ResetAlmTB.Location = new System.Drawing.Point(297, 385);
            this.ResetAlmTB.Name = "ResetAlmTB";
            this.ResetAlmTB.Size = new System.Drawing.Size(133, 21);
            this.ResetAlmTB.TabIndex = 36;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(297, 267);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(133, 21);
            this.textBox18.TabIndex = 34;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(297, 239);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(133, 21);
            this.textBox19.TabIndex = 33;
            // 
            // SetMemIOWordTB
            // 
            this.SetMemIOWordTB.Location = new System.Drawing.Point(297, 211);
            this.SetMemIOWordTB.Name = "SetMemIOWordTB";
            this.SetMemIOWordTB.Size = new System.Drawing.Size(133, 21);
            this.SetMemIOWordTB.TabIndex = 32;
            // 
            // GetMemIOWordTB
            // 
            this.GetMemIOWordTB.Location = new System.Drawing.Point(297, 182);
            this.GetMemIOWordTB.Name = "GetMemIOWordTB";
            this.GetMemIOWordTB.Size = new System.Drawing.Size(133, 21);
            this.GetMemIOWordTB.TabIndex = 31;
            // 
            // SetMemIOByteTB
            // 
            this.SetMemIOByteTB.Location = new System.Drawing.Point(297, 153);
            this.SetMemIOByteTB.Name = "SetMemIOByteTB";
            this.SetMemIOByteTB.Size = new System.Drawing.Size(133, 21);
            this.SetMemIOByteTB.TabIndex = 30;
            // 
            // GetMemIOByteTB
            // 
            this.GetMemIOByteTB.Location = new System.Drawing.Point(297, 126);
            this.GetMemIOByteTB.Name = "GetMemIOByteTB";
            this.GetMemIOByteTB.Size = new System.Drawing.Size(133, 21);
            this.GetMemIOByteTB.TabIndex = 29;
            // 
            // SetMemIOTB
            // 
            this.SetMemIOTB.Location = new System.Drawing.Point(297, 95);
            this.SetMemIOTB.Name = "SetMemIOTB";
            this.SetMemIOTB.Size = new System.Drawing.Size(133, 21);
            this.SetMemIOTB.TabIndex = 28;
            // 
            // GetMemIOTB
            // 
            this.GetMemIOTB.Location = new System.Drawing.Point(297, 64);
            this.GetMemIOTB.Name = "GetMemIOTB";
            this.GetMemIOTB.Size = new System.Drawing.Size(133, 21);
            this.GetMemIOTB.TabIndex = 27;
            // 
            // SetIOWordTB
            // 
            this.SetIOWordTB.Location = new System.Drawing.Point(297, 37);
            this.SetIOWordTB.Name = "SetIOWordTB";
            this.SetIOWordTB.Size = new System.Drawing.Size(133, 21);
            this.SetIOWordTB.TabIndex = 26;
            // 
            // GetIOWordTB
            // 
            this.GetIOWordTB.Location = new System.Drawing.Point(297, 6);
            this.GetIOWordTB.Name = "GetIOWordTB";
            this.GetIOWordTB.Size = new System.Drawing.Size(133, 21);
            this.GetIOWordTB.TabIndex = 25;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.GetIOWordBTN);
            this.flowLayoutPanel2.Controls.Add(this.SetIOWordBTN);
            this.flowLayoutPanel2.Controls.Add(this.GetMemIOBTN);
            this.flowLayoutPanel2.Controls.Add(this.SetMemIOBTN);
            this.flowLayoutPanel2.Controls.Add(this.GetMemIOByteBTN);
            this.flowLayoutPanel2.Controls.Add(this.SetMemIOByteBTN);
            this.flowLayoutPanel2.Controls.Add(this.GetMemIOWordBTN);
            this.flowLayoutPanel2.Controls.Add(this.SetMemIOWordBTN);
            this.flowLayoutPanel2.Controls.Add(this.button23);
            this.flowLayoutPanel2.Controls.Add(this.button24);
            this.flowLayoutPanel2.Controls.Add(this.GetStatusBTN);
            this.flowLayoutPanel2.Controls.Add(this.AbortBTN);
            this.flowLayoutPanel2.Controls.Add(this.GetAlmBTN);
            this.flowLayoutPanel2.Controls.Add(this.ResetAlmBTN);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(160, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(131, 411);
            this.flowLayoutPanel2.TabIndex = 22;
            // 
            // GetIOWordBTN
            // 
            this.GetIOWordBTN.Location = new System.Drawing.Point(3, 3);
            this.GetIOWordBTN.Name = "GetIOWordBTN";
            this.GetIOWordBTN.Size = new System.Drawing.Size(117, 23);
            this.GetIOWordBTN.TabIndex = 13;
            this.GetIOWordBTN.Text = "워드 상태";
            this.GetIOWordBTN.UseVisualStyleBackColor = true;
            this.GetIOWordBTN.Click += new System.EventHandler(this.GetIOWordBTN_Click);
            // 
            // SetIOWordBTN
            // 
            this.SetIOWordBTN.Location = new System.Drawing.Point(3, 32);
            this.SetIOWordBTN.Name = "SetIOWordBTN";
            this.SetIOWordBTN.Size = new System.Drawing.Size(117, 23);
            this.SetIOWordBTN.TabIndex = 14;
            this.SetIOWordBTN.Text = "워드 설정";
            this.SetIOWordBTN.UseVisualStyleBackColor = true;
            this.SetIOWordBTN.Click += new System.EventHandler(this.SetIOWordBTN_Click);
            // 
            // GetMemIOBTN
            // 
            this.GetMemIOBTN.Location = new System.Drawing.Point(3, 61);
            this.GetMemIOBTN.Name = "GetMemIOBTN";
            this.GetMemIOBTN.Size = new System.Drawing.Size(117, 23);
            this.GetMemIOBTN.TabIndex = 15;
            this.GetMemIOBTN.Text = "메모리 비트 상태";
            this.GetMemIOBTN.UseVisualStyleBackColor = true;
            this.GetMemIOBTN.Click += new System.EventHandler(this.GetMemIOBTN_Click);
            // 
            // SetMemIOBTN
            // 
            this.SetMemIOBTN.Location = new System.Drawing.Point(3, 90);
            this.SetMemIOBTN.Name = "SetMemIOBTN";
            this.SetMemIOBTN.Size = new System.Drawing.Size(117, 23);
            this.SetMemIOBTN.TabIndex = 16;
            this.SetMemIOBTN.Text = "메모리 비트 설정";
            this.SetMemIOBTN.UseVisualStyleBackColor = true;
            this.SetMemIOBTN.Click += new System.EventHandler(this.SetMemIOBTN_Click);
            // 
            // GetMemIOByteBTN
            // 
            this.GetMemIOByteBTN.Location = new System.Drawing.Point(3, 119);
            this.GetMemIOByteBTN.Name = "GetMemIOByteBTN";
            this.GetMemIOByteBTN.Size = new System.Drawing.Size(117, 23);
            this.GetMemIOByteBTN.TabIndex = 17;
            this.GetMemIOByteBTN.Text = "메모리 바이트 상태";
            this.GetMemIOByteBTN.UseVisualStyleBackColor = true;
            this.GetMemIOByteBTN.Click += new System.EventHandler(this.GetMemIOByteBTN_Click);
            // 
            // SetMemIOByteBTN
            // 
            this.SetMemIOByteBTN.Location = new System.Drawing.Point(3, 148);
            this.SetMemIOByteBTN.Name = "SetMemIOByteBTN";
            this.SetMemIOByteBTN.Size = new System.Drawing.Size(117, 23);
            this.SetMemIOByteBTN.TabIndex = 18;
            this.SetMemIOByteBTN.Text = "메모리 바이트 설정";
            this.SetMemIOByteBTN.UseVisualStyleBackColor = true;
            this.SetMemIOByteBTN.Click += new System.EventHandler(this.SetMemIOByteBTN_Click);
            // 
            // GetMemIOWordBTN
            // 
            this.GetMemIOWordBTN.Location = new System.Drawing.Point(3, 177);
            this.GetMemIOWordBTN.Name = "GetMemIOWordBTN";
            this.GetMemIOWordBTN.Size = new System.Drawing.Size(117, 23);
            this.GetMemIOWordBTN.TabIndex = 19;
            this.GetMemIOWordBTN.Text = "메모리 워드 상태";
            this.GetMemIOWordBTN.UseVisualStyleBackColor = true;
            this.GetMemIOWordBTN.Click += new System.EventHandler(this.GetMemIOWordBTN_Click);
            // 
            // SetMemIOWordBTN
            // 
            this.SetMemIOWordBTN.Location = new System.Drawing.Point(3, 206);
            this.SetMemIOWordBTN.Name = "SetMemIOWordBTN";
            this.SetMemIOWordBTN.Size = new System.Drawing.Size(117, 23);
            this.SetMemIOWordBTN.TabIndex = 20;
            this.SetMemIOWordBTN.Text = "메모리 워드 설정";
            this.SetMemIOWordBTN.UseVisualStyleBackColor = true;
            this.SetMemIOWordBTN.Click += new System.EventHandler(this.SetMemIOWordBTN_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(3, 235);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(117, 23);
            this.button23.TabIndex = 21;
            this.button23.Text = "변수 상태";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(3, 264);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(117, 23);
            this.button24.TabIndex = 22;
            this.button24.Text = "변수 설정";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // GetStatusBTN
            // 
            this.GetStatusBTN.Location = new System.Drawing.Point(3, 293);
            this.GetStatusBTN.Name = "GetStatusBTN";
            this.GetStatusBTN.Size = new System.Drawing.Size(117, 23);
            this.GetStatusBTN.TabIndex = 23;
            this.GetStatusBTN.Text = "로봇 상태";
            this.GetStatusBTN.UseVisualStyleBackColor = true;
            this.GetStatusBTN.Click += new System.EventHandler(this.GetStatusBTN_Click);
            // 
            // AbortBTN
            // 
            this.AbortBTN.Location = new System.Drawing.Point(3, 322);
            this.AbortBTN.Name = "AbortBTN";
            this.AbortBTN.Size = new System.Drawing.Size(117, 23);
            this.AbortBTN.TabIndex = 25;
            this.AbortBTN.Text = "명령 중지";
            this.AbortBTN.UseVisualStyleBackColor = true;
            this.AbortBTN.Click += new System.EventHandler(this.AbortBTN_Click);
            // 
            // GetAlmBTN
            // 
            this.GetAlmBTN.Location = new System.Drawing.Point(3, 351);
            this.GetAlmBTN.Name = "GetAlmBTN";
            this.GetAlmBTN.Size = new System.Drawing.Size(117, 23);
            this.GetAlmBTN.TabIndex = 26;
            this.GetAlmBTN.Text = "알람 상태";
            this.GetAlmBTN.UseVisualStyleBackColor = true;
            this.GetAlmBTN.Click += new System.EventHandler(this.GetAlmBTN_Click);
            // 
            // ResetAlmBTN
            // 
            this.ResetAlmBTN.Location = new System.Drawing.Point(3, 380);
            this.ResetAlmBTN.Name = "ResetAlmBTN";
            this.ResetAlmBTN.Size = new System.Drawing.Size(117, 23);
            this.ResetAlmBTN.TabIndex = 27;
            this.ResetAlmBTN.Text = "알람 설정";
            this.ResetAlmBTN.UseVisualStyleBackColor = true;
            this.ResetAlmBTN.Click += new System.EventHandler(this.ResetAlmBTN_Click);
            // 
            // SetIOByteTB
            // 
            this.SetIOByteTB.Location = new System.Drawing.Point(101, 385);
            this.SetIOByteTB.Name = "SetIOByteTB";
            this.SetIOByteTB.Size = new System.Drawing.Size(52, 21);
            this.SetIOByteTB.TabIndex = 21;
            // 
            // GetIOByteTB
            // 
            this.GetIOByteTB.Location = new System.Drawing.Point(101, 356);
            this.GetIOByteTB.Name = "GetIOByteTB";
            this.GetIOByteTB.Size = new System.Drawing.Size(52, 21);
            this.GetIOByteTB.TabIndex = 20;
            // 
            // SetIOTB
            // 
            this.SetIOTB.Location = new System.Drawing.Point(101, 327);
            this.SetIOTB.Name = "SetIOTB";
            this.SetIOTB.Size = new System.Drawing.Size(52, 21);
            this.SetIOTB.TabIndex = 19;
            // 
            // GetBitTB
            // 
            this.GetBitTB.Location = new System.Drawing.Point(101, 298);
            this.GetBitTB.Name = "GetBitTB";
            this.GetBitTB.Size = new System.Drawing.Size(52, 21);
            this.GetBitTB.TabIndex = 18;
            // 
            // SetCurRobotTB
            // 
            this.SetCurRobotTB.Location = new System.Drawing.Point(101, 240);
            this.SetCurRobotTB.Name = "SetCurRobotTB";
            this.SetCurRobotTB.Size = new System.Drawing.Size(52, 21);
            this.SetCurRobotTB.TabIndex = 17;
            // 
            // StartTB
            // 
            this.StartTB.Location = new System.Drawing.Point(102, 6);
            this.StartTB.Name = "StartTB";
            this.StartTB.Size = new System.Drawing.Size(52, 21);
            this.StartTB.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.StartBTN);
            this.flowLayoutPanel1.Controls.Add(this.StopBTN);
            this.flowLayoutPanel1.Controls.Add(this.PauseBTN);
            this.flowLayoutPanel1.Controls.Add(this.ContinueBTN);
            this.flowLayoutPanel1.Controls.Add(this.ResetBTN);
            this.flowLayoutPanel1.Controls.Add(this.MotorOnBTN);
            this.flowLayoutPanel1.Controls.Add(this.MotorOffBTN);
            this.flowLayoutPanel1.Controls.Add(this.GetCurRobotBTN);
            this.flowLayoutPanel1.Controls.Add(this.SetCurRobotBTN);
            this.flowLayoutPanel1.Controls.Add(this.HomeBTN);
            this.flowLayoutPanel1.Controls.Add(this.GetBitBTN);
            this.flowLayoutPanel1.Controls.Add(this.SetIOBTN);
            this.flowLayoutPanel1.Controls.Add(this.GetIOByteBTN);
            this.flowLayoutPanel1.Controls.Add(this.SetIOByteBTN);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(86, 411);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // StartBTN
            // 
            this.StartBTN.Location = new System.Drawing.Point(3, 3);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(82, 23);
            this.StartBTN.TabIndex = 13;
            this.StartBTN.Text = "시작";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.Location = new System.Drawing.Point(3, 32);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(82, 23);
            this.StopBTN.TabIndex = 14;
            this.StopBTN.Text = "멈춤";
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // PauseBTN
            // 
            this.PauseBTN.Location = new System.Drawing.Point(3, 61);
            this.PauseBTN.Name = "PauseBTN";
            this.PauseBTN.Size = new System.Drawing.Size(82, 23);
            this.PauseBTN.TabIndex = 15;
            this.PauseBTN.Text = "일시정지";
            this.PauseBTN.UseVisualStyleBackColor = true;
            this.PauseBTN.Click += new System.EventHandler(this.PauseBTN_Click);
            // 
            // ContinueBTN
            // 
            this.ContinueBTN.Location = new System.Drawing.Point(3, 90);
            this.ContinueBTN.Name = "ContinueBTN";
            this.ContinueBTN.Size = new System.Drawing.Size(82, 23);
            this.ContinueBTN.TabIndex = 16;
            this.ContinueBTN.Text = "재개";
            this.ContinueBTN.UseVisualStyleBackColor = true;
            this.ContinueBTN.Click += new System.EventHandler(this.ContinueBTN_Click);
            // 
            // ResetBTN
            // 
            this.ResetBTN.Location = new System.Drawing.Point(3, 119);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(82, 23);
            this.ResetBTN.TabIndex = 17;
            this.ResetBTN.Text = "리셋";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // MotorOnBTN
            // 
            this.MotorOnBTN.Location = new System.Drawing.Point(3, 148);
            this.MotorOnBTN.Name = "MotorOnBTN";
            this.MotorOnBTN.Size = new System.Drawing.Size(82, 23);
            this.MotorOnBTN.TabIndex = 18;
            this.MotorOnBTN.Text = "모터켜기";
            this.MotorOnBTN.UseVisualStyleBackColor = true;
            this.MotorOnBTN.Click += new System.EventHandler(this.MotorOnBTN_Click);
            // 
            // MotorOffBTN
            // 
            this.MotorOffBTN.Location = new System.Drawing.Point(3, 177);
            this.MotorOffBTN.Name = "MotorOffBTN";
            this.MotorOffBTN.Size = new System.Drawing.Size(82, 23);
            this.MotorOffBTN.TabIndex = 19;
            this.MotorOffBTN.Text = "모터끄기";
            this.MotorOffBTN.UseVisualStyleBackColor = true;
            this.MotorOffBTN.Click += new System.EventHandler(this.MotorOffBTN_Click);
            // 
            // GetCurRobotBTN
            // 
            this.GetCurRobotBTN.Location = new System.Drawing.Point(3, 206);
            this.GetCurRobotBTN.Name = "GetCurRobotBTN";
            this.GetCurRobotBTN.Size = new System.Drawing.Size(82, 23);
            this.GetCurRobotBTN.TabIndex = 20;
            this.GetCurRobotBTN.Text = "선택된 로봇";
            this.GetCurRobotBTN.UseVisualStyleBackColor = true;
            this.GetCurRobotBTN.Click += new System.EventHandler(this.GetCurRobotBTN_Click);
            // 
            // SetCurRobotBTN
            // 
            this.SetCurRobotBTN.Location = new System.Drawing.Point(3, 235);
            this.SetCurRobotBTN.Name = "SetCurRobotBTN";
            this.SetCurRobotBTN.Size = new System.Drawing.Size(82, 23);
            this.SetCurRobotBTN.TabIndex = 21;
            this.SetCurRobotBTN.Text = "로봇 선택";
            this.SetCurRobotBTN.UseVisualStyleBackColor = true;
            this.SetCurRobotBTN.Click += new System.EventHandler(this.SetCurRobotBTN_Click);
            // 
            // HomeBTN
            // 
            this.HomeBTN.Location = new System.Drawing.Point(3, 264);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(82, 23);
            this.HomeBTN.TabIndex = 22;
            this.HomeBTN.Text = "홈";
            this.HomeBTN.UseVisualStyleBackColor = true;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // GetBitBTN
            // 
            this.GetBitBTN.Location = new System.Drawing.Point(3, 293);
            this.GetBitBTN.Name = "GetBitBTN";
            this.GetBitBTN.Size = new System.Drawing.Size(82, 23);
            this.GetBitBTN.TabIndex = 23;
            this.GetBitBTN.Text = "비트 상태";
            this.GetBitBTN.UseVisualStyleBackColor = true;
            this.GetBitBTN.Click += new System.EventHandler(this.GetBitBTN_Click);
            // 
            // SetIOBTN
            // 
            this.SetIOBTN.Location = new System.Drawing.Point(3, 322);
            this.SetIOBTN.Name = "SetIOBTN";
            this.SetIOBTN.Size = new System.Drawing.Size(82, 23);
            this.SetIOBTN.TabIndex = 24;
            this.SetIOBTN.Text = "비트 설정";
            this.SetIOBTN.UseVisualStyleBackColor = true;
            this.SetIOBTN.Click += new System.EventHandler(this.SetIOBTN_Click);
            // 
            // GetIOByteBTN
            // 
            this.GetIOByteBTN.Location = new System.Drawing.Point(3, 351);
            this.GetIOByteBTN.Name = "GetIOByteBTN";
            this.GetIOByteBTN.Size = new System.Drawing.Size(82, 23);
            this.GetIOByteBTN.TabIndex = 25;
            this.GetIOByteBTN.Text = "바이트 상태";
            this.GetIOByteBTN.UseVisualStyleBackColor = true;
            this.GetIOByteBTN.Click += new System.EventHandler(this.GetIOByteBTN_Click);
            // 
            // SetIOByteBTN
            // 
            this.SetIOByteBTN.Location = new System.Drawing.Point(3, 380);
            this.SetIOByteBTN.Name = "SetIOByteBTN";
            this.SetIOByteBTN.Size = new System.Drawing.Size(82, 23);
            this.SetIOByteBTN.TabIndex = 26;
            this.SetIOByteBTN.Text = "바이트 설정";
            this.SetIOByteBTN.UseVisualStyleBackColor = true;
            this.SetIOByteBTN.Click += new System.EventHandler(this.SetIOByteBTN_Click);
            // 
            // CommandPanel
            // 
            this.CommandPanel.Controls.Add(this.ExecuteTB);
            this.CommandPanel.Controls.Add(this.ReciveRTB);
            this.CommandPanel.Controls.Add(this.CMDTB);
            this.CommandPanel.Controls.Add(this.SendBTN);
            this.CommandPanel.Controls.Add(this.ExecuteBTN);
            this.CommandPanel.Controls.Add(this.CommandLBL);
            this.CommandPanel.Enabled = false;
            this.CommandPanel.Location = new System.Drawing.Point(3, 225);
            this.CommandPanel.Name = "CommandPanel";
            this.CommandPanel.Size = new System.Drawing.Size(373, 238);
            this.CommandPanel.TabIndex = 42;
            // 
            // ExecuteTB
            // 
            this.ExecuteTB.Location = new System.Drawing.Point(20, 22);
            this.ExecuteTB.Name = "ExecuteTB";
            this.ExecuteTB.Size = new System.Drawing.Size(233, 21);
            this.ExecuteTB.TabIndex = 37;
            // 
            // ReciveRTB
            // 
            this.ReciveRTB.Location = new System.Drawing.Point(14, 81);
            this.ReciveRTB.Name = "ReciveRTB";
            this.ReciveRTB.ReadOnly = true;
            this.ReciveRTB.Size = new System.Drawing.Size(352, 149);
            this.ReciveRTB.TabIndex = 5;
            this.ReciveRTB.Text = "";
            // 
            // CMDTB
            // 
            this.CMDTB.Location = new System.Drawing.Point(67, 51);
            this.CMDTB.Name = "CMDTB";
            this.CMDTB.Size = new System.Drawing.Size(218, 21);
            this.CMDTB.TabIndex = 9;
            // 
            // SendBTN
            // 
            this.SendBTN.Location = new System.Drawing.Point(291, 49);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(75, 23);
            this.SendBTN.TabIndex = 10;
            this.SendBTN.Text = "전송";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // ExecuteBTN
            // 
            this.ExecuteBTN.Location = new System.Drawing.Point(259, 20);
            this.ExecuteBTN.Name = "ExecuteBTN";
            this.ExecuteBTN.Size = new System.Drawing.Size(107, 23);
            this.ExecuteBTN.TabIndex = 24;
            this.ExecuteBTN.Text = "스펠 명령어 전송";
            this.ExecuteBTN.UseVisualStyleBackColor = true;
            this.ExecuteBTN.Click += new System.EventHandler(this.ExecuteBTN_Click);
            // 
            // CommandLBL
            // 
            this.CommandLBL.AutoSize = true;
            this.CommandLBL.Location = new System.Drawing.Point(20, 54);
            this.CommandLBL.Name = "CommandLBL";
            this.CommandLBL.Size = new System.Drawing.Size(41, 12);
            this.CommandLBL.TabIndex = 11;
            this.CommandLBL.Text = "명령어";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.PasswordLBL);
            this.LoginPanel.Controls.Add(this.PasswordTB);
            this.LoginPanel.Controls.Add(this.LoginBTN);
            this.LoginPanel.Controls.Add(this.LogoutBTN);
            this.LoginPanel.Enabled = false;
            this.LoginPanel.Location = new System.Drawing.Point(160, 15);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(188, 65);
            this.LoginPanel.TabIndex = 41;
            // 
            // PasswordLBL
            // 
            this.PasswordLBL.AutoSize = true;
            this.PasswordLBL.Location = new System.Drawing.Point(9, 9);
            this.PasswordLBL.Name = "PasswordLBL";
            this.PasswordLBL.Size = new System.Drawing.Size(62, 12);
            this.PasswordLBL.TabIndex = 6;
            this.PasswordLBL.Text = "Password";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(77, 3);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(100, 21);
            this.PasswordTB.TabIndex = 7;
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(21, 33);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(75, 23);
            this.LoginBTN.TabIndex = 8;
            this.LoginBTN.Tag = "$\"$Login,{PasswordTB.Text}\\\\n\"";
            this.LoginBTN.Text = "로그인";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // LogoutBTN
            // 
            this.LogoutBTN.Location = new System.Drawing.Point(102, 33);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(75, 23);
            this.LogoutBTN.TabIndex = 12;
            this.LogoutBTN.Text = "로그아웃";
            this.LogoutBTN.UseVisualStyleBackColor = true;
            this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.Location = new System.Drawing.Point(68, 66);
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.Size = new System.Drawing.Size(75, 23);
            this.ConnectBTN.TabIndex = 4;
            this.ConnectBTN.Text = "연결";
            this.ConnectBTN.UseVisualStyleBackColor = true;
            this.ConnectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // PortTB
            // 
            this.PortTB.Location = new System.Drawing.Point(43, 39);
            this.PortTB.Name = "PortTB";
            this.PortTB.Size = new System.Drawing.Size(100, 21);
            this.PortTB.TabIndex = 3;
            // 
            // PortLBL
            // 
            this.PortLBL.AutoSize = true;
            this.PortLBL.Location = new System.Drawing.Point(10, 42);
            this.PortLBL.Name = "PortLBL";
            this.PortLBL.Size = new System.Drawing.Size(27, 12);
            this.PortLBL.TabIndex = 2;
            this.PortLBL.Text = "Port";
            // 
            // IPTB
            // 
            this.IPTB.Location = new System.Drawing.Point(43, 12);
            this.IPTB.Name = "IPTB";
            this.IPTB.Size = new System.Drawing.Size(100, 21);
            this.IPTB.TabIndex = 1;
            // 
            // IPLBL
            // 
            this.IPLBL.AutoSize = true;
            this.IPLBL.Location = new System.Drawing.Point(21, 15);
            this.IPLBL.Name = "IPLBL";
            this.IPLBL.Size = new System.Drawing.Size(16, 12);
            this.IPLBL.TabIndex = 0;
            this.IPLBL.Text = "IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 466);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.WarpPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WarpPanel.ResumeLayout(false);
            this.WarpPanel.PerformLayout();
            this.BTNPanel.ResumeLayout(false);
            this.BTNPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.CommandPanel.ResumeLayout(false);
            this.CommandPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel WarpPanel;
        private System.Windows.Forms.Button ConnectBTN;
        private System.Windows.Forms.TextBox PortTB;
        private System.Windows.Forms.Label PortLBL;
        private System.Windows.Forms.TextBox IPTB;
        private System.Windows.Forms.Label IPLBL;
        private System.Windows.Forms.RichTextBox ReciveRTB;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label PasswordLBL;
        private System.Windows.Forms.Label CommandLBL;
        private System.Windows.Forms.Button SendBTN;
        private System.Windows.Forms.TextBox CMDTB;
        private System.Windows.Forms.Button LogoutBTN;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.Button PauseBTN;
        private System.Windows.Forms.Button ContinueBTN;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.Button MotorOnBTN;
        private System.Windows.Forms.Button MotorOffBTN;
        private System.Windows.Forms.Button GetCurRobotBTN;
        private System.Windows.Forms.Button SetCurRobotBTN;
        private System.Windows.Forms.Button HomeBTN;
        private System.Windows.Forms.Button GetBitBTN;
        private System.Windows.Forms.Button SetIOBTN;
        private System.Windows.Forms.Button GetIOByteBTN;
        private System.Windows.Forms.Button SetIOByteBTN;
        private System.Windows.Forms.TextBox SetIOTB;
        private System.Windows.Forms.TextBox GetBitTB;
        private System.Windows.Forms.TextBox SetCurRobotTB;
        private System.Windows.Forms.TextBox StartTB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button GetIOWordBTN;
        private System.Windows.Forms.Button SetIOWordBTN;
        private System.Windows.Forms.Button GetMemIOBTN;
        private System.Windows.Forms.Button SetMemIOBTN;
        private System.Windows.Forms.Button GetMemIOByteBTN;
        private System.Windows.Forms.Button SetMemIOByteBTN;
        private System.Windows.Forms.Button GetMemIOWordBTN;
        private System.Windows.Forms.Button SetMemIOWordBTN;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button GetStatusBTN;
        private System.Windows.Forms.Button AbortBTN;
        private System.Windows.Forms.Button GetAlmBTN;
        private System.Windows.Forms.Button ResetAlmBTN;
        private System.Windows.Forms.TextBox SetIOByteTB;
        private System.Windows.Forms.TextBox GetIOByteTB;
        private System.Windows.Forms.Button ExecuteBTN;
        private System.Windows.Forms.TextBox ExecuteTB;
        private System.Windows.Forms.TextBox ResetAlmTB;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox SetMemIOWordTB;
        private System.Windows.Forms.TextBox GetMemIOWordTB;
        private System.Windows.Forms.TextBox SetMemIOByteTB;
        private System.Windows.Forms.TextBox GetMemIOByteTB;
        private System.Windows.Forms.TextBox SetMemIOTB;
        private System.Windows.Forms.TextBox GetMemIOTB;
        private System.Windows.Forms.TextBox SetIOWordTB;
        private System.Windows.Forms.TextBox GetIOWordTB;
        private System.Windows.Forms.TextBox MotorOffTB;
        private System.Windows.Forms.TextBox MotorOnTB;
        private System.Windows.Forms.TextBox HomeTB;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel CommandPanel;
        private System.Windows.Forms.Panel BTNPanel;
    }
}

