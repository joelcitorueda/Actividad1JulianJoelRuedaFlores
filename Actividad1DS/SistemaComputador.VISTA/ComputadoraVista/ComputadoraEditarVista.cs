using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaComputadora.BSS;
using SistemaComputadora.MODELOS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaComputador.VISTA.ComputadoraVista
{
	public partial class ComputadoraEditarVista : Form
	{
		int idx = 0;
		Computadora c = new Computadora();
		ComputadoraBss bss = new ComputadoraBss();
		public ComputadoraEditarVista(int id)
		{
			idx = id;
			InitializeComponent();
		}

		private void ComputadoraEditarVista_Load(object sender, EventArgs e)
		{
			c = bss.ObtenerIdBss(idx);
			textBox1.Text = c.Nombre;
			textBox2.Text = c.Descripcion;
			textBox3.Text = c.Precio.ToString();
			textBox4.Text = c.FechaFabricacion.ToString("yyyy-MM-dd");


		}

		private void button1_Click(object sender, EventArgs e)
		{
			Computadora c = new Computadora();
			c.Id = idx;
			c.Nombre = textBox1.Text;
			c.Descripcion = textBox2.Text;
			c.Precio = Convert.ToDecimal(textBox3.Text);
			c.FechaFabricacion = DateTime.Now;

			bss.EditarComputadoraBss(c);
			MessageBox.Show("Se actualizó correctamente la computadora");

		}
	}
}
