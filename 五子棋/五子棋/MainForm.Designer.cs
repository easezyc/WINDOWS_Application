/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2015/3/27
 * 时间: 16:02
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 五子棋
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.kaishi = new System.Windows.Forms.Button();
			this.huiqi = new System.Windows.Forms.Button();
			this.jieshu = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(19, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(521, 486);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseDown);
			// 
			// button4
			// 
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button4.Location = new System.Drawing.Point(172, 220);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(154, 74);
			this.button4.TabIndex = 3;
			this.button4.Text = "白棋先";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Visible = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(172, 113);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(154, 76);
			this.button2.TabIndex = 1;
			this.button2.Text = "黑棋先";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(114, 121);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(276, 260);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// kaishi
			// 
			this.kaishi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kaishi.BackgroundImage")));
			this.kaishi.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.kaishi.Location = new System.Drawing.Point(550, 28);
			this.kaishi.Name = "kaishi";
			this.kaishi.Size = new System.Drawing.Size(114, 41);
			this.kaishi.TabIndex = 1;
			this.kaishi.Text = "开始";
			this.kaishi.UseVisualStyleBackColor = true;
			this.kaishi.Click += new System.EventHandler(this.kaishi_Click);
			// 
			// huiqi
			// 
			this.huiqi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("huiqi.BackgroundImage")));
			this.huiqi.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.huiqi.Location = new System.Drawing.Point(550, 89);
			this.huiqi.Name = "huiqi";
			this.huiqi.Size = new System.Drawing.Size(114, 45);
			this.huiqi.TabIndex = 2;
			this.huiqi.Text = "悔棋";
			this.huiqi.UseVisualStyleBackColor = true;
			this.huiqi.Click += new System.EventHandler(this.huiqi_Click);
			// 
			// jieshu
			// 
			this.jieshu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jieshu.BackgroundImage")));
			this.jieshu.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.jieshu.Location = new System.Drawing.Point(550, 217);
			this.jieshu.Name = "jieshu";
			this.jieshu.Size = new System.Drawing.Size(114, 41);
			this.jieshu.TabIndex = 3;
			this.jieshu.Text = "结束";
			this.jieshu.UseVisualStyleBackColor = true;
			this.jieshu.Click += new System.EventHandler(this.Button3Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(550, 301);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 55);
			this.label2.TabIndex = 4;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(550, 151);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 47);
			this.button1.TabIndex = 5;
			this.button1.Text = "返回";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(676, 503);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.jieshu);
			this.Controls.Add(this.huiqi);
			this.Controls.Add(this.kaishi);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "五子棋";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button jieshu;
		private System.Windows.Forms.Button huiqi;
		private System.Windows.Forms.Button kaishi;
        private System.Windows.Forms.Panel panel1;
	}
}
