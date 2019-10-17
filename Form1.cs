using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.IO;

struct rule
{
    public string a;
    public string b;
}

namespace Graf5
{
    public partial class Form1 : Form
    {
        private rule[] rules = new rule[0];
        private int strtangle = 270;
        string axiom;
        private float maxX, maxY, minX, minY, Ox, Oy;
        private PointF curpoint;
        private Tuple<PointF, PointF>[] pts = new Tuple<PointF, PointF>[0];
        Graphics g;
        private int strtlength = 100;
        private int iter, angle, curangle;
        Stack<Tuple<PointF, int>> rtrn = new Stack<Tuple<PointF, int>>();

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);

            Ox = 5;
            Oy = pictureBox1.Height - 5;
            minY = maxY = Oy;
            minX = maxX = Ox;
            curpoint = new PointF(Ox, Oy);

            StreamReader sr = new StreamReader("rules.txt");
            string fstrule = sr.ReadLine();
            axiom = fstrule.Split(' ')[0];
            angle = Int32.Parse(fstrule.Split(' ')[1]);
            curangle = Int32.Parse(fstrule.Split(' ')[2]);
            while (!sr.EndOfStream)
            {
                string rulerd = sr.ReadLine();
                Array.Resize(ref rules, rules.Length + 1);
                rules[rules.Length - 1].a = rulerd.Split('=')[0];
                rules[rules.Length - 1].b = rulerd.Split('=')[1];
            }
            sr.Dispose();
        }

        private string lsystem()
        {
            string cur = axiom;
            StringBuilder next = new StringBuilder();
            for (int i = 0; i < iter; i++)
            {
                for (int j = 0; j < cur.Length; j++)
                {
                    bool flag = false;
                    foreach (var r in rules)
                    {
                        if (cur[j].ToString() == r.a)
                        {
                            flag = true;
                            next.Append(r.b);
                            break;
                        }
                    }
                    if (!flag)
                        next.Append(cur[j]);
                }
                cur = next.ToString();
                next.Clear();
            }
            return cur;
        }

        private void Forward(float distance)
        {
            var angleRadians = curangle * Math.PI / 180;
            var newX = curpoint.X + (float)(distance * Math.Cos(angleRadians));
            var newY = curpoint.Y + (float)(distance * Math.Sin(angleRadians));
            maxX = newX > maxX ? newX : maxX;
            maxY = newY > maxY ? newY : maxY;
            minY = newY < minY ? newY : minY;
            minX = newX < minX ? newX : minX;
            Array.Resize(ref pts, pts.Length + 1);
            pts[pts.Length - 1] = new Tuple<PointF, PointF>(curpoint, new PointF(newX, newY));
            curpoint.X = newX;
            curpoint.Y = newY;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            clear();
            iter = Decimal.ToInt32(numericUpDown1.Value);
            float length = strtlength / (float)Math.Pow(2, iter);
            string pattern = lsystem();
            foreach (var ch in pattern)
            {
                bool flag = false;
                foreach (var r in rules)
                {
                    if (ch.ToString() == r.a)
                    {
                        flag = true;
                        Forward(length);
                        break;
                    }
                }
                if (!flag)
                    switch (ch)
                    {
                        case '[':
                            rtrn.Push(new Tuple<PointF, int>(curpoint, curangle));
                            break;
                        case ']':
                            var t = rtrn.Pop();
                            curpoint = t.Item1;
                            curangle = t.Item2;
                            break;
                        case '-':
                            curangle -= angle;
                            break;
                        case '+':
                            curangle += angle;
                            break;
                        default:
                            break;
                    }
            }
            pictureBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            g.Clear(Color.White);
            minY = maxY = Oy;
            minX = maxX = Ox;
            curpoint.X = Ox;
            curpoint.Y = Oy;
            curangle = strtangle;
            Array.Clear(pts, 0, pts.Length);
            Array.Resize(ref pts, 0);
            rtrn.Clear();
            pictureBox1.Invalidate();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(pictureBox1.Width / 2 - (maxX + minX) / 2, (pictureBox1.Height) / 2 - (minY + maxY) / 2);
            foreach (var i in pts)
            {
                e.Graphics.DrawLine(Pens.Black, i.Item1, i.Item2);
            }
        }
    }
}
