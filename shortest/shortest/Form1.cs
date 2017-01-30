
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace shortest
{
    
    public partial class Form1 : Form
    {
       
        struct point
        {
            public int num;
            public double x, y;
            public int realx, realy;
        };
        const int MAXSIZE = 200;
        double[,] Matrix = new double[MAXSIZE,MAXSIZE];
        point[] pointarray = new point[MAXSIZE];//点的坐标
        double maxx, minx, maxy, miny;
        int prepoint, currentpoint;
        int n;//点的数量
        public Form1()
        {
            InitializeComponent();
            n = 0;
            prepoint = 0;
            currentpoint = 0;
            openfile1();
            initarray();
            openfile2();
        }
        private void initarray()
        {
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Matrix[i, j] = double.PositiveInfinity;
                }
            }
            for(int i=0;i<n;i++)
            {
                Matrix[i, i] = 0;
            }
        }
        private void openfile1()//打开坐标文件
        {
            StreamReader sr = new StreamReader("/shortest/shortest/zuobiao.txt", Encoding.Default);
            String line;
            maxx = -1;
            maxy = -1;
            minx = double.PositiveInfinity;
            miny = double.PositiveInfinity;
            while ((line = sr.ReadLine()) != null)
            {
                string[] arr = line.Split(' ');
                pointarray[n].num = int.Parse(arr[0]);
                pointarray[n].x = double.Parse(arr[1]);
                pointarray[n].y = double.Parse(arr[2]);
                if (pointarray[n].x > maxx) maxx = pointarray[n].x;
                if (pointarray[n].x < minx) minx = pointarray[n].x;
                if (pointarray[n].y > maxy) maxy = pointarray[n].y;
                if (pointarray[n].y < miny) miny = pointarray[n].y;
                n++;
            }
        }
        private void openfile2()//打开距离文件
        {

            StreamReader sr = new StreamReader("/shortest/shortest/distance.txt", Encoding.Default);
            String line;
            int point1, point2;
            double distance;
            while ((line = sr.ReadLine()) != null)
            {
                string[] arr = line.Split(' ');
                point1 = int.Parse(arr[0]);
                point2 = int.Parse(arr[1]);
                distance = double.Parse(arr[2]);
                Matrix[point1,point2] = distance;
                Matrix[point2,point1] = distance;
            }
        }
        private int[] dijkstra()
        {
            double[] dis = new double[n];
            Boolean[] vis = new Boolean[n];
            int[] pre = new int[n];
            vis[currentpoint] = true;
            int t = currentpoint;
            for(int i=0;i<n;i++)
            {
                dis[i] = Matrix[t,i];
                pre[i] = currentpoint;
            }
            for(int j=0;j<n-1;j++)
            {
                double mini = double.PositiveInfinity;
                for(int i=0;i<n;i++)
                {
                    if(dis[i]<mini&&vis[i]==false)
                    {
                        mini = dis[i];
                        t = i;
                    }
                }
                vis[t] = true;
                if (j == 0) pre[t] = currentpoint;
                for(int i=0;i<n;i++)
                {
                    if(dis[i]>dis[t]+Matrix[t,i]&&vis[i]==false)
                    {
                        dis[i] = dis[t] + Matrix[t, i];
                        pre[i] = t;
                    }
                }
                //if (vis[prepoint] == true) break;
            }
            return pre;
        }
        private void initpanel()
        {
            double ratex = 700 / (maxx - minx);
            double ratey = 300 / (maxy - miny);
            Graphics g = panel1.CreateGraphics();//画线
            g.Clear(Color.White);
            for (int i = 0; i < n; i++)
            {
                pointarray[i].realx = (int)((pointarray[i].x - minx) * ratex) + 25;
                pointarray[i].realy = (int)((pointarray[i].y - miny) * ratey) + 20;
                g.FillEllipse(Brushes.Black, pointarray[i].realx, pointarray[i].realy, 5, 5);
                g.DrawString(i.ToString(), new Font("Arial", 6), new SolidBrush(Color.Red), new PointF(pointarray[i].realx, pointarray[i].realy + 5));
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Matrix[i, j] > 0 && Matrix[i, j] < double.PositiveInfinity)
                    {
                        Point StartPoint = new Point(pointarray[i].realx, pointarray[i].realy);
                        Point EndPoint = new Point(pointarray[j].realx, pointarray[j].realy);
                        g.DrawLine(new Pen(Brushes.Yellow, 2), StartPoint, EndPoint);
                    }
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            initpanel();
        }

        private void button1_Click(object sender, EventArgs e)//重置
        {
            initpanel();
        }

        private void button2_Click(object sender, EventArgs e)//计算
        {
            int[] pre = dijkstra();
            Graphics g = panel1.CreateGraphics();//画线
            int t = prepoint;
            while(true)
            {
                if (t == currentpoint) break;
                Point StartPoint = new Point(pointarray[t].realx, pointarray[t].realy);
                Point EndPoint = new Point(pointarray[pre[t]].realx, pointarray[pre[t]].realy);
                
                g.DrawLine(new Pen(Brushes.Black, 3), StartPoint, EndPoint);
                t = pre[t];
            }
        }

        private void ceshi_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            for(int i=0;i<n;i++)
            {
                if (System.Math.Abs(x - pointarray[i].realx) <= 10 && System.Math.Abs(y - pointarray[i].realy) <= 10)
                {
                    prepoint = currentpoint;
                    currentpoint = i;
                }
            }
        }
    }
}
