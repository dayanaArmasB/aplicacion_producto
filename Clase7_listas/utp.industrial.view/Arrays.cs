using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utp.industrial.entity
{
    public struct Arrays
    {
        //atributo
        public int[] elemento;
        //constructor
        public Arrays()
        {
            elemento = new int[5];
        }

        public static Arrays operator +(Arrays v1, Arrays v2)
        {
            Arrays su = new Arrays();
            for (int f = 0; f < su.elemento.Length; f++)
            {
                su.elemento[f] = v1.elemento[f] + v2.elemento[f];
            }
            return su;
        }

        //métodos
        //void, no devuelve valor
        //public void ingresar(TextBox txtValor, int i)
        //{
        //    ar1.elemento[i] = Convert.ToInt32(txtValor.Text);
        //}
        //public void mostrar(TextBox txtMostrar, int i)
        //{
        //    txtMostrar.Text += elemento[i] + "    ";
        //}        //métodos
        //void, no devuelve valor

    }
}
