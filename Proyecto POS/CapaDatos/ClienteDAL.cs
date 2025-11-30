using Proyecto_POS.CapaDatos;
using Proyecto_POS.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.CapaDatos
{
    public class ClienteDAL
    {
       
       

            public DataTable Listar()
        {
            DataTable dt = new DataTable();//Tabla memoria
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            //Sql connection: reprecenta la conexión a una base de datos SQL
            ////Server usuando la cadena de conexión
            {
                string sql = "SELECT Id, NombreCompleto, Dui, Telefono, Email, Estado from Cliente";
                //Consulta SQL que devuelve todos los registros de la tabla Cliente
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                //Sql command: Prepara el comando SQL que se enviará al servidor
                {
                    cn.Open();//Abre la conexión
                    new SqlDataAdapter(cmd).Fill(dt);
                    //SqlDataAdapter: Ejecuta el SELECT y llena el DataTable con los resultados
                }
            }
            return dt;//Retorna la tabla con los datos
        }
        public int Insertar(Cliente2 c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"INSERT INTO Cliente(NombreCompleto, Dui, Telefono, Email, Estado) VALUES (@NombreCompleto,@Dui,@Telefono,@Email,@Estado); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@NombreCompleto", c.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Dui", c.Dui);
                    cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@Email", c.Email);
                    cmd.Parameters.AddWithValue("@Estado", c.Estado);
                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public bool Actualizar(Cliente2 c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"UPDATE Cliente SET NombreCompleto=@NombreCompleto, Dui=@Dui, Telefono=@Telefono, Email=@Email, Estado=@Estado WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", c.Id);
                    cmd.Parameters.AddWithValue("@NombreCompleto", c.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Dui", c.Dui);
                    cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@Email", c.Email);
                    cmd.Parameters.AddWithValue("@Estado", c.Estado);

                    cn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                    //ExecuteNonQuery(): devuelve el número de filas afectadas
                    //>0 significa que se actualizo al menos una fila
                }
            }
        }
        public bool Eliminar(int Id)

        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "DELETE FROM Cliente WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable Buscar(string Filtro)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            { 
                string sql = "SELECT Id, NombreCompleto, Dui, Telefono, Email, Estado from Cliente WHERE NombreCompleto LIKE @Filtro OR Telefono LIKE @Filtro";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Filtro", "%" + Filtro + "%");
                    cn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
                return dt;
            }

        }
        public static List<Cliente2> ListarActivos()
        {
            List<Cliente2> lista = new List<Cliente2>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT * FROM Cliente WHERE Estado = 1";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente2
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Dui = Convert.ToInt32(dr["Dui"]),
                                Telefono = Convert.ToInt32(dr["Telefono"]),
                                Email = dr["Email"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
            }

            return lista;
        }


    }
}

