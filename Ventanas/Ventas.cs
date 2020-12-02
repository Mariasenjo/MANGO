
using Microsoft.Reporting.WinForms;
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
    public partial class Venta : Form
    {
        private DataTable dt;

        public Venta()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Referencia");
            dt.Columns.Add("Color");
            dt.Columns.Add("Talla");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Cantidad");

            dataGridView2.DataSource = dt;
        }

        public static string strcon = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MangoDB.mdf;Integrated Security = True";
        SqlConnection conexion = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand();

        public static string Referencia, Color, Talla;
        public static double Precio;
      

        private void button1_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)//Boton Factura
        {

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                Report rep;

                
                /*
                Productos pro = new Productos();
                pro.fidRef = (string)dataGridView2.Rows[0].Cells[0].Value.ToString();
                pro.fcolor = (string)dataGridView2.Rows[0].Cells[1].Value.ToString();
                pro.ftalla = (string)dataGridView2.Rows[0].Cells[2].Value.ToString();
                pro.fprec = double.Parse(dataGridView2.Rows[0].Cells[3].Value.ToString());
                pro.fcant = int.Parse(dataGridView2.Rows[0].Cells[4].Value.ToString());
                */
            }


            DatosFactura form = new DatosFactura();
            form.Show();
            this.Hide();
        }

       

        private void FillGrid()
        {
            try
            {
                Productos objetoProducto = new Productos();
                dataGridView.DataSource = objetoProducto.ListarProducto();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mensaje");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            productosTableAdapter.Buscar(mangoDBDataSet.Productos, IdVenta.Text.Trim());
            
            
            DataRow row = dt.NewRow();

            int cantidad = 1;

            Console.WriteLine(dataGridView.Rows[0].Cells[0].Value.ToString());

             row["Referencia"] = dataGridView.Rows[0].Cells[0].Value.ToString();
             row["Color"] = dataGridView.Rows[0].Cells[1].Value.ToString();
             row["Talla"] = dataGridView.Rows[0].Cells[2].Value.ToString();
             row["Precio"] = dataGridView.Rows[0].Cells[3].Value.ToString();
             row["Cantidad"] = cantidad;
              
             dt.Rows.Add(row);
            
            decimal total = 0;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    total += decimal.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString());
                }
            
            textBox3.Text = Convert.ToString(total);
            
            Limpiar();
            
            }

        private void button3_Click(object sender, EventArgs e)//Efectivo
        {
            string total = textBox3.Text;
            string nuevo = textBox2.Text;
            decimal devolver = Convert.ToDecimal(nuevo) - Convert.ToDecimal(total);

            textBox1.Text = devolver.ToString() + "€";
        }    

        private void Limpiar()
        {
            IdVenta.Text = "";
            IdVenta.Focus();

        }



        }
    }

   public class ListaVentas
    {
        public string Referencia { get; set; }
        public string Color { get; set; }
        public string Talla { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

    }
 



