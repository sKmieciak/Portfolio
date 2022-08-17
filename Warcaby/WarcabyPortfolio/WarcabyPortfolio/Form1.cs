using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarcabyPortfolio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int rp = 45; // rozmiar pola na planszy
        int n;
        PictureBox[,] P;
        bool bicie;
        int green = 12, red = 12;
        string color = "r",
            k = "" // abx
            , B1 = "", B2 = "", B3 = "", B4 = "";

        private void label4_Click(object sender, EventArgs e)
        {
            //W.Visible = false;
            for (int h = 0; h < n; h++)
                for (int l = 0; l < n; l++)
                {
                    if (h < (n / 2) - 1 && P[h, l].BackColor == Color.Black) { P[h, l].Image = Properties.Resources.r; P[h, l].Name = h + " " + l + " r"; }
                    else if (h > (n / 2) && P[h, l].BackColor == Color.Black)
                    {
                        P[h, l].Image = Properties.Resources.g; P[h, l].Name = h + " " + l + " g";
                    }
                    if (h == ((n / 2) - 1) || h == (n / 2)) P[h, l].Image = null;
                }
            red = 12;
            green = 12;
        }

        private void W_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void counterR_Click(object sender, EventArgs e)
        {

        }

        private void czerwony_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TextBox t = sender as TextBox;
                if (t.Text != "" && zielony.Text != czerwony.Text)
                {
                    t.ReadOnly = true;
                    if (t.Name == "zielony")
                        t.BackColor = Color.Green;
                    else
                        t.BackColor = Color.Red;
                    t.ForeColor = Color.White;
                }
                else
                    if (t.Text == "")
                {
                    MessageBox.Show("Nazwa gracza nie moze byc pusta");
                }
                else
                {
                    MessageBox.Show("Gracze nie moga nazywac sie tak samo");
                }
            }

        }

        private void labelpa_Click(object sender, EventArgs e)
        {
            W.Visible = false;
            for (int h = 0; h < n; h++)
                for (int l = 0; l < n; l++)
                {
                    if (h < (n / 2) - 1 && P[h, l].BackColor == Color.Black) { P[h, l].Image = Properties.Resources.r; P[h, l].Name = h + " " + l + " r"; }
                    else if (h > (n / 2) && P[h, l].BackColor == Color.Black)
                    {
                        P[h, l].Image = Properties.Resources.g; P[h, l].Name = h + " " + l + " g";
                    }
                    if (h == ((n / 2) - 1) || h == (n / 2)) P[h, l].Image = null;
                }
            counterR.Text = "12";
            CounterG.Text = "12";
            zielony.ReadOnly = false;
            czerwony.ReadOnly = false;
            zielony.Text = "";
            czerwony.Text = "";
            zielony.BackColor = Color.White;
            czerwony.BackColor = Color.White;
            zielony.ForeColor = Color.Black;
            czerwony.ForeColor = Color.Black;
            red = 12;
            green = 12;
        }

        private void labelw_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Load(object sender, PaintEventArgs e)
            {
            W.Visible = false;
            if (zielony.ReadOnly && czerwony.ReadOnly)
            {
                n = 8;
                P = new PictureBox[n, n];
                int left = 2, top = 2;
                Color[] colors = new Color[] { Color.White, Color.Black };
                for (int i = 0; i < n; i++)
                {
                    left = 2;
                    if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                    else { colors[0] = Color.Black; colors[1] = Color.White; }
                    for (int j = 0; j < n; j++)
                    {
                        P[i, j] = new PictureBox();
                        P[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                        P[i, j].Location = new Point(left, top);
                        P[i, j].Size = new Size(rp, rp);
                        left += rp;
                        P[i, j].Name = i + " " + j;
                        if (i < (n / 2) - 1 && P[i, j].BackColor == Color.Black)
                        {
                            P[i, j].Image = Properties.Resources.r; P[i, j].Name += " r";
                        }
                        else if (i > (n / 2) && P[i, j].BackColor == Color.Black)
                        {
                            P[i, j].Image = Properties.Resources.g; P[i, j].Name += " g";
                        }
                        P[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                        Podswietlanie(i, j);
                        P[i, j].Click += (sender3, e3) =>
                        {
                            PictureBox p = sender3 as PictureBox;
                            if (p.Image != null)
                            {
                                PredykcjaCzyszczenie();
                                Przesuniecie(p);
                                Predykcja(p);
                            }
                        };
                        G.Controls.Add(P[i, j]);
                    }
                    top += rp;
                }
            }
        }
        public void Podswietlanie(int i, int j)
        {
            P[i, j].MouseHover += (sender2, e2) =>
            {
                PictureBox p = sender2 as PictureBox;
                if (p.Image != null) p.BackColor = Color.FromArgb(255, 64, 64, 64);
            };
            P[i, j].MouseLeave += (sender2, e2) =>
            {
                PictureBox p = sender2 as PictureBox;
                if (p.Image != null) p.BackColor = Color.Black;
            };
        }
        public void Predykcja(PictureBox p)
        {
            int c = -1, x, y;
            if (p.Name.Split(' ')[2] == color)
            {
                x = Convert.ToInt32(p.Name.Split(' ')[0]);
                y = Convert.ToInt32(p.Name.Split(' ')[1]);
                k = p.Name;
                if (p.Name.Split(' ')[2] == "r") c = 1;
                try
                {
                    if (P[x + c, y + 1].Image == null)
                    {
                        P[x + c, y + 1].Image = Properties.Resources.b;
                        P[x + c, y + 1].Name = (x + c) + " " + (y + 1) + " b";
                        B1 = (x + c) + " " + (y + 1);
                    }
                    else if (P[x + c * 2, y + 2].Image == null&& P[x+c,y+1].Name.Split(' ')[2]!= P[x, y].Name.Split(' ')[2])
                    {
                        P[x + c * 2, y + 2].Image = Properties.Resources.b;
                        P[x + c * 2, y + 2].Name = (x + c * 2) + " " + (y + 2) + " b";
                        B1 = (x + c * 2) + " " + (y + 2);
                        bicie = true;
                        B3 = (x + c) + " " + (y + 1);
                        //if (P[x + c * 4, y + 4].Image == null)
                        //{
                        //    drugieBicie = true;
                        //}
                        B4 = B1;
                    }
                }
                catch { }
                try
                {
                    if (P[x + c, y - 1].Image == null)
                    {
                        P[x + c, y - 1].Image = Properties.Resources.b;
                        P[x + c, y - 1].Name = (x + c) + " " + (y - 1) + " b";
                        B2 = (x + c) + " " + (y - 1);
                    }

                    else if (P[x + c*2, y - 2].Image == null && P[x + c, y - 1].Name.Split(' ')[2] != P[x,y].Name.Split(' ')[2])
                    {
                            P[x + c * 2, y - 2].Image = Properties.Resources.b;
                            P[x + c * 2, y - 2].Name = (x + c * 2) + " " + (y - 2) + " b";
                            B2 = (x + c * 2) + " " + (y - 2);
                            bicie = true;
                            B3 = (x + c) + " " + (y - 1);
                            //if (P[x + c * 4, y - 4].Image == null)
                            //{
                            //    drugieBicie = true;
                            //}
                            B4 = B2;
                    }
                }
                catch { }
            }
        }
        public void PredykcjaCzyszczenie()
        {
            if (B1 != "")
            {
                int x, y;
                x = Convert.ToInt32(B1.Split(' ')[0]);
                y = Convert.ToInt32(B1.Split(' ')[1]);
                P[x, y].Image = null;
            }
            if (B2 != "")
            {
                int x, y;
                x = Convert.ToInt32(B2.Split(' ')[0]);
                y = Convert.ToInt32(B2.Split(' ')[1]);
                P[x, y].Image = null;
            }
        }
        public void Przesuniecie(PictureBox p)
        {
            int x, y;
            if (p.Name.Split(' ')[2] == "b")
            {
                //if (color == "r" && drugieBicie == true) color = "r";
                if (color == "r") color = "g";
                else color = "r";
                x = Convert.ToInt32(k.Split(' ')[0]);
                y = Convert.ToInt32(k.Split(' ')[1]);
                B1 = "";
                B2 = "";
                if (k.Split(' ')[2] == "r")
                {
                    p.Image = Properties.Resources.r;
                    p.Name = p.Name.Replace("b", "r");
                    if (B4.Split(' ')[0] == p.Name.Split(' ')[0] && B4.Split(' ')[1] == p.Name.Split(' ')[1])
                    {
                        green--;
                        zbijanie(B3, bicie);
                        bicie = false;
                    }

                }
                if (k.Split(' ')[2] == "g")
                {
                    p.Image = Properties.Resources.g;
                    p.Name = p.Name.Replace("b", "g");
                    if (B4.Split(' ')[0] == p.Name.Split(' ')[0] && B4.Split(' ')[1] == p.Name.Split(' ')[1])
                    {
                        red--;
                        zbijanie(B3, bicie);
                        bicie = false;    
                    }
                }
                P[x, y].Image = null;
            }
        }
        public void zbijanie(string B3,bool bicie)
        {
            if (bicie == true)
            {
                int x, y;
                x = Convert.ToInt32(B3.Split(' ')[0]);
                y = Convert.ToInt32(B3.Split(' ')[1]);
                P[x,y].Image = null;
                //if(drugieBicie == true)
                //    drugieBicie = false;
                counterR.Text = red + "";
                CounterG.Text = green + "";
                if (Convert.ToInt32(green) == 0)
                {
                    //labelw.Text += " GREEN";
                    W.Visible = true;
                }
                if (Convert.ToInt32(red) == 0)
                {
                    labelwin.Text = "GREEN";
                    W.Visible = true;
                }
            }
        }
    }
}
