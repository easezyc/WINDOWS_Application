using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 数独
{
    public partial class Form1 : Form
    {
        PictureBox[,] shuduPictureBox = new PictureBox[9, 9];
        public Form1()
        {
           
           
            InitializeComponent();
            int i, j;
            for(j=0;j<9;j++)
            {
                for(i=0;i<9;i++)
                {
                    shuduPictureBox[j,i]=new PictureBox();
                    shuduPictureBox[j,i].Location =new Point(j*40,i*40);
                    shuduPictureBox[j,i].Size =new Size (40,40);
                    shuduPictureBox[j,i].BackColor=Color.Transparent;
                    shuduPictureBox[j,i].SizeMode=PictureBoxSizeMode.CenterImage;
                    shuduPictureBox [j,i].Visible=false ;
                    panel1.Controls.Add(shuduPictureBox[j, i]);
                }
            }
        }
        
            int[,] answer = new int[9, 9];
            int[,] answer1 = new int[9, 9];
            int[,] fal = new int[9, 9];
            int[,] a=new int[9,9];
            int l=0;
            int step=1;
            struct zuobiao
            {
                public
                    int c, d;
           }
            zuobiao[] xy = new zuobiao[100];
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            Graphics g = panel1.CreateGraphics();
            int i, j, k;
            j = 0; k = 0;
            for (i = 0; i < 10; i++)
            {
                g.DrawLine(pen, j, 0, j, 360);
                j = j + 40;
            }
            for (i = 0; i < 10; i++)
            {
                g.DrawLine(pen, 0, k, 360, k);
                k = k + 40;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int i, j,k;
            for (j = 0; j < 9; j++)
                for (i = 0; i < 9;i++ )
                {
                    shuduPictureBox[j, i].Visible = false;
                }

                    for (j = 0; j < 9; j++)
                        for (i = 0; i < 9; i++)
                        {
                            answer[j, i] = a[j, i];
                            answer1[j, i] = 0;
                        }
            Random r = new Random();
            int x,y;
            for (k = 0; k < 9; k++)
            {
                x = r.Next() % 9 + 1; y = r.Next() % 9 + 1;
                while (y == x) y = r.Next() % 9 + 1;
                for (j = 0; j < 9; j++)
                {
                    for (i = 0; i < 9; i++)
                    {
                        if (answer[j, i] == x)
                        {
                            answer[j, i] = y;
                        }
                        else if (answer[j, i] == y)
                        {
                            answer[j, i] = x;
                        }
                    }
                }
            }
            for (j = 0; j < 9; j++)
                for (i = 0; i < 9; i++)
                {
                    fal[j, i] = answer[j, i];
                    
                }
           
            for(i=0;i<20;i++)
            {
                x = r.Next()%9; y = r.Next()%9;
                fal[x, y] = 0;
                answer1[x, y] = 0;
            }
            for(j=0;j<9;j++)
                for(i=0;i<9;i++)
                {
                    if (fal[j, i] == 1)
                    {
                        shuduPictureBox[j, i].ImageLocation = "D:\\数独\\数独\\图片\\1.gif";
                        shuduPictureBox[j, i].Visible = true;
                    }
                    if (fal[j, i] == 2)
                    {
                        shuduPictureBox[j, i].ImageLocation = "D:\\数独\\数独\\图片\\2.gif";
                        shuduPictureBox[j, i].Visible = true;
                    }
                    if (fal[j, i] == 3)
                    {
                        shuduPictureBox[j, i].ImageLocation = "D:\\数独\\数独\\图片\\3.gif";
                        shuduPictureBox[j, i].Visible = true;
                    }
                    if (fal[j, i] == 4)
                    {
                        shuduPictureBox[j, i].ImageLocation = "D:\\数独\\数独\\图片\\4.gif";
                        shuduPictureBox[j, i].Visible = true;
                    }
                    if (fal[j, i] == 5)
                    {
                        shuduPictureBox[j, i].ImageLocation = "D:\\数独\\数独\\图片\\5.gif";
                        shuduPictureBox[j, i].Visible = true;
                    }
                    if (fal[j, i] == 6)
                    {
                        shuduPictureBox[j, i].ImageLocation = "D:\\数独\\数独\\图片\\6.gif";
                        shuduPictureBox[j, i].Visible = true;
                    }
                    if (fal[j, i] == 7)
                    {
                        shuduPictureBox[j, i].ImageLocation = "D:\\数独\\数独\\图片\\7.gif";
                        shuduPictureBox[j, i].Visible = true;
                    }
                    if (fal[j, i] == 8)
                    {
                        shuduPictureBox[j, i].ImageLocation = "D:\\数独\\数独\\图片\\8.gif";
                        shuduPictureBox[j, i].Visible = true;
                    }
                    if (fal[j, i] == 9)
                    {
                        shuduPictureBox[j, i].ImageLocation = "D:\\数独\\数独\\图片\\9.gif";
                        shuduPictureBox[j, i].Visible = true;
                    }
                    l = 1;
                }
                    
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            int i, j;
            for (i = 0; i < 9; i++)
            {
                a[0, i] = i + 1;
            }
            for (j = 1; j < 3; j++)
                for (i = 0; i < 9; i++)
                {
                    if (a[j - 1, i] <7) a[j, i] = a[j - 1, i] + 3;
                    else if (a[j - 1, i] == 7) a[j , i] = 1;
                    else if (a[j - 1, i] == 8) a[j, i] = 2;
                    else if (a[j - 1, i] == 9) a[j, i] = 3;
                }
            for (j = 3; j < 9; j++)
                for (i = 0; i < 9;i++ )
                {
                    if (a[j - 3, i] < 9) a[j, i] = a[j - 3, i] + 1;
                    else if (a[j - 3, i] == 9) a[j, i] = 1;
                }
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            float p;
            if (l == 0) label1.Text = "请按开始";
            else
            {
                int m=e.X/40;
                int n=e.Y/40;
                if (m >= 0 && m < 9 && n >= 0 && n < 9)
                {
                    if (textBox1.Text == "") textBox1.Text = "0";
                    p = Convert.ToSingle(textBox1.Text);
                    if (p == 0) label1.Text = "请输入数字";
                    else
                    {
                        label1.Text = "";
                        xy[step].c = m;
                        xy[step].d = n;
                        step++;
                        if (answer1[m, n] == 0)
                        {
                            if (p == 1)
                            {
                                shuduPictureBox[m, n].ImageLocation = "D://数独//数独//图片//一.gif";
                                shuduPictureBox[m, n].Visible = true;
                                fal[m, n] = 1;
                            }
                            if (p == 2)
                            {
                                shuduPictureBox[m, n].ImageLocation = "D://数独//数独//图片//二.gif";
                                shuduPictureBox[m, n].Visible = true;
                                fal[m, n] = 2;
                            }
                            if (p == 3)
                            {
                                shuduPictureBox[m, n].ImageLocation = "D://数独//数独//图片//三.gif";
                                shuduPictureBox[m, n].Visible = true;
                                fal[m, n] = 3;
                            }
                            if (p == 4)
                            {
                                shuduPictureBox[m, n].ImageLocation = "D://数独//数独//图片//四.gif";
                                shuduPictureBox[m, n].Visible = true;
                                fal[m, n] = 4;
                            }
                            if (p == 5)
                            {
                                shuduPictureBox[m, n].ImageLocation = "D://数独//数独//图片//五.gif";
                                shuduPictureBox[m, n].Visible = true;
                                fal[m, n] = 5;
                            }
                            if (p == 6)
                            {
                                shuduPictureBox[m, n].ImageLocation = "D://数独//数独//图片//六.gif";
                                shuduPictureBox[m, n].Visible = true;
                                fal[m, n] = 6;
                            }
                            if (p == 7)
                            {
                                shuduPictureBox[m, n].ImageLocation = "D://数独//数独//图片//七.gif";
                                shuduPictureBox[m, n].Visible = true;
                                fal[m, n] = 7;
                            }
                            if (p == 8)
                            {
                                shuduPictureBox[m, n].ImageLocation = "D://数独//数独//图片//八.gif";
                                shuduPictureBox[m, n].Visible = true;
                                fal[m, n] = 8;
                            }
                            if (p == 9)
                            {
                                shuduPictureBox[m, n].ImageLocation = "D://数独//数独//图片//九.gif";
                                shuduPictureBox[m, n].Visible = true;
                                fal[m, n] = 9;
                            }
                        }
                    }
                    if (judge() == 1) label1.Text = "成功";
                }
            }
        }
        int judge()
        {
            int  i, j, k, o=0,t=0;
            int[] u = new int[9];
            for(k=1;k<=9;k++)
                for(j=0;j<9;j++)
                    for(i=0;i<9;i++)
                    {
                        if (fal[j, i] == k) { o++; break; }
                    }
            for (k = 1; k <= 9; k++)
                for (j = 0; j < 9; j++)
                    for (i = 0; i < 9; i++)
                    {
                        if (fal[i, j] == k) { o++; break; }
                    }
            

            for (j = 0; j < 3; j++)
                for (i = 0; i < 3;i++ )
                {
                    u[t] = fal[j, i];
                    t++;
                }
            for (k = 1; k <= 9; k++)
                for (i = 0; i < 9;i++ )
                    if (u[i] == k) { o++; break; }
            t = 0;

            for (j = 0; j < 3; j++)
                for (i = 3; i < 6; i++)
                {
                    u[t] = fal[j, i];
                    t++;
                }
            for (k = 1; k <= 9; k++)
                for (i = 0; i < 9; i++)
                    if (u[i] == k) { o++; break; }
            t = 0;

            for (j = 0; j < 3; j++)
                for (i = 6; i < 9; i++)
                {
                    u[t] = fal[j, i];
                    t++;
                }
            for (k = 1; k <= 9; k++)
                for (i = 0; i < 9; i++)
                    if (u[i] == k) { o++; break; }
            t = 0;

            for (j = 3; j < 6; j++)
                for (i = 0; i < 3; i++)
                {
                    u[t] = fal[j, i];
                    t++;
                }
            for (k = 1; k <= 9; k++)
                for (i = 0; i < 9; i++)
                    if (u[i] == k) { o++; break; }
            t = 0;

            for (j = 3; j < 6; j++)
                for (i = 3; i < 6; i++)
                {
                    u[t] = fal[j, i];
                    t++;
                }
            for (k = 1; k <= 9; k++)
                for (i = 0; i < 9; i++)
                    if (u[i] == k) { o++; break; }
            t = 0;

            for (j = 3; j < 6; j++)
                for (i = 6; i < 9; i++)
                {
                    u[t] = fal[j, i];
                    t++;
                }
            for (k = 1; k <= 9; k++)
                for (i = 0; i < 9; i++)
                    if (u[i] == k) { o++; break; }
            t = 0;

            for (j = 6; j < 9; j++)
                for (i = 0; i < 3; i++)
                {
                    u[t] = fal[j, i];
                    t++;
                }
            for (k = 1; k <= 9; k++)
                for (i = 0; i < 9; i++)
                    if (u[i] == k) { o++; break; }
            t = 0;

            for (j = 6; j < 9; j++)
                for (i = 3; i < 6; i++)
                {
                    u[t] = fal[j, i];
                    t++;
                }
            for (k = 1; k <= 9; k++)
                for (i = 0; i < 9; i++)
                    if (u[i] == k) { o++; break; }
            t = 0;

            for (j = 6; j < 9; j++)
                for (i = 6; i < 9; i++)
                {
                    u[t] = fal[j, i];
                    t++;
                }
            for (k = 1; k <= 9; k++)
                for (i = 0; i < 9; i++)
                    if (u[i] == k) { o++; break; }
            t = 0;

                    if (o == 243) return 1;
                    else return 0;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form g=new Form3();
            this.Visible=false;
            g.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(step>1)
            {
                step--;
                shuduPictureBox[xy[step].c, xy[step].d].Visible = false;
                fal[xy[step].c, xy[step].d] = 0;
            }
        }
        
    }
}
