using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGO.Clases
{
    public class DatosCliente
    {

        public string Empresa { get; set; }
        public string Cif { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dir { get; set; }
        public string Cod { get; set; }
        public string Pais { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public string Referencia { get; set; }
        public string Color { get; set; }
        public string Talla { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public List<DatosCliente> DetailC = new List<DatosCliente>();


    }
}
