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

namespace triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            triangle tri = new triangle(Color.Blue);
            Thread t = new Thread(() =>tri.rajzol(g));
            t.Start();
            triangle tri2 = new triangle(Color.Red);
            Thread t2 = new Thread(() => tri2.rajzol(g));
            t2.Start();
            bool stop = false;
            while (!stop)
            {
                if (tri2.getNumber() > 10 || tri.getNumber() > 10)
                {
                    t.Abort();
                    t2.Abort();
                    stop = true;
                }
            }
        }
    }

    class triangle
    {
        int number;
        Color color;
        private Random rnd = new Random();
        Graphics g;

        public int getNumber()
        {
            return number;
        }
        public triangle(Color color)
        {
            this.color = color;
            this.number = 0;
        }

        public void rajzol(Graphics g2)
        {
            this.g = g2;
            SolidBrush brush = new SolidBrush(color);

            Point[] points = new Point[3];

            for (int i = 0; i < 12; i++)
            {
                Point A = new Point(rnd.Next(0, 200), rnd.Next(0, 200));
                Point B = new Point(rnd.Next(0, 200), rnd.Next(0, 200));
                Point C = new Point(rnd.Next(0, 200), rnd.Next(0, 200));

                points[0] = A;
                points[1] = B;
                points[2] = C;

                number++;

                lock (typeof(Program))
                {
                    g.FillPolygon(brush, points);
                }
                Thread.Sleep(100);
            }
        }
    }
}
