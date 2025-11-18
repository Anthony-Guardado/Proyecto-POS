using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.CapaEntidades
{
    public class Producto // poner nivel de acceso pulic
    {
        //Definir atributos
        public int Id { get; set;  }
        public int Nombre { get; set; }
        public int Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int Estado { get; set; }
    }
}
