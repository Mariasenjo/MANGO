using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGO.Properties
{
    public class ProductosViewModel
    {
        public string Id_referencia { get; set; }
        public string familia { get; set; }
        public string color { get; set; }
        public string talla { get; set; }
        public string imagen { get; set; }
        public int precio { get; set; }
        public int stock { get; set; }
    }
}
