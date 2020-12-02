using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGO
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Bienvenida_KeyDown(object sender, KeyEventArgs e)
        {
            Acceso form = new Acceso();
            form.Show();
            this.Hide();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            
           
        }
    }
    
}
