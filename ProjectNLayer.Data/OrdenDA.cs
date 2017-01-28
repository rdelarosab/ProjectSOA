using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectNLayer.BEntities;

namespace ProjectNLayer.Data
{
    public class OrdenDA
    {
        private readonly SqlConnection cn = Connection.GetConnection();

        public OrdenBE GetOrdenById()
        {
            var orden = new OrdenBE();
            try
            {
                SqlCommand cmd = new SqlCommand("ListarOrdenById", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ordenId", 1);

                SqlDataReader dr = null;
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    orden.OrdenId = Convert.ToInt32(dr["OrdenId"]);
                    orden.OrdenFecha = Convert.ToDateTime(dr["OrdenFecha"]);
                    orden.Cliente.ClienteNombres = dr["Cliente"].ToString();

                    var ordenDetalle = new OrdenDetalleBE();
                    ordenDetalle.OrdenDetalleId = Convert.ToInt32(dr["DetalleOrdenId"]);
                    ordenDetalle.Producto.ProductoId = Convert.ToInt32(dr["ProductoId"]);
                    ordenDetalle.Producto.ProductoNombre = dr["ProductoNombre"].ToString();
                    ordenDetalle.Producto.ProductoPrecio = Convert.ToDecimal(dr["ProductoPrecio"]);
                    ordenDetalle.OrdenDetalleCantidad = Convert.ToInt32(dr["DetalleOrdenCantidad"]);
                    orden.LstOrdenDetalle.Add(ordenDetalle);
                }
                cn.Close();
            }
            catch (Exception)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                throw;
            }
            return orden;
        }
    }
}
