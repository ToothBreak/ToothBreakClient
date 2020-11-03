using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace project_1
{
    public partial class Form1 : Form
    {
        static Socket sck;
        static int num = Rand();

        public Form1()
        {
            InitializeComponent();
        }

        static public int Rand()
        {
            Random random = new Random();
            int number = random.Next(1, 8);
            Console.WriteLine(number);

            return number;
        }

        static public int soc()
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("192.168.0.44"), 3300);

            try
            {
                sck.Connect(localEndPoint);
            }
            catch
            {
                Console.Write("Unable to connect to remote end point!\r\n");
            }

            byte[] data = Encoding.UTF8.GetBytes("0");

            sck.Send(data);

            Console.Write("Data Sent!\r\n");

            sck.Close();

            return 1;
        }

        static public int lightoff()
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("192.168.0.44"), 3300);

            try
            {
                sck.Connect(localEndPoint);
            }
            catch
            {
                Console.Write("Unable to connect to remote end point!\r\n");
            }

            byte[] data = Encoding.UTF8.GetBytes("2");

            sck.Send(data);

            Console.Write("Data Sent!\r\n");

            sck.Close();

            return 1;
        }

        static public int Game(int n)
        {
            if (num == n)
            {
                sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("192.168.0.44"), 3300);

                try
                {
                    sck.Connect(localEndPoint);
                }
                catch
                {
                    Console.Write("Unable to connect to remote end point!\r\n");
                }

                byte[] data = Encoding.UTF8.GetBytes("1");

                sck.Send(data);

                Console.Write("Data Sent!\r\n");

                sck.Close();
                MessageBox.Show("이빨이 빠져버렸어요!ㅠㅠ");
            }
                
            return n;
        }

        private void tooth1_Click(object sender, EventArgs e)
        {
            int n = 1;
            Game(n);

            if (num != 1)
            {
                tooth1.BackColor = Color.White;

                soc();
            }
        }

        private void tooth2_Click(object sender, EventArgs e)
        {
            int n = 2;
            Game(n);

            if (num != 2)
            {
                tooth2.BackColor = Color.White;

                soc();
            }
        }

        private void tooth3_Click(object sender, EventArgs e)
        {
            int n = 3;
            Game(n);

            if (num != 3)
            {
                tooth3.BackColor = Color.White;

                soc();
            }
        }

        private void tooth4_Click(object sender, EventArgs e)
        {
            int n = 4;
            Game(n);

            if (num != 4)
            {
                tooth4.BackColor = Color.White;

                soc();
            }
        }

        private void tooth5_Click(object sender, EventArgs e)
        {
            int n = 5;
            Game(n);

            if (num != 5)
            {
                tooth5.BackColor = Color.White;

                soc();
            }
        }

        private void tooth6_Click(object sender, EventArgs e)
        {
            int n = 6;
            Game(n);

            if (num != 6)
            {
                tooth6.BackColor = Color.White;

                soc();
            }
        }

        private void tooth7_Click(object sender, EventArgs e)
        {
            int n = 7;
            Game(n);

            if (num != 7)
            {
                tooth7.BackColor = Color.White;

                soc();
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            lightoff();
     
        }

        private void finish_Click(object sender, EventArgs e)
        {
            Close();
            lightoff();
        }
        
    }
}
