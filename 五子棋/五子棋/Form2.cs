/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2015/4/3
 * 时间: 14:52
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
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		PictureBox[,] wuziqiPictureBox = new PictureBox[15, 15];//新建PICTUREBOX
        int[,] victory = new int[15, 15];//判断胜负的数组
		public Form2()
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
		wuziqiPictureBox[x,y].Location=new Point(35+x*30,5+y*30);
		wuziqiPictureBox[x,y].Size=new Size(30,30);
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
            Pen pen=new Pen(Color. Blue,2);
			Graphics g=panel1.CreateGraphics();
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
				Graphics k=panel1.CreateGraphics();
			Pen pen1=new Pen(new SolidBrush(Color.Black),0.5f);
			Rectangle rg=new Rectangle(135,105,10,10);
			Rectangle rg1=new Rectangle(135,345,10,10);
			Rectangle rg2=new Rectangle(255,225,10,10);
			Rectangle rg3=new Rectangle(375,105,10,10);
			Rectangle rg4=new Rectangle(375,345,10,10);
			k.DrawEllipse(pen1,rg);
			k.DrawEllipse(pen1,rg1);
			k.DrawEllipse(pen1,rg2);
			k.DrawEllipse(pen1,rg3);
			k.DrawEllipse(pen1,rg4);
			k.FillEllipse (new SolidBrush (Color .Black) ,rg);
			k.FillEllipse (new SolidBrush (Color .Black) ,rg1);
			k.FillEllipse (new SolidBrush (Color .Black) ,rg2);
			k.FillEllipse (new SolidBrush (Color .Black) ,rg3);
			k.FillEllipse (new SolidBrush (Color .Black) ,rg4);
			k.Flush ();
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
            return p;
            
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
            return p;
            
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
            return p;
            
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
            return p;
            
        }
		int i = 0;
        struct zuobiao { public
            int c, d;}
        zuobiao[] xy = new zuobiao[300];
        int step=1;
        int l=1;
		void Panel1MouseDown(object sender, MouseEventArgs e)
		{
			int r=30;
			if(l==0){if(e.X>=485||e.X<35||e.Y<5||e.Y>=455)label2.Text="落子错误";
			else{{
				int m=(int)((e.X-15)/30)*30+20-r/2;
				int n=(int)((e.Y+45)/30)*30+35-r/2;
		    }
            int a, b;
            a = (e.X - 35) / 30;
            b = (e.Y - 5) / 30;
            
            int k;
            if (i == 0)
            {
                wuziqiPictureBox[a, b].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\heiqi.png";
                wuziqiPictureBox[a, b].Visible = true;
                victory[a, b] = 1;
                label2.Text="请白子下"; SoundPlayer music =new SoundPlayer(@"D:\五子棋\五子棋\tupian\棋子落下.wav");music.Play ();
                for (int h = 1; h <= 1; h++)
                {
                    k = judge1(a, b); if (k >= 5) { l=1; pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\黑棋win.jpg";; break; }
                    k = judge2(a, b); if (k >= 5) { l=1; pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\黑棋win.jpg"; break; }
                    k = judge3(a, b); if (k >= 5) { l=1; pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\黑棋win.jpg"; break; }
                    k = judge4(a, b); if (k >= 5) { l=1; pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\黑棋win.jpg";break; }
                }
        
            i=1;
            xy[step].c=a;xy[step].d=b;
            step++;
            }

                           int jiqi=0;//
                jiqi=renji(a,b);
                if(jiqi==1){wuziqiPictureBox[a+1, b+1].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\baiqi.png";
            	
                wuziqiPictureBox[a+1, b+1].Visible = true;
                victory[a+1, b+1] = 2;
                label2.Text="请黑子下"; SoundPlayer music =new SoundPlayer(@"D:\五子棋\五子棋\tupian\棋子落下.wav");music.Play ();
                for (int h = 1; h <= 1; h++)
                {
                    k = judge1(a+1, b+1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge2(a+1, b+1); if (k >= 5)  { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge3(a+1, b+1); if (k >= 5)  { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge4(a+1, b+1); if (k >= 5)  { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
			    }
                i=0;
                xy[step].c=a+1;xy[step].d=b+1;
            step++;}
                if(jiqi==2){wuziqiPictureBox[a+1, b].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\baiqi.png";
            	
                wuziqiPictureBox[a+1, b].Visible = true;
                victory[a+1, b] = 2;
                label2.Text="请黑子下"; SoundPlayer music =new SoundPlayer(@"D:\五子棋\五子棋\tupian\棋子落下.wav");music.Play ();
                for (int h = 1; h <= 1; h++)
                {
                    k = judge1(a+1, b); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge2(a+1, b); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge3(a+1, b); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge4(a+1, b); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
					
                }i=0;
                xy[step].c=a+1;xy[step].d=b;
            step++;}
                if(jiqi==3){wuziqiPictureBox[a+1, b-1].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\baiqi.png";
            	
                wuziqiPictureBox[a+1, b-1].Visible = true;
                victory[a+1, b-1] = 2;
                label2.Text="请黑子下"; SoundPlayer music =new SoundPlayer(@"D:\五子棋\五子棋\tupian\棋子落下.wav");music.Play ();
                for (int h = 1; h <= 1; h++)
                {
                    k = judge1(a+1, b-1); if (k >= 5) {l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge2(a+1, b-1); if (k >= 5) {l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge3(a+1, b-1); if (k >= 5) {l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge4(a+1, b-1); if (k >= 5) {l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
						
                }i=0;
                xy[step].c=a+1;xy[step].d=b-1;
            step++;}
                 if(jiqi==4){wuziqiPictureBox[a, b+1].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\baiqi.png";
            	
                wuziqiPictureBox[a, b+1].Visible = true;
                victory[a, b+1] = 2;
                label2.Text="请黑子下"; SoundPlayer music =new SoundPlayer(@"D:\五子棋\五子棋\tupian\棋子落下.wav");music.Play ();
                //人机判断下在哪
                for (int h = 1; h <= 1; h++)
                {
                    k = judge1(a, b+1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge2(a, b+1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge3(a, b+1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge4(a, b+1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
					
                }i=0;
                xy[step].c=a;xy[step].d=b+1;
            step++;}
                 if(jiqi==5){wuziqiPictureBox[a-1, b+1].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\baiqi.png";
            	
                wuziqiPictureBox[a-1, b+1].Visible = true;
                victory[a-1, b+1] = 2;
                label2.Text="请黑子下"; SoundPlayer music =new SoundPlayer(@"D:\五子棋\五子棋\tupian\棋子落下.wav");music.Play ();
                for (int h = 1; h <= 1; h++)
                {
                    k = judge1(a-1, b+1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge2(a-1, b+1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge3(a-1, b+1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge4(a-1, b+1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
					
                }i=0;
                xy[step].c=a-1;xy[step].d=b+1;
            step++;}
                if(jiqi==6){wuziqiPictureBox[a-1, b-1].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\baiqi.png";
            	
                wuziqiPictureBox[a-1, b-1].Visible = true;
                victory[a-1, b-1] = 2;
                label2.Text="请黑子下"; SoundPlayer music =new SoundPlayer(@"D:\五子棋\五子棋\tupian\棋子落下.wav");music.Play ();
                for (int h = 1; h <= 1; h++)
                {
                    k = judge1(a-1, b-1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge2(a-1, b-1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge3(a-1, b-1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge4(a-1, b-1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
					
                }i=0;
                xy[step].c=a-1;xy[step].d=b-1;
            step++;}
                if(jiqi==7){wuziqiPictureBox[a-1, b].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\baiqi.png";
            	
                wuziqiPictureBox[a-1, b].Visible = true;
                victory[a-1, b] = 2;
                label2.Text="请黑子下"; SoundPlayer music =new SoundPlayer(@"D:\五子棋\五子棋\tupian\棋子落下.wav");music.Play ();
                for (int h = 1; h <= 1; h++)
                {
                    k = judge1(a-1, b); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge2(a-1, b); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge3(a-1, b); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge4(a-1, b); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                   
                }i=0;
                xy[step].c=a-1;xy[step].d=b;
            step++;}
                 if(jiqi==8){wuziqiPictureBox[a, b-1].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\baiqi.png";
            	
                wuziqiPictureBox[a, b-1].Visible = true;
                victory[a, b-1] = 2;
                label2.Text="请黑子下"; SoundPlayer music =new SoundPlayer(@"D:\五子棋\五子棋\tupian\棋子落下.wav");music.Play ();
                for (int h = 1; h <= 1; h++)
                {
                    k = judge1(a, b-1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge2(a, b-1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge3(a, b-1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                    k = judge4(a, b-1); if (k >= 5) { l=1;pictureBox1.Visible = true; pictureBox1.ImageLocation="D:\\五子棋\\五子棋\\tupian\\白棋win.jpg"; break; }
                   	
                }i=0;
                xy[step].c=a;xy[step].d=b-1;
            step++;}
                if(jiqi==0){
                	int q,o,jilu=0;
                	for(q=(a-2);q<=(a+2);q++)
                	{
                		for( o=(b-2);o<=(b+2);o++)
                			if(o>=0&&o<=14&&q>=0&&q<=14){
                			if(victory[q,o]==0){
                			wuziqiPictureBox[q, o].ImageLocation = "D:\\五子棋\\五子棋\\tupian\\baiqi.png";
            	            wuziqiPictureBox[q, o].Visible = true;
                            victory[q, o] = 2;xy[step].c=q;xy[step].d=o;
                            step++;jilu=1;i=0;break;
                			}}
                		if(jilu==1)break;
                	}
                	jilu=0;
                }
            }
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form f=new Form1();
			this.Visible=false;
			f.Show();
		}
		int renji(int x,int y)//人机判断每个位置的分数
		{
			int max,middle,b1,b2,b3,b4,i,j=0;
			int[] bajiao=new int[9];
			if((x+1)<15&&(y+1)<15){if(victory[x+1,y+1]==0){   victory[x+1,y+1]=1;
				b1=judge1 (x+1,y+1);
			b2=judge2(x+1,y+1);
			b3=judge3(x+1,y+1);
			b4=judge4(x+1,y+1);
			middle=b1;
			if(middle<b2)middle=b2;
			if(middle<b3)middle=b3;
			if(middle<b4)middle=b4;
			bajiao[1]=middle;
			middle=0;
			victory[x+1,y+1]=0;}}
			
			if((x+1)<15&&y<15&&(x+1)>=0&&y>=0){if(victory[x+1,y]==0){victory[x+1,y]=1;
				b1=judge1 (x+1,y);
			    b2=judge2(x+1,y);
			    b3=judge3(x+1,y);
			    b4=judge4(x+1,y);
			middle=b1;
			if(middle<b2)middle=b2;
			if(middle<b3)middle=b3;
			if(middle<b4)middle=b4;
			bajiao[2]=middle;
			middle=0;
			victory[x+1,y]=0;}}
			
			if((x+1)<15&&(y-1)<15&&(x+1)>=0&&(y-1)>=0){if(victory[x+1,y-1]==0){
				victory[x+1,y-1]=1;
				b1=judge1 (x+1,y-1);
			    b2=judge2(x+1,y-1);
			    b3=judge3(x+1,y-1);
			    b4=judge4(x+1,y-1);
			middle=b1;
			if(middle<b2)middle=b2;
			if(middle<b3)middle=b3;
			if(middle<b4)middle=b4;
			bajiao[3]=middle;
			middle=0;
			victory[x+1,y-1]=0;
			                          }}
			if((x)<15&&(y+1)<15&&(x)>=0&&(y+1)>=0){if(victory[x,y+1]==0){victory[x,y+1]=1;
				b1=judge1 (x,y+1);
			b2=judge2(x,y+1);
			b3=judge3(x,y+1);
			b4=judge4(x,y+1);
			middle=b1;
			if(middle<b2)middle=b2;
			if(middle<b3)middle=b3;
			if(middle<b4)middle=b4;
			bajiao[4]=middle;
			middle=0;
			victory[x,y+1]=0;}}
			if((x-1)<15&&(y+1)<15&&(x-1)>=0&&(y+1)>=0){if(victory[x-1,y+1]==0){victory[x-1,y+1]=1;
				b1=judge1 (x-1,y+1);
			b2=judge2(x-1,y+1);
			b3=judge3(x-1,y+1);
			b4=judge4(x-1,y+1);
			middle=b1;
			if(middle<b2)middle=b2;
			if(middle<b3)middle=b3;
			if(middle<b4)middle=b4;
			bajiao[5]=middle;
			middle=0;
			victory[x-1,y+1]=0;}}
			if((x-1)<15&&(y-1)<15&&(x-1)>=0&&(y-1)>=0){if(victory[x-1,y-1]==0){victory[x-1,y-1]=1;
				b1=judge1 (x-1,y-1);
			b2=judge2(x-1,y-1);
			b3=judge3(x-1,y-1);
			b4=judge4(x-1,y-1);
			middle=b1;
			if(middle<b2)middle=b2;
			if(middle<b3)middle=b3;
			if(middle<b4)middle=b4;
			bajiao[6]=middle;
			middle=0;
			victory[x-1,y-1]=0;}}
			if((x-1)<15&&(y)<15&&(x-1)>=0&&(y)>=0){if(victory[x-1,y]==0){
				victory[x-1,y]=1;
				b1=judge1 (x-1,y);
			b2=judge2(x-1,y);
			b3=judge3(x-1,y);
			b4=judge4(x-1,y);
			middle=b1;
			if(middle<b2)middle=b2;
			if(middle<b3)middle=b3;
			if(middle<b4)middle=b4;
			bajiao[7]=middle;
			middle=0;
			victory[x-1,y]=0;}}
			if((x)<15&&(y-1)<15&&(x)>=0&&(y-1)>=0){if(victory[x,y-1]==0){victory[x,y-1]=1;
				b1=judge1 (x,y-1);
			b2=judge2(x,y-1);
			b3=judge3(x,y-1);
			b4=judge4(x,y-1);
			middle=b1;
			if(middle<b2)middle=b2;
			if(middle<b3)middle=b3;
			if(middle<b4)middle=b4;
			bajiao[8]=middle;
			middle=0;
			victory[x,y-1]=0;}}
			max=0;
			for(i=1;i<=8;i++)
			{
				if(max<bajiao[i]){max=bajiao[i];j=i;}
			}
			return j;
		}
		void Button4Click(object sender, EventArgs e)//关闭
		{
			Close();
		}
		
		void Button1Click(object sender, EventArgs e)//开始按钮
		{
			pictureBox1.Visible=false;
			int p, q;
			l=0;
            
            for (p = 0; p < 15; p++)
                for (q = 0; q < 15; q++)
                    victory[p, q] = 0;
            for (p = 0; p <15; p++)
                for (q = 0; q < 15; q++)
                    wuziqiPictureBox[p, q].Visible = false;
		}
		
		void Form2Load(object sender, EventArgs e)//胜利的图片不可见
		{
			pictureBox1.Visible=false;
		}
	}
}
