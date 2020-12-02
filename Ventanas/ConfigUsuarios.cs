using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGO
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        //Al abrir la ventana se muestran todos los datos
        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetEmpleados.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.dataSetEmpleados.Empleados);

        }

        //Método que limpia todos los textbox
        private void Limpiar()
        {
            txtnom.Text = "";
            txtape.Text = "";
            txtnumEmple.Text = "";
            txtpass.Text = "";
            txtnom.Focus();

        }

        //Botón añadir que sirve para añadir datos al datagridview
        private void añadir_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados objetoEmpleados = new Empleados();
                objetoEmpleados.fnom = txtnom.Text;
                objetoEmpleados.fape = txtape.Text;
                objetoEmpleados.fidN = txtnumEmple.Text;
                objetoEmpleados.fpass = txtpass.Text;
          
                objetoEmpleados.InsertarEmpleados();
                MessageBox.Show("Empleado agregado");

                Limpiar();
                this.empleadosTableAdapter.Fill(this.dataSetEmpleados.Empleados);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje");
            }
        }

        //Botón que se utiliza para modificar los datos de los empleados
        private void modificar_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.empleadosBindingSource.EndEdit();
                this.empleadosTableAdapter.Update(this.dataSetEmpleados.Empleados);
                MessageBox.Show("Modificación realizada con exito");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Modificación fallida");
            }

        }


        //Botón que borra al empleado que le des click
        private void borrar_Click(object sender, EventArgs e)
        {
            empleadosTableAdapter.DeleteQuery(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("Producto borrado");
            this.empleadosTableAdapter.FillBy(this.dataSetEmpleados.Empleados);
            Limpiar();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.empleadosTableAdapter.FillBy(this.dataSetEmpleados.Empleados);
        }
    }
}
