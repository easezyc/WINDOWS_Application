/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2015/4/3
 * 时间: 14:31
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 五子棋
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)//打开人人对战
		{
			Form g=new MainForm();
			this.Visible=false;
			g.Show();

		}
		
		void Button3Click(object sender, EventArgs e)//关闭
		{
			Close();
		}
		
		void Button2Click(object sender, EventArgs e)//打开人机对战
		{
			Form h=new Form2();
			this.Visible=false;
			h.Show();
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
	}
}
