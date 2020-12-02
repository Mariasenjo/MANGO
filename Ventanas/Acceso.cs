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
using MiLibreria;


namespace MANGO
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection( @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MangoDB.mdf;Integrated Security = True");



        public void loguear( string idnumEmple, string password)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select* FROM Empleados WHERE Id_numEmple=@Id_numEmple AND password = @password", con);
                cmd.Parameters.AddWithValue("Id_numEmple", idnumEmple);
                cmd.Parameters.AddWithValue("password", password);
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dAdapter.Fill(dt);
                int temp = 0;

                if(dt.Rows.Count == 1 )
                {
                    Menu form = new Menu();
                    form.Show();
                    this.Hide();
                }
                else if(textCodigo.TextLength == 0 || textContra.TextLength == 0)
                {   
                    MessageBox.Show("Los campos no pueden estar vacíos");
                    textCodigo.Text = "";
                    textContra.Text = "";
                    textCodigo.Focus();

                }else if(textCodigo.Text.Length < 6)
                {
                    MessageBox.Show("El código debe tener 6 digitos");
                    textCodigo.Text = "";
                    textContra.Text = "";
                    textCodigo.Focus();

                }else if (textCodigo.Text == "." ||  textContra.Text == "." )
                {
                    MessageBox.Show("No puede contener puntos");
                    textCodigo.Text = "";
                    textContra.Text = "";
                    textCodigo.Focus();

                }else if (!int.TryParse(textCodigo.Text, out temp))
                {
                    MessageBox.Show("El código no pueden ser caracteres");
                    textCodigo.Text = "";
                    textContra.Text = "";
                    textCodigo.Focus();


                }else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    textCodigo.Text = "";
                    textContra.Text = "";
                    textCodigo.Focus();
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loguear(textCodigo.Text, textContra.Text);
           
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Acceso_Load(object sender, EventArgs e)
        {

        }
    }
}
