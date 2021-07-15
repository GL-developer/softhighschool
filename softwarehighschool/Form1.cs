using System.Windows.Forms;
using System.Net.Sockets;
using System;
using System.Threading;

namespace softwarehighschool
{
    public partial class MainForm : Form
    {
        private TcpClient client = new TcpClient();
        private int state = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_connection_Click(object sender, System.EventArgs e)
        {
            if (client.Connected == false)
            {
                client = new TcpClient(textBox_ip.Text, Int32.Parse(textBox_port.Text));
                if (client.Connected == true)
                {
                    MessageBox.Show("연결 성공!!!");
                    button_connection.Text = "이더넷 연결 해제";
                    button_connection.BackColor = System.Drawing.Color.Red;

                    Thread thr = new Thread(getDataThread);
                    thr.IsBackground = true;
                    thr.Start();
                }
                else
                {
                    MessageBox.Show("연결 실패...");
                }
            }
            else
            {
                client.Close();
                button_connection.Text = "이더넷 연결";
                button_connection.BackColor = System.Drawing.Color.Blue;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (client.Connected == true && state == 0)
            {
                NetworkStream buffer = client.GetStream();
                byte[] on = new byte[] {0x02, 0xFF, 0x00, 0x00, 0x64, 0x00, 0x00, 0x00, 0x20, 0x4D, 0x01, 0x00, 0x10  };
                byte[] off = new byte[] { 0x02, 0xFF, 0x00, 0x00, 0x64, 0x00, 0x00, 0x00, 0x20, 0x4D, 0x01, 0x00, 0x00 };

                buffer.Write(on);
                Thread.Sleep(200);
                buffer.Write(off);
                return;
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if (client.Connected == true)
            {
                NetworkStream buffer = client.GetStream();
                byte[] on = new byte[] { 0x02, 0xFF, 0x00, 0x00, 0x65, 0x00, 0x00, 0x00, 0x20, 0x4D, 0x01, 0x00, 0x10 };
                byte[] off = new byte[] { 0x02, 0xFF, 0x00, 0x00, 0x65, 0x00, 0x00, 0x00, 0x20, 0x4D, 0x01, 0x00, 0x00 };
                buffer.Write(on);
                Thread.Sleep(200);
                buffer.Write(off);
            }
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            if (client.Connected == true)
            {
                NetworkStream buffer = client.GetStream();
                byte[] on = new byte[] { 0x02, 0xFF, 0x00, 0x00, 0x66, 0x00, 0x00, 0x00, 0x20, 0x4D, 0x01, 0x00, 0x10 };
                byte[] off = new byte[] { 0x02, 0xFF, 0x00, 0x00, 0x66, 0x00, 0x00, 0x00, 0x20, 0x4D, 0x01, 0x00, 0x00 };
                if (state == 2)
                {
                    buffer.Write(on);
                    button_down.Text = "비가동 정지";
                }
                else
                {
                    buffer.Write(off);
                    button_down.Text = "비가동 시작";
                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            if (client.Connected == true)
            {
                byte[] on = new byte[] { 0x02, 0xFF, 0x00, 0x00, 0x67, 0x00, 0x00, 0x00, 0x20, 0x4D, 0x01, 0x00, 0x10 };
                byte[] off = new byte[] { 0x02, 0xFF, 0x00, 0x00, 0x67, 0x00, 0x00, 0x00, 0x20, 0x4D, 0x01, 0x00, 0x00 };
                NetworkStream buffer = client.GetStream();
                buffer.Write(on);
                Thread.Sleep(200);
                buffer.Write(off);
            }
        }

        private void getDataThread()
        {
            byte[] obuf = new byte[] {0x01, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20, 0x44, 0x08, 0x00};
            byte[] ibuf = new byte[100];
            NetworkStream buffer = client.GetStream();
            while (client.Connected == true)
            {
                buffer.Write(obuf);
                buffer.Read(ibuf, 0, ibuf.Length);

                int counter = (ibuf[5] << 8) + ibuf[4];
                int runtime = (ibuf[9] << 8) + ibuf[8];
                int downtime = (ibuf[13] << 8) + ibuf[12];
                state = ibuf[16];
                this.Invoke(new Action(
                    delegate ()
                    {

                        string[] stateText = new string[] { "정지", "비가동", "가동" };

                        label_runtime.Text = TimeSpan.FromSeconds(runtime).ToString();
                        label_downtime.Text = TimeSpan.FromSeconds(downtime).ToString();
                        label_counter.Text = counter.ToString() + " 회";
                        label_state.Text = stateText[state];
                        if (runtime + downtime <= 0)
                        {
                            label_downrate.Text = "0%";
                            label_runrate.Text = "0%";
                        }
                        else
                        {
                            label_downrate.Text = (downtime * 100 / (runtime + downtime)).ToString() + "%";
                            label_runrate.Text = (runtime * 100 / (runtime + downtime)).ToString() + "%";
                        }
                    }
                ));
                Thread.Sleep(200);
            }
        }

        
    }
}
