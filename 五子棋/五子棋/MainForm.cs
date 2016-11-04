/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2015/3/27
 * 时间: 16:02
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading;
using System.Linq;
using System.Media;

namespace 五子棋
{
	
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        PictureBox[,] wuziqiPictureBox = new PictureBox[15, 15];//新建一个15乘以15的PICTUREBOX
        int[,] victory = new int[15, 15];//用于判断胜负的二维数组，只能为0,1,2代表没下棋，白棋，黑棋
       
		public MainForm()
		{
			
//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
	int x,y;
	for(x=0;x<=14;x++)
		for(y=0;y<=14;y++)//画PICTUREBOX
	{
		wuziqiPictureBox[x,y]=new PictureBox();
		wuziqiPictureBox[x,y].Location=new Point(35+x*30,5+y*30);//左上角坐标
		wuziqiPictureBox[x,y].Size=new Size(30,30);//长宽
		wuziqiPictureBox[x,y].BackColor=Color.Transparent;
		wuziqiPictureBox[x,y].SizeMode=PictureBoxSizeMode.CenterImage;
		wuziqiPictureBox[x,y].Visible=false;
        
		panel1.Controls.Add(wuziqiPictureBox[x,y]);
	}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)//新建panel
		{
            
			label2.BackColor=Color.Transparent;
			
			panel1.BackColor=Color.Transparent;
			
            Pen pen=new Pen(Color. Blue,2);//定义画笔
			Graphics g=panel1.CreateGraphics();//画线
			int i,n,m;
			n=50;
			m=20;
			
			for(i=1;i<=15;i++)
			{
				g.DrawLine(pen,n,20,n,440);
			    n=n+30;
			}
				for(i=1;i<=15;i++)
			{
				g.DrawLine(pen,50,m,470,m);
			    m=m+30;
			}
			
			Pen pen1=new Pen(new SolidBrush(Color.Black),0.5f);
			Rectangle rg=new Rectangle(135,105,10,10);//定义矩形
			Rectangle rg1=new Rectangle(135,345,10,10);
			Rectangle rg2=new Rectangle(255,225,10,10);
			Rectangle rg3=new Rectangle(375,105,10,10);
			Rectangle rg4=new Rectangle(375,345,10,10);
			g.DrawEllipse(pen1,rg);//画椭圆
			g.DrawEllipse(pen1,rg1);
			g.DrawEllipse(pen1,rg2);
			g.DrawEllipse(pen1,rg3);
			g.DrawEllipse(pen1,rg4);
			g.FillEllipse (new SolidBrush (Color .Black) ,rg);//填充颜色
			g.FillEllipse (new SolidBrush (Color .Black) ,rg1);
			g.FillEllipse (new SolidBrush (Color .Black) ,rg2);
			g.FillEllipse (new SolidBrush (Color .Black) ,rg3);
			g.FillEllipse (new SolidBrush (Color .Black) ,rg4);
			g.Flush ();//清空缓存
		}
		
		void Button3Click(object sender, EventArgs e)//关闭
		{
			Application.Exit();
		}
        int i = 0;//控制谁先下棋，0代表黑棋，1代表白棋
        struct zuobiao { public
            int c, d;}//用于存储下棋的位置
        zuobiao[] xy = new zuobiao[300];//定义来存储下棋位置的数组
        int step=1;//记录步数
        int l=1;//控制函数开关
        void Button2Click(object sender, EventArgs e)//黑棋先
		{
			l=0;//控制是否可以落子，0时可以落子
			i=0;
			button2.Visible =false; 
			button4.Visible =false;
		}
		
		void Button4Click(object sender, EventArgs e)//白棋先
		{
			l=0;
			i=1;
			button4.Visible =false;
			button2.Visible =false; 
		}
		
		void Panel1MouseDown(object sender, MouseEventArgs e)
		{
			int r=30;//棋子宽度
			if(l==0){if(e.X>=485||e.X<35||e.Y<5||e.Y>=455)label2.Text="落子错误";//限定只能在棋盘内落子
			else{{
				int m=(int)((e.X-15)/30)*30+20-r/2;//获取横坐标
				int n=(int)((e.Y+45)/30)*30+35-r/2;//获取纵坐标
		    }
            int a, b;
            a = (e.X - 35) / 30;//把坐标值转换为数组的位置
            b = (e.Y - 5) / 30;
            
            int k;//判断胜负k=1就胜利
            if (i == 0)//下黑子
            {   
                wuziqiPictureBox[a, b].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\heiqi.png";
                wuziqiPictureBox[a, b].Visible = true;
                victory[a, b] = 1;//在victory数组中记录这个点下了黑子
                SoundPlayer music =new SoundPlayer(@"D:\五子棋\五子棋\tupian\棋子落下.wav");
                music.Play ();
                label2.Text="请白子下";
                for (int h = 1; h <= 1; h++)//判断胜负
                {
                    k = judge1(a, b); if (k == 1) {l=1; pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\黑棋win.jpg"; break; }
                    k = judge2(a, b); if (k == 1) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\黑棋win.jpg"; break; }
                    k = judge3(a, b); if (k == 1) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\黑棋win.jpg"; break; }
                    k = judge4(a, b); if (k == 1) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\黑棋win.jpg"; break; }
                    
                }
            
            }

            if (i == 1)//白棋下
            {
                wuziqiPictureBox[a, b].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\baiqi.png";
                wuziqiPictureBox[a, b].Visible = true;
                victory[a, b] = 2;
                label2.Text="请黑子下";
                SoundPlayer music1 =new SoundPlayer(@"D:\五子棋\五子棋\tupian\棋子落下.wav");
                music1.Play ();
                for (int h = 1; h <= 1; h++)
                {
                    k = judge1(a, b); if (k == 1) {l=1; pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge2(a, b); if (k == 1) {l=1; pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge3(a, b); if (k == 1) {l=1; pictureBox1.Visible = true;  pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge4(a, b); if (k == 1) {l=1; pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }

                }
            
            }


            if (i == 0) i = 1;//黑白子转换
            else i = 0;
            xy[step].c=a;xy[step].d=b;//记录这步下的位置
            step++;}}
	
	}

        private void huiqi_Click(object sender, EventArgs e)//悔棋
        {

        	if(l==0){if (step >= 1)//限制悔棋不能超出范围
            {
                step--;//回到上一步的操作
                wuziqiPictureBox[xy[step].c, xy[step].d].Visible = false;
                victory[xy[step].c, xy[step].d] = 0;
                if (i == 0){ i = 1;label2.Text="请白子下";}
                else {i = 0;label2.Text="请黑子下";}
                
        		}}
        }
        //判断胜负
        int judge1(int x,int y)
        {
            int p = 1, q, h, X, Y;
            q = victory[x, y];
            X = x; Y = y;
            for (h = 0; h <= 4; h++)
            {
                if (Y > 0 && Y <= 14)
                {
                    Y--;
                    if (victory[X, Y] == q) p++;
                    
                }
                else break;
                if (victory[X, Y] != q) break;
            }
            Y = y;
            for (h = 0; h <= 4; h++)
            {
                if (Y >= 0 && Y < 14)
                {
                    int c;
                    c = victory[X, Y];
                    Y++;
                    if (victory[X, Y] == q) p++;
                    
                 }
                else break;
                if (victory[X, Y] != q) break;
            }
            if (p >= 5) return 1;
            else return 0;
        }
        int judge2 (int x,int y)
        {
           int p = 1, q, h, X, Y;
            q = victory[x, y];
            X = x; Y = y;
            for (h = 0; h <= 4; h++)
            {
                if (X > 0 && X <= 14)
                {
                    X--;
                    if (victory[X, Y] == q) p++;
                   
                }
                else break;
                if (victory[X, Y] != q) break;
            }
            X = x;
            for (h = 0; h <= 4; h++)
            {
                if (X >= 0 && X < 14)
                {
                    X++;
                    if (victory[X, Y] == q) p++;
                  
                }
                else break;
                if (victory[X, Y] != q) break;
            }
            if (p >= 5) return 1;
            else return 0;
        }
        int judge3(int x,int y)
        {
           int p = 1, q, h, X, Y;
            q = victory[x, y];
            X = x; Y = y;
            for (h = 0; h <= 4; h++)
            {
                if (X > 0 && X <= 14 && Y > 0 && Y <= 14)
                {
                    X--;
                    Y--;
                    if (victory[X, Y] == q) p++;
                   
                }
                   
                else break;
                if (victory[X, Y] != q) break;
            }
            X = x; Y = y;
            for (h = 0; h <= 4; h++)
            {
                if (X >= 0 && X < 14 && Y >= 0 && Y < 14)
                {
                    X++;
                    Y++;
                    if (victory[X, Y] == q) p++;
                    
                }
                else break;
                if (victory[X, Y] != q) break;
            }
            if (p >= 5) return 1;
            else return 0;
        }
        int judge4(int x,int y)
        {
            int p = 1, q, h, X, Y;
            q = victory[x, y];
            X = x; Y = y;
            for (h = 0; h <= 4; h++)
            {
                if (X > 0 && X <= 14 && Y >= 0 && Y < 14)
                {
                    X--;
                    Y++;
                    if (victory[X, Y] == q) p++;
                   
                }
                else break;
                if (victory[X, Y] != q) break;
            }
            X = x; Y = y;
            for (h = 0; h <= 4; h++)
            {
                if (X >= 0 && X < 14 && Y > 0 && Y <= 14)
                {
                    X++;
                    Y--;
                    if (victory[X, Y] == q) p++;
                   
                }
                else break;
                if (victory[X, Y] != q) break;
            }
            if (p >= 5) return 1;
            else return 0;
        }
        
        private void kaishi_Click(object sender, EventArgs e)//开始按钮，判断谁先，清空数组
        {
            int p, q;
            button4 .Visible =true;
            button2 .Visible =true;
            pictureBox1.Visible = false;
            for (p = 0; p < 15; p++)
                for (q = 0; q < 15; q++)
                    victory[p, q] = 0;
            for (p = 0; p <15; p++)
                for (q = 0; q < 15; q++)
            wuziqiPictureBox[p, q].Visible = false;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
		
		void Button1Click(object sender, EventArgs e)//返回主界面
		{
			Form f=new Form1();
			this.Visible=false;
			f.Show();

		}
		
		void MainFormLoad(object sender, EventArgs e)//显示胜利的图片不可见
		{
			 pictureBox1.Visible=false;
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
}
}