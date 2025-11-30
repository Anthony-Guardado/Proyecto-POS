using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.CapaDatos
{
    public class ProductoDAL
    {
        public static int ObtenerStock(int Id_Producto)
        {
            int stock = 0;

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT Stock FROM Producto WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id_Producto);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        stock = Convert.ToInt32(result);
                }
            }

            return stock;
        }
        public static DataTable Listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"
                    SELECT p.Id, p.Nombre, p.Precio, p.Stock, c.Nombre AS Categoria
                    FROM Producto p
                    INNER JOIN Categoria c ON p.Id_Categoria = c.Id
                    WHERE p.Estado = 1;";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        tabla.Load(dr);
                    }
                }
            }

            return tabla;
        }


    }
}
