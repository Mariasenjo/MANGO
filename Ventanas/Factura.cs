using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MANGO.Clases;

namespace MANGO
{
    public partial class Factura : Form
    {
        public List<DatosFactura> datosfactura = new List<DatosFactura>();
        public Factura()
        {
            
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
