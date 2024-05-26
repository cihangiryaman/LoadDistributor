namespace LoadPlacer.UI.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			button1 = new Button();
			label1 = new Label();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(713, 58);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(336, 284);
			textBox1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(803, 371);
			button1.Name = "button1";
			button1.Size = new Size(163, 63);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label1.Location = new Point(718, 25);
			label1.Name = "label1";
			label1.Size = new Size(70, 28);
			label1.TabIndex = 2;
			label1.Text = "Yükler:";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1088, 513);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Name = "MainForm";
			Text = "MainForm";
			Load += MainForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Button button1;
		private Label label1;
	}
}