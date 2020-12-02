using MANGO.Properties;

using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;
using System.Transactions;

namespace MANGO
{
    public partial class Stock : Form
    {

        SqlConnection conexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\MARIA\SOURCE\REPOS\MANGO\BIN\DEBUG\MANGODB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Stock()
        {
            InitializeComponent();
        }


        //Coge el valor de la fila y muestra la imagen
        private void Click_fila(object sender, DataGridViewCellEventArgs e)
        {
            //Coje el valor de la fila que clicamos (0,1,2..)
            int valorCelda = tablaProductos.Rows[e.RowIndex].Index;
            String error = @"C:\Users\maria\source\repos\MANGO\Imagenes\error.jpg";
            String referencia = tablaProductos.Rows[valorCelda].Cells[4].Value.ToString();

            try
            {
                imagen.Image = Image.FromFile(referencia);
            }
            catch (Exception)
            {
                imagen.Image = Image.FromFile(error);
            }

        }


        private void button1_Click(object sender, EventArgs e)//Botón salir
        {

            Menu form = new Menu();
            form.Show();
            this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)//Boton Modificar
        {
            
            try
            {
                this.Validate();
                productosTableAdapter.Update(mangoDBDataSet.Productos);
                //Console.WriteLine(mangoDBDataSet.Productos.ToString(), "hola");
                MessageBox.Show("Modificación realizada con exito");
                
            }
            catch (System.Exception)
            {
                MessageBox.Show("Modificación fallida");

            }
            

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            //productosTableAdapter.mostrar(mangoDBDataSet.Productos);
            //FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                Productos objetoProducto = new Productos();
                tablaProductos.DataSource = objetoProducto.ListarProducto();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mensaje");
            }
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtFam.Text = "";
            txtColor.Text = "";
            txtTalla.Text = "";
            txtima.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtId.Focus();

        }
        private void buscar_Click(object sender, EventArgs e)
        {
            productosTableAdapter.Buscar(mangoDBDataSet.Productos, txtId.Text.Trim());
            Limpiar();
            
            
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            productosTableAdapter.mostrar(mangoDBDataSet.Productos);
            /*Productos objetoProductos = new Productos();
            objetoProductos.ListarProducto();
            */
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            productosTableAdapter.Borrar(tablaProductos.CurrentRow.Cells[0].Value.ToString());
            //tablaProductos.Rows[valorCelda].Cells[4].Value.ToString();
            //Productos objetoProductos = new Productos();
            //objetoProductos.EliminarProducto();
            MessageBox.Show("Producto borrado");

            Limpiar();
            FillGrid();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void añadir_Click(object sender, EventArgs e)
        {
            //productosTableAdapter.Añadir(txtId.Text.Trim(),txtFam.Text.Trim(), txtColor.Text.Trim(), txtTalla.Text.Trim(), null, Convert.ToDouble(txtPrecio.Text.Trim()), Convert.ToInt16(txtStock.Text.Trim()));
            try
            {
                Productos objetoProductos = new Productos();
                objetoProductos.fidRef = txtId.Text;
                objetoProductos.ffam = txtFam.Text;
                objetoProductos.fcolor = txtColor.Text;
                objetoProductos.ftalla = txtTalla.Text;
                objetoProductos.fimag = txtima.Text;
                objetoProductos.fprec = Convert.ToDouble(txtPrecio.Text);
                objetoProductos.fstock = Convert.ToInt32(txtStock.Text);
                objetoProductos.InsertarProducto();
                MessageBox.Show("Producto agregado");

                Limpiar();
                FillGrid();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje");
            }
        }


        private void importar_Click(object sender, EventArgs e)
        {
            
           /* Productos objetoProductos = new Productos();
            objetoProductos.InsertarProductoMasiva();
            MessageBox.Show("Importación completada");*/
            productosTableAdapter.ImportarMasivo();
            Console.WriteLine(tablaProductos.DataSource);

        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


        
    