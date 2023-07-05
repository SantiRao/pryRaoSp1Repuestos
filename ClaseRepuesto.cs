using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRaoSp1
{
     internal class ClaseRepuesto
     {
        public string nombre { get; set; }

        public int codigo { get; set; }

        public string marca { get; set; }

        public decimal precio { get; set; }

        public string origen { get; set; }  

        public string MostrarRepuesto()
        {
            return "Codigo: " + codigo + " Nombre: " + nombre + " Marca: " + marca + " Precio: " + precio;
        }
     }
}
