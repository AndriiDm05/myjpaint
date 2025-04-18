using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace mojpaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color kolor = Color.Black;
        int grubosc_penzla = 4;
        Bitmap bnp;
        List<Point> lista_xy = new List<Point>();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseUp(object sender, EventArgs e)
        {
            fsend(-1, -1, kolor);
            lista_xy.Clear();
        }
        void fsend(int x, int y, Color kolor)
        {

            byte[] bytCommand = new byte[] { };
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(IPAddress.Parse("127.0.0.1"), 8000);
            bytCommand = Encoding.UTF8.GetBytes($"#({x}, {y}, {kolor.R}, {kolor.G}, {kolor.B})");
            udpClient.Send(bytCommand, bytCommand.Length);
            pictureBox1.CreateGraphics().DrawEllipse(new Pen(kolor, grubosc_penzla), x - 2, y - 2, 4, 4);
            
        }

        void frec()
        {
            CheckForIllegalCrossThreadCalls = false;

            //byte[] bytCommand = new byte[] { };
            System.Net.Sockets.UdpClient receivingUdpClient = new System.Net.Sockets.UdpClient(8000);

            Thread th = new Thread(() => {
                IPEndPoint iep = new System.Net.IPEndPoint(System.Net.IPAddress.Any, 0);
                while (true)
                {
                    byte[] receiveBytes = receivingUdpClient.Receive(ref iep);

                    string str = System.Text.Encoding.UTF8.GetString(receiveBytes);

                    int x = Convert.ToInt32(str.Replace("$", "").Replace("(", "").Replace(")", "").Split(',')[0]);
                    int y = Convert.ToInt32(str.Replace("$", "").Replace("(", "").Replace(")", "").Split(',')[1]);

                    int r = Convert.ToInt32(str.Replace("$", "").Replace("(", "").Replace(")", "").Split(',')[2]);
                    int g = Convert.ToInt32(str.Replace("$", "").Replace("(", "").Replace(")", "").Split(',')[3]);
                    int b = Convert.ToInt32(str.Replace("$", "").Replace("(", "").Replace(")", "").Split(',')[4]);

                    pictureBox1.CreateGraphics().DrawEllipse(new Pen(Color.FromArgb(r, g, b), grubosc_penzla), x - 2, y - 2, 4, 4);
                    pictureBox2.CreateGraphics().Clear(Color.FromArgb(r, g, b));
                }

            });
            th.IsBackground = true;
            th.Start();

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

                try
                {
                    fsend(e.X, e.Y, kolor);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void zapiszplikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "plik jpg|* .jpg|plik png|* .png";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    bnp.Save(saveFileDialog1.FileName);
                }
                catch (Exception ex){
                    MessageBox.Show($"Nie mogę zapisać plika!\n(ex.Message)");
                }
            }
        }

        private void zamknijprogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Applpcation.Exit();
        }

        private void kolorPenzlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                kolor = colorDialog1.Color;
            } 
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            grubosc_penzla = Convert.ToInt32(numericUpDown1.Value);
        }

        private void gruboscPedzlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.numericUpDown1.Value = grubosc_penzla;
            frm2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bnp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bnp);
            gr.Clear(Color.White);
            pictureBox1.Image = bnp;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            lista_xy.Clear();
        }

        private void otworzplikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "plik jpg|* .jpg|plik png|* .png";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    bnp = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = bnp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Nie mogę otworzyć plika!\n(ex.Message)");
                }
            }
        }

        private void skalaSzarosciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < bnp.Width; x++)
            {
                for (int y = 0; y < bnp.Height; y++)
                {
                    int r = bnp.GetPixel(x, y).R;
                    int g = bnp.GetPixel(x, y).G;
                    int b = bnp.GetPixel(x, y).B;
                    int srednia = (r + g + b) / 3;
                    bnp.SetPixel(x, y, Color.FromArgb(srednia, srednia, srednia));
                    if (b >= 128 && b <= 255)
                    {
                        bnp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    } else
                    {
                        bnp.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }


            }
            pictureBox1.Image = bnp;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usuńNieboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < bnp.Width; x++)
            {
                for (int y = 0; y < bnp.Height; y++)
                {
                    int r = bnp.GetPixel(x, y).R;
                    int g = bnp.GetPixel(x, y).G;
                    int b = bnp.GetPixel(x, y).B;
                    int srednia = (r + g + b) / 3;
                    if (b >= 150)
                    {
                        bnp.SetPixel(x, y, Color.White);
                    }
                }
            }
            pictureBox1.Image = bnp;
        }
        private void rozmywanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //for (int x = 0 + 1; x < bnp.Width - 1; x++)
            //{
            //    for (int y = 0 + 1; y < bnp.Height - 1; y++)
            //    {
            //        int intavgR = ((bnp.GetPixel(x - 1, y - 1).R + bnp.GetPixel(x, y - 1).R + bnp.GetPixel(x + 1, y - 1).R + bnp.GetPixel(x - 1, y).R + bnp.GetPixel(x, y).R + bnp.GetPixel(x + 1, y).R + bnp.GetPixel(x - 1, y + 1).R + bnp.GetPixel(x, y + 1).R + bnp.GetPixel(x + 1, y + 1).R) / 9);
            //        int intavgG = ((bnp.GetPixel(x - 1, y - 1).G + bnp.GetPixel(x, y - 1).G + bnp.GetPixel(x + 1, y - 1).G + bnp.GetPixel(x - 1, y).G + bnp.GetPixel(x, y).G + bnp.GetPixel(x + 1, y).G + bnp.GetPixel(x - 1, y + 1).G + bnp.GetPixel(x, y + 1).G + bnp.GetPixel(x + 1, y + 1).G) / 9);
            //        int intavgB = ((bnp.GetPixel(x - 1, y - 1).B + bnp.GetPixel(x, y - 1).B + bnp.GetPixel(x + 1, y - 1).B + bnp.GetPixel(x - 1, y).B + bnp.GetPixel(x, y).B + bnp.GetPixel(x + 1, y).B + bnp.GetPixel(x - 1, y + 1).B + bnp.GetPixel(x, y + 1).B + bnp.GetPixel(x + 1, y + 1).B) / 9);
            //        bnp.SetPixel(x, y, Color.FromArgb(intavgR, intavgG, intavgB));
            //    }
            //}
            //pictureBox1.Image = bnp;
            Color[,] m = new Color[bnp.Width, bnp.Height];
            for (int x = 0; x < bnp.Width; x++)
            {
                for (int y = 0; y < bnp.Height; y++)
                {
                    m[x, y] = bnp.GetPixel(x, y);
                }
            }
            int ile = 30;
            Parallel.For(0, ile, (int k) =>
            {
                int d = m.GetLength(0) / ile;
                int x1 = 0 + 1 + d * k;
                int x2 = Math.Min(x1 + d, m.GetLength(0) - 1);

                for (int x = x1; x < x2 - 1; x++)
                {
                    for (int y = 0 + 1; y < m.GetLength(1) - 1; y++)
                    {
                        int intavgR = ((bnp.GetPixel(x - 1, y - 1).R + bnp.GetPixel(x, y - 1).R + bnp.GetPixel(x + 1, y - 1).R + bnp.GetPixel(x - 1, y).R + bnp.GetPixel(x, y).R + bnp.GetPixel(x + 1, y).R + bnp.GetPixel(x - 1, y + 1).R + bnp.GetPixel(x, y + 1).R + bnp.GetPixel(x + 1, y + 1).R) / 9);
                        int intavgG = ((bnp.GetPixel(x - 1, y - 1).G + bnp.GetPixel(x, y - 1).G + bnp.GetPixel(x + 1, y - 1).G + bnp.GetPixel(x - 1, y).G + bnp.GetPixel(x, y).G + bnp.GetPixel(x + 1, y).G + bnp.GetPixel(x - 1, y + 1).G + bnp.GetPixel(x, y + 1).G + bnp.GetPixel(x + 1, y + 1).G) / 9);
                        int intavgB = ((bnp.GetPixel(x - 1, y - 1).B + bnp.GetPixel(x, y - 1).B + bnp.GetPixel(x + 1, y - 1).B + bnp.GetPixel(x - 1, y).B + bnp.GetPixel(x, y).B + bnp.GetPixel(x + 1, y).B + bnp.GetPixel(x - 1, y + 1).B + bnp.GetPixel(x, y + 1).B + bnp.GetPixel(x + 1, y + 1).B) / 9);
                        lock (bnp)
                        {
                        bnp.SetPixel(x, y, Color.FromArgb(intavgR, intavgG, intavgB));
                        }
                    }
                }

            });
            pictureBox1.Image = bnp;

        }
        // nie dziala wykrywanie horyzontu
        private void wykrywanieHoryzontuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < bnp.Height; y++)
            {
                int i = 0;
                for (int x = 0; x < bnp.Width; x++)
                {
                    int r = bnp.GetPixel(x, y).R;
                    int g = bnp.GetPixel(x, y).G;
                    int b = bnp.GetPixel(x, y).B;
                    if (g >= 100)
                    {
                        i++;
                    }
                }
                if (i == bnp.Width / 2)
                {                   
                    for (int x = 0; x < bnp.Width; x++) // Ustawiamy wykrytą linię horyzontu na biały
                    {
                        bnp.SetPixel(x, y, Color.Red);
                    }                   
                }
            }
            pictureBox1.Image = bnp;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frec();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
