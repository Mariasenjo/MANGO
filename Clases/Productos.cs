using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MANGO
{
    class Productos
    {
        private string idRef, fam, color, talla, imag;
        private double prec;
        private int stock, cant;
 

        private SqlCommand cmd;
        //Es necesario incluir el @ antes del string para especificar que es una 
        //base de datos local
        private String conDB = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MangoDB.mdf;Integrated Security = True";
        private SqlConnection con;

       

        
        public Productos()
        {
             con =new SqlConnection(conDB);

            idRef = string.Empty;
            fam = string.Empty;
            color = string.Empty;
            talla = string.Empty;
            imag = string.Empty;
            prec = 0;
            stock = 0;
            cant = 0;
        }

        public Productos(string tid, string tfam, string tcolor,string ttalla, string timag, double tprec, int tstock, int tcant)
        {
            idRef = tid;
            fam = tfam;
            color = tcolor;
            talla = ttalla;
            imag = timag;
            prec = tprec;
            stock = tstock;
            cant = tcant;

        }

        public string fidRef
        {
            set { idRef = value; }
            get { return idRef; }
        }
        public string ffam
        {
            set { fam = value; }
            get { return fam; }
        }
        public string fcolor
        {
            set { color = value; }
            get { return color; }
        }
        public string ftalla
        {
            set { talla = value; }
            get { return talla; }
        }
        public string fimag
        {
            set { imag = value; }
            get { return imag; }
        }
        public double fprec
        {
            set { prec = value; }
            get { return prec; }
        }
        public int fstock
        {
            set { stock = value; }
            get { return stock; }
        }
        public int fcant
        {
            set { cant = value; }
            get { return cant; }
        }

        public void InsertarProducto()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("InsertarProductos", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@REFERENCIA", idRef);
                cmd.Parameters.AddWithValue("@FAMILIA", fam);
                cmd.Parameters.AddWithValue("@COLOR", color);
                cmd.Parameters.AddWithValue("@TALLA", talla);
                cmd.Parameters.AddWithValue("@IMAGEN", imag);
                cmd.Parameters.AddWithValue("@PRECIO", prec);
                cmd.Parameters.AddWithValue("@STOCK", stock);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void InsertarProductoMasiva()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Masiva", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@REFERENCIA", idRef);
                cmd.Parameters.AddWithValue("@FAMILIA", fam);
                cmd.Parameters.AddWithValue("@COLOR", color);
                cmd.Parameters.AddWithValue("@TALLA", talla);
                cmd.Parameters.AddWithValue("@IMAGEN", imag);
                cmd.Parameters.AddWithValue("@PRECIO", prec);
                cmd.Parameters.AddWithValue("@STOCK", stock);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public void ActualizarProducto()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("ActualizarProductos", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@REFERENCIA", idRef);
                cmd.Parameters.AddWithValue("@FAMILIA", fam);
                cmd.Parameters.AddWithValue("@COLOR", color);
                cmd.Parameters.AddWithValue("@TALLA", talla);
                cmd.Parameters.AddWithValue("@IMAGEN", imag);
                cmd.Parameters.AddWithValue("@PRECIO", prec);
                cmd.Parameters.AddWithValue("@STOCK", stock);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public int EliminarProducto()
        {
            int c;
            try
            {
                con.Open();
                cmd = new SqlCommand("DeleteProductos", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@REFERENCIA", idRef);
                c = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return c;
        }

        public DataTable ListarProducto()
        {
            try
            {
                DataSet dset; 
                SqlDataAdapter dadapter;
                con.Open();
                cmd = new SqlCommand("ListarProductos", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dset = new DataSet();
                dadapter = new SqlDataAdapter(cmd);
                dadapter.Fill(dset);
                return dset.Tables[0];

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        
    }

}
