﻿using System;
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
using System.Threading;

namespace TcpForT6
{
    public partial class Form1 : Form
    {
        Socket gClient;
        string gCMD;
        public Form1()
        {
            InitializeComponent();
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    DisableControl();
                }));
            }
            else
            {
                DisableControl();
            }
        }
        private void ConnectBTN_Click(object sender, EventArgs e) //로봇과 연결 하는 부분
        {
            if (ConnectBTN.Text == "연결")
            {
                string IP = IPTB.Text;
                int Port = int.Parse(PortTB.Text);
                gClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IAsyncResult waiter = gClient.BeginConnect(new IPEndPoint(IPAddress.Parse(IP), Port), null, null);
                bool success = waiter.AsyncWaitHandle.WaitOne(1000, true);
                try
                {
                    if (success)
                    {
                        MessageBox.Show("연결 완료");
                        Task task = Receive_Data();
                        if (InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                EnabledControl();
                            }));
                        }
                        else
                        {
                            EnabledControl();
                        }
                    }
                    else
                    {
                        gClient.Close();
                        MessageBox.Show("연결 실패");
                    }
                }
                catch (Exception ex)
                {
                    gClient.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                gClient.Close();
                MessageBox.Show("연결 해제");
            }
        }
        private void DisableControl() // 버튼 비활성화
        {
            LoginPanel.Enabled = false;
            CommandPanel.Enabled = false;
            BTNPanel.Enabled = false;
            XYZUpanel.Enabled = false;
            testpanel.Enabled = false;
            spelpanel.Enabled = false;

            ConnectBTN.Text = "연결";

            connectpanel.Enabled = true;
        }
        private void EnabledControl() //버튼 활성화
        {
            LoginPanel.Enabled = true;
            CommandPanel.Enabled = true;
            BTNPanel.Enabled = true;
            XYZUpanel.Enabled = true;
            testpanel.Enabled = true;
            spelpanel.Enabled = true;

            ConnectBTN.Text = "연결 해제";

            connectpanel.Enabled = false;
        }
        private async Task Receive_Data() //로봇이 송신한 결과를 가져와서 띄워주는 부분.
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
        private void LoginBTN_Click(object sender, EventArgs e)// 로그인 커맨드
        {
            try
            {
                gCMD = $"$Login,{PasswordTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }
        private void SendBTN_Click(object sender, EventArgs e) //커맨드 전송
        {
            try
            {
                gCMD = CMDTB.Text;
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }

        }

        private void LogoutBTN_Click(object sender, EventArgs e) //로그아웃 커맨드
        {
            try
            {
                gCMD = @"$LogOut\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void ExecuteBTN_Click(object sender, EventArgs e) //스펠 언어 실행 커맨드
        {
            try
            {
                gCMD = $"$Execute,\"{ExecuteTB.Text}\"\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void StartBTN_Click(object sender, EventArgs e) //함수 시작 커맨드
        {
            try
            {
                gCMD = $"$Start,{StartTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void StopBTN_Click(object sender, EventArgs e) //멈춤 커맨드
        {
            try
            {
                gCMD = $"$Stop\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void PauseBTN_Click(object sender, EventArgs e) //일시정지 커맨드
        {
            try
            {
                gCMD = $"$Pause\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void ContinueBTN_Click(object sender, EventArgs e) //재개 커맨드
        {
            try
            {
                gCMD = $"$Continue\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void ResetBTN_Click(object sender, EventArgs e) //리셋 커맨드
        {
            try
            {
                gCMD = $"$Reset\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void MotorOnBTN_Click(object sender, EventArgs e) //모터 켜기 커맨드
        {
            try
            {
                gCMD = $"$SetMotorsOn,{MotorOnTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void MotorOffBTN_Click(object sender, EventArgs e) //모터 끄기 커맨드
        {
            try
            {
                gCMD = $"$SetMotorsOff,{MotorOffTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void GetCurRobotBTN_Click(object sender, EventArgs e) //선택된 로봇 번호 커맨드
        {
            try
            {
                gCMD = $"$GetCurRobot\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void SetCurRobotBTN_Click(object sender, EventArgs e) //로봇 선택 커맨드
        {
            try
            {
                gCMD = $"$SetCurRobot,{SetCurRobotTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void HomeBTN_Click(object sender, EventArgs e) //홈 커맨드
        {
            try
            {
                gCMD = $"$Home,{HomeTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void GetBitBTN_Click(object sender, EventArgs e) //비트 값 가져오는 커맨드
        {
            try
            {
                gCMD = $"$GetIO,{GetBitTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void SetIOBTN_Click(object sender, EventArgs e) //비트 값 설정하는 커맨드
        {
            try
            {
                gCMD = $"$SetIO,{SetIOTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void GetIOByteBTN_Click(object sender, EventArgs e) //바이트 값 가져오는 커맨드
        {
            try
            {
                gCMD = $"$GetIOByte,{GetIOByteTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void SetIOByteBTN_Click(object sender, EventArgs e) //바이트 값 설정하는 커맨드
        {
            try
            {
                gCMD = $"$SetIOByte,{SetIOByteTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void GetIOWordBTN_Click(object sender, EventArgs e) //워드 값 가져오는 커맨드
        {
            try
            {
                gCMD = $"$GetIOWord,{GetIOWordTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void SetIOWordBTN_Click(object sender, EventArgs e) //워드 값 설정하는 커맨드
        {
            try
            {
                gCMD = $"$SetIOWord,{SetIOWordTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void GetMemIOBTN_Click(object sender, EventArgs e) //메모리 비트 값 가져오는 커맨드
        {
            try
            {
                gCMD = $"$GetMemIO,{GetMemIOTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void SetMemIOBTN_Click(object sender, EventArgs e) //메모리 비트 값 설정하는 커맨드
        {
            try
            {
                gCMD = $"$SetMemIO,{SetMemIOTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void GetMemIOByteBTN_Click(object sender, EventArgs e) //메모리 바이트 값 가져오는 커맨드
        {
            try
            {
                gCMD = $"$GetMemIOByte,{GetMemIOByteTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void SetMemIOByteBTN_Click(object sender, EventArgs e) //메모리 바이트 값 설정하는 커맨드
        {
            try
            {
                gCMD = $"$SetMemIOByte,{SetMemIOByteTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void GetMemIOWordBTN_Click(object sender, EventArgs e) //메모리 워드 값 가져오는 커맨드
        {
            try
            {
                gCMD = $"$GetMemIOWord,{GetMemIOWordTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void SetMemIOWordBTN_Click(object sender, EventArgs e) //메모리 워드 값 설정하는 커맨드
        {
            try
            {
                gCMD = $"$SetMemIOWord,{SetMemIOWordTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void GetStatusBTN_Click(object sender, EventArgs e) //로봇 상태 가져오는 커맨드
        {
            try
            {
                gCMD = $"$GetStatus\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void AbortBTN_Click(object sender, EventArgs e) //주지 커맨드
        {
            try
            {
                gCMD = $"$Abort\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void GetAlmBTN_Click(object sender, EventArgs e) //알람 가져오는 커맨드
        {
            try
            {
                gCMD = $"$GetAlm\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void ResetAlmBTN_Click(object sender, EventArgs e) //알람 리셋 하는 커맨드.
        {
            try
            {
                gCMD = $"$ResetAlm,{ResetAlmTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void GetVariableBTN_Click(object sender, EventArgs e) //변수값 가져오는 부분.
        {
            try
            {
                gCMD = $"$GetVariable,{GetVariableTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void SetVariableBTN_Click(object sender, EventArgs e)
        {
            try
            {
                gCMD = $"$SetVariable,{SetVariableTB.Text}\\n";
                byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                gClient.Send(Buffer, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void XYZUChangebtn_Click(object sender, EventArgs e)
        {
            try
            {
                gCMD = $"$SetVariable,X,{Xtb.Text},Double\\n";
                byte[] BufferX = Encoding.Default.GetBytes(gCMD);
                gClient.Send(BufferX, SocketFlags.None);
                Thread.Sleep(1);
                
                gCMD = $"$SetVariable,Y,{Ytb.Text},Double\\n";
                byte[] BufferY = Encoding.Default.GetBytes(gCMD);
                gClient.Send(BufferY, SocketFlags.None);
                Thread.Sleep(1);

                gCMD = $"$SetVariable,Z,{Ztb.Text},Double\\n";
                byte[] BufferZ = Encoding.Default.GetBytes(gCMD);
                gClient.Send(BufferZ, SocketFlags.None);
                Thread.Sleep(1);

                gCMD = $"$SetVariable,U,{Utb.Text},Double\\n";
                byte[] BufferU = Encoding.Default.GetBytes(gCMD);
                gClient.Send(BufferU, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void XYZUGetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                gCMD = $"$GetVariable,X,Double\\n";
                byte[] BufferX = Encoding.Default.GetBytes(gCMD);
                gClient.Send(BufferX, SocketFlags.None);
                Thread.Sleep(1);

                gCMD = $"$GetVariable,Y,Double\\n";
                byte[] BufferY = Encoding.Default.GetBytes(gCMD);
                gClient.Send(BufferY, SocketFlags.None);
                Thread.Sleep(1);

                gCMD = $"$GetVariable,Z,Double\\n";
                byte[] BufferZ = Encoding.Default.GetBytes(gCMD);
                gClient.Send(BufferZ, SocketFlags.None);
                Thread.Sleep(1);

                gCMD = $"$GetVariable,U,Double\\n";
                byte[] BufferU = Encoding.Default.GetBytes(gCMD);
                gClient.Send(BufferU, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private void Testbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //for (int i = 1; i < 6; i++)
                //{
                    gCMD = $"$Stop\\n";
                    byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                    gClient.Send(Buffer, SocketFlags.None);

                    Thread.Sleep(1);
                    gCMD = $"$SetVariable,idx,{2},Double\\n";
                    byte[] Bufferidx = Encoding.Default.GetBytes(gCMD);
                    gClient.Send(Bufferidx, SocketFlags.None);

                    Thread.Sleep(1);
                    gCMD = $"$Start,1\\n";
                    byte[] BufferStart = Encoding.Default.GetBytes(gCMD);
                    gClient.Send(BufferStart, SocketFlags.None);

                    Thread.Sleep(8000);

                    gCMD = $"$Stop\\n";
                    byte[] Buffer2 = Encoding.Default.GetBytes(gCMD);
                    gClient.Send(Buffer2, SocketFlags.None);

                    Thread.Sleep(1000);
                    gCMD = $"$SetVariable,idx,{3},Double\\n";
                    byte[] Bufferidx2 = Encoding.Default.GetBytes(gCMD);
                    gClient.Send(Bufferidx2, SocketFlags.None);

                    Thread.Sleep(1);
                    gCMD = $"$Start,1\\n";
                    byte[] BufferStart2 = Encoding.Default.GetBytes(gCMD);
                    gClient.Send(BufferStart2, SocketFlags.None);

                    Thread.Sleep(8000);

                   gCMD = $"$Stop\\n";
                    byte[] Buffer3 = Encoding.Default.GetBytes(gCMD);
                    gClient.Send(Buffer3, SocketFlags.None);

                    Thread.Sleep(1000);
                    gCMD = $"$SetVariable,idx,{4},Double\\n";
                    byte[] Bufferidx3 = Encoding.Default.GetBytes(gCMD);
                    gClient.Send(Bufferidx3, SocketFlags.None);

                    Thread.Sleep(1);
                    gCMD = $"$Start,1\\n";
                    byte[] BufferStart3 = Encoding.Default.GetBytes(gCMD);
                    gClient.Send(BufferStart3, SocketFlags.None);


                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisableControl();
            }
        }

        private async void buttonrichexecute_Click(object sender, EventArgs e)
        {
            string[] rowSpels = richTextBoxSpel.Text.Trim().Split('\n');
            foreach(string spel in rowSpels)
            {
                try
                {
                    gCMD = $"$Execute,\"{spel}\"\\n";
                    byte[] Buffer = Encoding.Default.GetBytes(gCMD);
                    gClient.Send(Buffer, SocketFlags.None);
                    await Task.Delay(1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    DisableControl();
                }
            }
        }
    }
}
