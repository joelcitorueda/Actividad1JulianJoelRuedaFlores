namespace SistemaComputador.VISTA.ComputadoraVista
{
	partial class ComputadoraEditarVista
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
			button2 = new Button();
			textBox4 = new TextBox();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			textBox1 = new TextBox();
			label1 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(330, 328);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 19;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(243, 251);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(208, 27);
			textBox4.TabIndex = 18;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(243, 191);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(208, 27);
			textBox3.TabIndex = 17;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(243, 121);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(208, 27);
			textBox2.TabIndex = 16;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(69, 254);
			label4.Name = "label4";
			label4.Size = new Size(150, 20);
			label4.TabIndex = 15;
			label4.Text = "FECHA FABRICACION";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(69, 191);
			label3.Name = "label3";
			label3.Size = new Size(58, 20);
			label3.TabIndex = 14;
			label3.Text = "PRECIO";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(69, 124);
			label2.Name = "label2";
			label2.Size = new Size(101, 20);
			label2.TabIndex = 13;
			label2.Text = "DESCRIPCION";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(243, 67);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(208, 27);
			textBox1.TabIndex = 12;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(69, 70);
			label1.Name = "label1";
			label1.Size = new Size(70, 20);
			label1.TabIndex = 11;
			label1.Text = "NOMBRE";
			// 
			// button1
			// 
			button1.Location = new Point(175, 328);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 10;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// ComputadoraEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(560, 414);
			Controls.Add(button2);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "ComputadoraEditarVista";
			Text = "ComputadoraEditarVista";
			Load += ComputadoraEditarVista_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private TextBox textBox4;
		private TextBox textBox3;
		private TextBox textBox2;
		private Label label4;
		private Label label3;
		private Label label2;
		private TextBox textBox1;
		private Label label1;
		private Button button1;
	}
}