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
    public class CategoriaDAL
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT Id, Nombre FROM Categoria";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();

                    new SqlDataAdapter(cmd).Fill(dt);
                    // SqlDataAdapter ejecuta el SELECT y guarda el resultado en dt
                }
            }
            return dt;
        }
        // MÉTODO: Insertar nueva categoría

        public int Insertar(Categoria c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                // SCOPE_IDENTITY devuelve el ID recién insertado
                string sql = @"INSERT INTO Categoria (Nombre)
                    VALUES (@nombre);
                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                   
                    cn.Open();

                    // ExecuteScalar devuelve un solo valor (el ID)
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }



        // MÉTODO: Actualizar categoría existente

        public bool Actualizar(Categoria c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"UPDATE Categoria SET
                   Nombre=@nombre
                   WHERE Id=@id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", c.Id);
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                     /*La línea de código agrega un parámetro llamado @descripcion al comando SQL. Si la propiedad 
                     * c.Descripcion en C# es null, se envía un valor NULL a la base de datos (usando DBNull.Value); 
                     * de lo contrario, se envía el valor real de la descripción.*/

                    cn.Open();

                    // ExecuteNonQuery devuelve número de filas afectadas
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        // MÉTODO: Eliminar categoría por ID

        public bool Eliminar(int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "DELETE FROM Categoria WHERE Id=@id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        // MÉTODO: Buscar por filtro parcial (Nombre o Descripción)

        public DataTable Buscar(string filtro)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT Id, Nombre  
                               FROM Categoria
                               WHERE Nombre LIKE @filtro";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    // %filtro% coincide con cualquier parte del texto
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    cn.Open();

                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }
        // MÉTODO NUEVO: ¿Existe una categoría con ese nombre?
        // (Validación para INSERTAR)

        public bool ExisteNombre(string nombre)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT COUNT(*) FROM Categoria WHERE Nombre = @nombre";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);

                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        // MÉTODO NUEVO: ¿Existe el nombre en OTRA categoría?
        // (Validación para EDITAR sin permitir duplicados)

        public bool ExisteNombreEnOtraCategoria(string nombre, int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT COUNT(*) 
                               FROM Categoria 
                               WHERE Nombre = @nombre AND Id <> @id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
        //NO se puede eliminar una categoría si tiene productos asociados   
        // MÉTODO NUEVO: Validar relación FK
        // ¿Tiene productos asociados?

        public bool TieneProductosAsociados(int idCategoria)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT COUNT(*) 
                               FROM Producto 
                               WHERE Id_Categoria = @id_Categoria";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id_Categoria", idCategoria);

                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

    }


}

