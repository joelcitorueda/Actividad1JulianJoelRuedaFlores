﻿using SistemaComputadora.MODELOS;
using SistemaComputadora.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaComputador.VISTA.ComputadoraVista
{
	public partial class ComputadoraInsertarVista : Form
	{
		public ComputadoraInsertarVista()
		{
			InitializeComponent();
		}
		ComputadoraBss bss = new ComputadoraBss();
		private void ComputadoraInsertarVista_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Computadora c = new Computadora();
			c.Nombre = textBox1.Text;
			c.Descripcion = textBox2.Text;
			c.Precio = Convert.ToDecimal(textBox3.Text); 
			c.FechaFabricacion = DateTime.Now; 
			

			bss.InsertarComputadoraBss(c);
			MessageBox.Show("Se guardó correctamente la computadora");

		}
	}
}
