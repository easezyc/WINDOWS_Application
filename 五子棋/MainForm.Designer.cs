/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2015/3/20
 * 时间: 14:45
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
			this.开始 = new System.Windows.Forms.Button();
			this.悔棋 = new System.Windows.Forms.Button();
			this.结束 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// 开始
			// 
			this.开始.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("开始.BackgroundImage")));
			this.开始.Font = new System.Drawing.Font("微软雅黑", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.开始.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.开始.Location = new System.Drawing.Point(587, 25);
			this.开始.Name = "开始";
			this.开始.Size = new System.Drawing.Size(95, 37);
			this.开始.TabIndex = 0;
			this.开始.Text = "开始";
			this.开始.UseVisualStyleBackColor = true;
			this.开始.Click += new System.EventHandler(this.开始Click);
			// 
			// 悔棋
			// 
			this.悔棋.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("悔棋.BackgroundImage")));
			this.悔棋.Font = new System.Drawing.Font("微软雅黑", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.悔棋.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.悔棋.Location = new System.Drawing.Point(587, 91);
			this.悔棋.Name = "悔棋";
			this.悔棋.Size = new System.Drawing.Size(95, 40);
			this.悔棋.TabIndex = 1;
			this.悔棋.Text = "悔棋";
			this.悔棋.UseVisualStyleBackColor = true;
			// 
			// 结束
			// 
			this.结束.Font = new System.Drawing.Font("微软雅黑", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.结束.Location = new System.Drawing.Point(587, 157);
			this.结束.Name = "结束";
			this.结束.Size = new System.Drawing.Size(95, 38);
			this.结束.TabIndex = 2;
			this.结束.Text = "结束";
			this.结束.UseVisualStyleBackColor = true;
			this.结束.Click += new System.EventHandler(this.结束Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(694, 484);
			this.ControlBox = false;
			this.Controls.Add(this.结束);
			this.Controls.Add(this.悔棋);
			this.Controls.Add(this.开始);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "五子棋";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button 结束;
		private System.Windows.Forms.Button 悔棋;
		private System.Windows.Forms.Button 开始;
	}
}
