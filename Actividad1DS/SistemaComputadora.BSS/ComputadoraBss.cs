using SistemaComputadora.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaComputadora.DAL;

namespace SistemaComputadora.BSS
{
	public class ComputadoraBss
	{
		ComputadoraDal dal = new ComputadoraDal();
		public DataTable ListarComputadoraBss()
		{
			return dal.ListarComputadoraDal();
		}

		public void InsertarComputadoraBss(Computadora computadora)
		{
			dal.InsertarComputadoraDal(computadora);
		}
		public Computadora ObtenerIdBss(int id)
		{
			return dal.ObtenerComputadoraId(id);
		}
		public void EditarComputadoraBss(Computadora c)
		{
			dal.EditarComputadoraDal(c);
		}
		public void EliminarComputadoraBss(int id)
		{
			dal.EliminarComputadoraDal(id);
		}
	}
}
