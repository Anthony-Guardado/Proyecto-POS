using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POS.CapaEntidades
{
    public class Cliente2
    {
       public int Id { get; set; }
         public string NombreCompleto { get; set; }
            public int Dui { get; set; }
        public int Telefono { get; set; }
           public string Email { get; set; }
        public bool Estado { get; set; }
    }
}
