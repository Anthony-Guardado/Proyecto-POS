using Proyecto_POS.CapaDatos;
using Proyecto_POS.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.CapaNegocio
{
    public class ClienteBLL
    {
        ClienteDAL dal = new ClienteDAL();
        public DataTable Listar()
        {
            return dal.Listar();
        }

        public int Guardar(Cliente2 c)
        {
            if (string.IsNullOrWhiteSpace(c.NombreCompleto))
                throw new Exception("El nombre del cliente es obligatorio");
            if (c.Id == 0)
            { 
            return dal.Insertar(c);
            }
            else
            {
                dal.Actualizar(c); 
                return c.Id;
            }
            
        }
        public void Eliminar(int Id)
        {
            dal.Eliminar(Id); 
        }
        public DataTable Buscar(string NombreCompleto)
        {
            return dal.Buscar(NombreCompleto);
        }

    }
}
