/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2015/3/20
 * 时间: 14:45
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace 五子棋
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void 开始Click(object sender, EventArgs e)
		{
			
		}
		

		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void MainFormPaint(object sender, PaintEventArgs e)
		{
			Pen pen=new Pen(Color. Blue,2);
			Graphics g=this.CreateGraphics();
			int i,n,m;
			n=50;
			m=20;
			
			for(i=1;i<=16;i++)
			{
				g.DrawLine(pen,n,20,n,470);
			    n=n+30;
			}
				for(i=1;i<=16;i++)
			{
				g.DrawLine(pen,50,m,500,m);
			    m=m+30;
			}
		}
		

		void MainFormMouseDown(object sender, MouseEventArgs e)
		{
			
		}
		
		
		void 结束Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
