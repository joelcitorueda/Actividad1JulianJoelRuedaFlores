namespace SistemaComputador.VISTA.ComputadoraVista
{
	partial class ComputadoraInsertarVista
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
			button1 = new Button();
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			button2 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(179, 367);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 0;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(73, 109);
			label1.Name = "label1";
			label1.Size = new Size(70, 20);
			label1.TabIndex = 1;
			label1.Text = "NOMBRE";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(247, 106);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(208, 27);
			textBox1.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(73, 163);
			label2.Name = "label2";
			label2.Size = new Size(101, 20);
			label2.TabIndex = 3;
			label2.Text = "DESCRIPCION";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(73, 230);
			label3.Name = "label3";
			label3.Size = new Size(58, 20);
			label3.TabIndex = 4;
			label3.Text = "PRECIO";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(73, 293);
			label4.Name = "label4";
			label4.Size = new Size(150, 20);
			label4.TabIndex = 5;
			label4.Text = "FECHA FABRICACION";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(247, 160);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(208, 27);
			textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(247, 230);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(208, 27);
			textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(247, 290);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(208, 27);
			textBox4.TabIndex = 8;
			// 
			// button2
			// 
			button2.Location = new Point(334, 367);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 9;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// ComputadoraInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(551, 450);
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
			Name = "ComputadoraInsertarVista";
			Text = "ComputadoraInsertarVista";
			Load += ComputadoraInsertarVista_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private Button button2;
	}
}