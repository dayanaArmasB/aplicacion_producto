using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7_listas
{
    public class Producto
    {

        //constructor por defecto 
        public Producto()
        {
            Marca = string.Empty;
            Precio = 0;
            Tipo = String.Empty;
            Nombre = String.Empty;
            Cantidad = 0;
        }


        //constructor alternativo
        public Producto(string marca, double precio, string tipo, string nombre, int cantidad)
        {
            this.Marca = marca;
            this.Precio = precio;
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Cantidad = cantidad;
        }

        public string Marca { get; set; } 
        public double Precio { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

     
    }
}
