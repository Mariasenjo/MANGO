using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGO
{
    class Empleados
    {
        private string idnumEm, nom, ape, pass;


        private SqlCommand cmd;
        //Es necesario incluir el @ antes del string para especificar que es una 
        //base de datos local
        private String conDB = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MangoDB.mdf;Integrated Security = True";
        private SqlConnection con;


        public Empleados()
        {
            con = new SqlConnection(conDB);

        }

        public Empleados(string tidN, string tnom, string tape, string tpass)
        {
            this.idnumEm = tidN;
            this.nom = tnom;
            this.ape = tape;
            this.pass = tpass;

        }

        public string fidN
        {
            set { idnumEm = value; }
            get { return idnumEm; }
        }

        public string fnom
        {
            set { nom = value; }
            get { return nom; }
        }

        public string fape
        {
            set { ape = value; }
            get { return ape; }
        }

        public string fpass
        {
            set { pass = value; }
            get { return pass; }
        }

        public void InsertarEmpleados()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("InsertarEmpleados", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDNUMEMPLE", idnumEm);
                cmd.Parameters.AddWithValue("@NOMBRE", nom);
                cmd.Parameters.AddWithValue("@APELLIDO", ape);
                cmd.Parameters.AddWithValue("@PASSWORD", pass);
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
    }
}
