/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2015/4/3
 * 时间: 14:52
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 五子棋
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.kaishi = new System.Windows.Forms.Button();
			this.huiqi = new System.Windows.Forms.Button();
			this.fanhui = new System.Windows.Forms.Button();
			this.jieshu = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(22, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(500, 454);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(99, 94);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(276, 258);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// kaishi
			// 
			this.kaishi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kaishi.BackgroundImage")));
			this.kaishi.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.kaishi.Location = new System.Drawing.Point(539, 12);
			this.kaishi.Name = "kaishi";
			this.kaishi.Size = new System.Drawing.Size(107, 44);
			this.kaishi.TabIndex = 1;
			this.kaishi.Text = "开始";
			this.kaishi.UseVisualStyleBackColor = true;
			this.kaishi.Click += new System.EventHandler(this.Button1Click);
			// 
			// huiqi
			// 
			this.huiqi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("huiqi.BackgroundImage")));
			this.huiqi.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.huiqi.Location = new System.Drawing.Point(539, 79);
			this.huiqi.Name = "huiqi";
			this.huiqi.Size = new System.Drawing.Size(107, 45);
			this.huiqi.TabIndex = 2;
			this.huiqi.Text = "悔棋";
			this.huiqi.UseVisualStyleBackColor = true;
			this.huiqi.Click += new System.EventHandler(this.Button2Click);
			// 
			// fanhui
			// 
			this.fanhui.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fanhui.BackgroundImage")));
			this.fanhui.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.fanhui.Location = new System.Drawing.Point(539, 139);
			this.fanhui.Name = "fanhui";
			this.fanhui.Size = new System.Drawing.Size(107, 42);
			this.fanhui.TabIndex = 3;
			this.fanhui.Text = "返回";
			this.fanhui.UseVisualStyleBackColor = true;
			this.fanhui.Click += new System.EventHandler(this.Button3Click);
			// 
			// jieshu
			// 
			this.jieshu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jieshu.BackgroundImage")));
			this.jieshu.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.jieshu.Location = new System.Drawing.Point(539, 201);
			this.jieshu.Name = "jieshu";
			this.jieshu.Size = new System.Drawing.Size(107, 48);
			this.jieshu.TabIndex = 4;
			this.jieshu.Text = "结束";
			this.jieshu.UseVisualStyleBackColor = true;
			this.jieshu.Click += new System.EventHandler(this.Button4Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(539, 265);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 44);
			this.label2.TabIndex = 5;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(687, 497);
			this.ControlBox = false;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.jieshu);
			this.Controls.Add(this.fanhui);
			this.Controls.Add(this.huiqi);
			this.Controls.Add(this.kaishi);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button jieshu;
		private System.Windows.Forms.Button fanhui;
		private System.Windows.Forms.Button huiqi;
		private System.Windows.Forms.Button kaishi;
		private System.Windows.Forms.Panel panel1;
		
		void Button2Click(object sender, System.EventArgs e)
		{
			if(l==0){if (step >= 1)
            {
                step--;
                wuziqiPictureBox[xy[step].c, xy[step].d].Visible = false;
                victory[xy[step].c, xy[step].d] = 0;
                if (i == 0) i = 1;
                else i = 0;
                step--;
                wuziqiPictureBox[xy[step].c, xy[step].d].Visible = false;
                victory[xy[step].c, xy[step].d] = 0;
                if (i == 0) i = 1;
                else i = 0;
            }
			}}
	}
}
