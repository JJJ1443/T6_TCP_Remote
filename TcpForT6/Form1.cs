using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpForT6
{
    public partial class Form1 : Form
    {
        Socket gClient;
        string gCMD;
        public Form1()
        {
            InitializeComponent();
            DisableControl();
        }

        private void ConnectBTN_Click(object sender, EventArgs e)
        {
            string IP = IPTB.Text;
            int Port = int.Parse(PortTB.Text);
            gClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), Port);
            gClient.Connect(ep);
            Task task = Receive_Data();
            if (gClient.Connected)
            {
                MessageBox.Show("연결 완료");
                EnabledControl();
            }
        }
        private void DisableControl()
        {
            LoginPanel.Enabled = false;
            CommandPanel.Enabled = false;
            BTNPanel.Enabled = false;
        }
        private void EnabledControl()
        {
            LoginPanel.Enabled = true;
            CommandPanel.Enabled = true;
            BTNPanel.Enabled = true;
        }
        private void LoginBTN_Click(object sender, EventArgs e)// 로그인 커맨드
        {
            gCMD = $"$Login,{PasswordTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private async Task Receive_Data()
        {
            while (true)
            {
                if (await Task.Run(() => gClient.Poll(0, SelectMode.SelectRead)))
                {
                    byte[] receiverBuff = new byte[8192];
                    byte[] receiverNumBuff = new byte[50];

                    int nCount = await Task.Factory.FromAsync<int>(
                           gClient.BeginReceive(receiverBuff, 0, receiverBuff.Length, SocketFlags.None, null, gClient),
                           gClient.EndReceive);
                    string data = Encoding.Default.GetString(receiverBuff, 0, nCount);
                    ReciveRTB.AppendText(data);
                    ReciveRTB.ScrollToCaret();
                }
                await Task.Delay(100);
            }
        }

        private void SendBTN_Click(object sender, EventArgs e) //커맨드 전송
        {
            gCMD = CMDTB.Text;
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void LogoutBTN_Click(object sender, EventArgs e) //로그아웃 커맨드
        {
            gCMD = @"$LogOut\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void ExecuteBTN_Click(object sender, EventArgs e) //스펠 언어 실행 커맨드
        {
            gCMD = $"$Execute,{ExecuteTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void StartBTN_Click(object sender, EventArgs e) //함수 시작 커맨드
        {
            gCMD = $"$Start,{StartTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void StopBTN_Click(object sender, EventArgs e) //멈춤 커맨드
        {
            gCMD = $"$Stop\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void PauseBTN_Click(object sender, EventArgs e) //일시정지 커맨드
        {
            gCMD = $"$Pause\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void ContinueBTN_Click(object sender, EventArgs e) //재개 커맨드
        {
            gCMD = $"$Continue\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void ResetBTN_Click(object sender, EventArgs e) //리셋 커맨드
        {
            gCMD = $"$Reset\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void MotorOnBTN_Click(object sender, EventArgs e) //모터 켜기 커맨드
        {
            gCMD = $"$SetMotorsOn,{MotorOnTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void MotorOffBTN_Click(object sender, EventArgs e) //모터 끄기 커맨드
        {
            gCMD = $"$SetMotorsOff,{MotorOffTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void GetCurRobotBTN_Click(object sender, EventArgs e) //선택된 로봇 번호 커맨드
        {
            gCMD = $"$GetCurRobot\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void SetCurRobotBTN_Click(object sender, EventArgs e) //로봇 선택 커맨드
        {
            gCMD = $"$SetCurRobot,{SetCurRobotTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void HomeBTN_Click(object sender, EventArgs e) //홈 커맨드
        {
            gCMD = $"$Home,{HomeTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void GetBitBTN_Click(object sender, EventArgs e) //비트 값 가져오는 커맨드
        {
            gCMD = $"$GetIO,{GetBitTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void SetIOBTN_Click(object sender, EventArgs e) //비트 값 설정하는 커맨드
        {
            gCMD = $"$SetIO,{SetIOTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void GetIOByteBTN_Click(object sender, EventArgs e) //바이트 값 가져오는 커맨드
        {
            gCMD = $"$GetIOByte,{GetIOByteTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void SetIOByteBTN_Click(object sender, EventArgs e) //바이트 값 설정하는 커맨드
        {
            gCMD = $"$SetIOByte,{SetIOByteTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void GetIOWordBTN_Click(object sender, EventArgs e) //워드 값 가져오는 커맨드
        {
            gCMD = $"$GetIOWord,{GetIOWordTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void SetIOWordBTN_Click(object sender, EventArgs e) //워드 값 설정하는 커맨드
        {
            gCMD = $"$SetIOWord,{SetIOWordTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void GetMemIOBTN_Click(object sender, EventArgs e) //메모리 비트 값 가져오는 커맨드
        {
            gCMD = $"$GetMemIO,{GetMemIOTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void SetMemIOBTN_Click(object sender, EventArgs e) //메모리 비트 값 설정하는 커맨드
        {
            gCMD = $"$SetMemIO,{SetMemIOTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void GetMemIOByteBTN_Click(object sender, EventArgs e) //메모리 바이트 값 가져오는 커맨드
        {
            gCMD = $"$GetMemIOByte,{GetMemIOByteTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void SetMemIOByteBTN_Click(object sender, EventArgs e) //메모리 바이트 값 설정하는 커맨드
        {
            gCMD = $"$SetMemIOByte,{SetMemIOByteTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void GetMemIOWordBTN_Click(object sender, EventArgs e) //메모리 워드 값 가져오는 커맨드
        {
            gCMD = $"$GetMemIOWord,{GetMemIOWordTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void SetMemIOWordBTN_Click(object sender, EventArgs e) //메모리 워드 값 설정하는 커맨드
        {
            gCMD = $"$SetMemIOWord,{SetMemIOWordTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void GetStatusBTN_Click(object sender, EventArgs e) //로봇 상태 가져오는 커맨드
        {
            gCMD = $"$GetStatus\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void AbortBTN_Click(object sender, EventArgs e) //주지 커맨드
        {
            gCMD = $"$Abort\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void GetAlmBTN_Click(object sender, EventArgs e) //알람 가져오는 커맨드
        {
            gCMD = $"$GetAlm\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }

        private void ResetAlmBTN_Click(object sender, EventArgs e) //알람 리셋 하는 커맨드.
        {
            gCMD = $"$ResetAlm,{ResetAlmTB.Text}\\n";
            byte[] Buffer = Encoding.Default.GetBytes(gCMD);
            gClient.Send(Buffer, SocketFlags.None);
        }
    }
}
