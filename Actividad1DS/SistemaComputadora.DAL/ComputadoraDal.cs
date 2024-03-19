using SistemaComputadora.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComputadora.DAL
{
	public class ComputadoraDal
	{
		public DataTable ListarComputadoraDal()
		{
			string consulta = "select * from computadora";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}

		public void InsertarComputadoraDal(Computadora computadora)
		{
			string consulta = "insert into computadora values ('" +
							  computadora.Nombre + "', '" +
							  computadora.Descripcion + "', " +
							  computadora.Precio.ToString("0.00", CultureInfo.InvariantCulture) + ", '" +
							  computadora.FechaFabricacion.ToString("yyyy-MM-dd") + "')";
			conexion.Ejecutar(consulta);
		}



		public Computadora ObtenerComputadoraId(int id)
		{
			string consulta = "SELECT * FROM Computadoras WHERE Id = " + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
			Computadora computadora = new Computadora();
			if (tabla.Rows.Count > 0)
			{
				computadora.Id = Convert.ToInt32(tabla.Rows[0]["Id"]);
				computadora.Nombre = tabla.Rows[0]["Nombre"].ToString();
				computadora.Descripcion = tabla.Rows[0]["Descripcion"].ToString();
				computadora.Precio = Convert.ToDecimal(tabla.Rows[0]["Precio"]);
				computadora.FechaFabricacion = Convert.ToDateTime(tabla.Rows[0]["FechaFabricacion"]);
			}
			return computadora;


		}
		public void EditarComputadoraDal(Computadora c)
		{
			string consulta = "update computadora set nombre='" + c.Nombre + "', " +
													 "Descripcion='" + c.Descripcion + "', " +
													 "Precio=" + c.Precio.ToString("0.00", CultureInfo.InvariantCulture) + ", " +
													 "FechaFabricacion='" + c.FechaFabricacion.ToString("yyyy-MM-dd") + "' " +
							  "where id=" + c.Id;
			conexion.Ejecutar(consulta);
		}

		public void EliminarComputadoraDal(int id)
		{
			string consulta = "delete from computadora where id =" + id;
			conexion.Ejecutar(consulta);
		}
	}
}
