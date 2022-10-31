using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace Run
{

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawGrap postroenie = new DrawGrap(panel1.CreateGraphics());
            postroenie.Postroenie();
            postroenie.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random randomNumbers = new Random();
            int fireNumber = randomNumbers.Next(1, 8);
            DrawGrap fire = new DrawGrap(panel1.CreateGraphics());
            fire.Fire(fireNumber);
            fire.Dispose();

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
          //  Form1 MyFrm2 = new Form1();
           // Point point = new Point(Location.X, Location.Y);
            int X = Location.X;
            int Y = Location.Y;

            // Point W = Run.Form1.Location;
             Color clofxdv = Win32.GetPixelColor(100,100);
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       


        public class DrawGrap : Form1
        {
            protected Graphics GG;

            public DrawGrap(Graphics g)
            {
                GG = g;
            }


            public void Postroenie()
            {
                Pen P = new Pen(System.Drawing.Color.Black);
                Pen Door = new Pen(System.Drawing.Color.Black, 3);


                GG.DrawRectangle(P, 0, 0, 399, 399);

                GG.DrawLine(P, 100, 100, 300, 100);
                GG.DrawLine(P, 300, 0, 300, 400);
                GG.DrawLine(P, 300, 200, 400, 200);
                GG.DrawLine(P, 300, 300, 400, 300);
                GG.DrawLine(P, 300, 200, 400, 200);
                GG.DrawLine(P, 0, 200, 200, 200);
                GG.DrawLine(P, 200, 200, 200, 400);
                GG.DrawLine(P, 300, 200, 400, 200);
                GG.DrawLine(P, 0, 300, 200, 300);
                GG.DrawLine(P, 100, 0, 100, 200);
                P.Dispose();

                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);

                GG.FillEllipse(Brushes.Black, 89, 340, 26, 26);
                GG.FillEllipse(Brushes.White, 90, 341, 24, 24);
                GG.DrawString("1", drawFont, Brushes.Black, 92, 342);

                GG.FillEllipse(Brushes.Black, 89, 240, 26, 26);
                GG.FillEllipse(Brushes.White, 90, 241, 24, 24);
                GG.DrawString("2", drawFont, Brushes.Black, 92, 242);

                GG.FillEllipse(Brushes.Black, 39, 90, 26, 26);
                GG.FillEllipse(Brushes.White, 40, 91, 24, 24);
                GG.DrawString("3", drawFont, Brushes.Black, 42, 92);

                GG.FillEllipse(Brushes.Black, 189, 40, 26, 26);
                GG.FillEllipse(Brushes.White, 190, 41, 24, 24);
                GG.DrawString("4", drawFont, Brushes.Black, 192, 42);

                GG.FillEllipse(Brushes.Black, 339, 40, 26, 26);
                GG.FillEllipse(Brushes.White, 340, 41, 24, 24);
                GG.DrawString("5", drawFont, Brushes.Black, 342, 42);

                GG.FillEllipse(Brushes.Black, 339, 240, 26, 26);
                GG.FillEllipse(Brushes.White, 340, 241, 24, 24);
                GG.DrawString("6", drawFont, Brushes.Black, 342, 242);

                GG.FillEllipse(Brushes.Black, 339, 339, 26, 26);
                GG.FillEllipse(Brushes.White, 340, 340, 24, 24);
                GG.DrawString("7", drawFont, Brushes.Black, 342, 342);

                drawFont.Dispose();



                GG.DrawLine(Door, 230, 398, 270, 398);
                GG.DrawLine(Door, 100, 130, 100, 170);
                GG.DrawLine(Door, 300, 130, 300, 170);
                GG.DrawLine(Door, 200, 230, 200, 270);
                GG.DrawLine(Door, 300, 230, 300, 270);
                GG.DrawLine(Door, 200, 330, 200, 370);
                GG.DrawLine(Door, 300, 330, 300, 370);
                GG.DrawLine(Door, 130, 100, 170, 100);
                Door.Dispose();

                GG.FillRectangle(Brushes.Purple, 240, 370, 20, 25);
              //  GG.FillRectangle(Brushes.Purple, 0, 0, 400, 400);



              /*        for (int i = 370; i > 0; --i)
                      {
                          Thread.Sleep(10);
                          GG.FillRectangle(Brushes.Purple, 240, i, 20, 25);
                      }*/


                //   GG.Dispose();

            }

            public void Fire(int fireNumber)
            {
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);

                if (fireNumber == 1)
                {
                    GG.FillEllipse(Brushes.Black, 89, 340, 26, 26);
                    GG.FillEllipse(Brushes.Red, 90, 341, 24, 24);
                    GG.DrawString("1", drawFont, Brushes.Black, 92, 342);

                }
                else if (fireNumber == 2)
                {
                    GG.FillEllipse(Brushes.Black, 89, 240, 26, 26);
                    GG.FillEllipse(Brushes.Red, 90, 241, 24, 24);
                    GG.DrawString("2", drawFont, Brushes.Black, 92, 242);
                }
                else if (fireNumber == 3)
                {
                    GG.FillEllipse(Brushes.Black, 39, 90, 26, 26);
                    GG.FillEllipse(Brushes.Red, 40, 91, 24, 24);
                    GG.DrawString("3", drawFont, Brushes.Black, 42, 92);

                }
                else if (fireNumber == 4)
                {
                    GG.FillEllipse(Brushes.Black, 189, 40, 26, 26);
                    GG.FillEllipse(Brushes.Red, 190, 41, 24, 24);
                    GG.DrawString("4", drawFont, Brushes.Black, 192, 42);
                }
                else if (fireNumber == 5)
                {
                    GG.FillEllipse(Brushes.Black, 339, 40, 26, 26);
                    GG.FillEllipse(Brushes.Red, 340, 41, 24, 24);
                    GG.DrawString("5", drawFont, Brushes.Black, 342, 42);
                }
                else if (fireNumber == 6)
                {
                    GG.FillEllipse(Brushes.Black, 339, 240, 26, 26);
                    GG.FillEllipse(Brushes.Red, 340, 241, 24, 24);
                    GG.DrawString("6", drawFont, Brushes.Black, 342, 242);
                }
                else if (fireNumber == 7)
                {
                    GG.FillEllipse(Brushes.Black, 339, 339, 26, 26);
                    GG.FillEllipse(Brushes.Red, 340, 340, 24, 24);
                    GG.DrawString("7", drawFont, Brushes.Black, 342, 342);
                }

                drawFont.Dispose();
            }

            

        }

        public class Win32
        {
            [DllImport("user32.dll")]
            static extern IntPtr GetDC(IntPtr hwnd);

            [DllImport("user32.dll")]
            static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

            [DllImport("gdi32.dll")]
            static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

            static public System.Drawing.Color GetPixelColor(int x, int y)
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                uint pixel = GetPixel(hdc, x, y);
                ReleaseDC(IntPtr.Zero, hdc);
                Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                             (int)(pixel & 0x0000FF00) >> 8,
                             (int)(pixel & 0x00FF0000) >> 16);
                return color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random randomNumbers = new Random();
            int fireNumber = randomNumbers.Next(1, 8);
            DrawGrap fire = new DrawGrap(panel1.CreateGraphics());
            fire.Fire(fireNumber);
            fire.Dispose();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DrawGrap postroenie = new DrawGrap(panel1.CreateGraphics());
            postroenie.Postroenie();
            postroenie.Dispose();

        }
    }
}
