using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGO
{
    class VentaProductos
    {
        private string Id_referencia;
        private string familia;
        private string color;
        private string talla;
        private double precio;
        private int cantidad;


        public VentaProductos()
        {
            Id_referencia = string.Empty;
            familia = string.Empty;
            color = string.Empty;
            talla = string.Empty;
            precio = 0;
            cantidad = 0;

        }
        public VentaProductos( string id , string fam, string col, string ta, double prec, int cant)
        {
            Id_referencia = id;
            familia = fam;
            color = col;
            talla = ta;
            precio = prec;
            cantidad = cant;

        }

        public String Referencia
        {
            get { return Id_referencia;}
            set { Id_referencia = value; }
        }

        public String Familia
        {
            get { return familia; }
            set { familia = value; }
        }

        public String Color
        {
            get { return color; }
            set { color = value; }
        }


        public String Talla
        {
            get { return talla; }
            set { talla = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


    }
}
