using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utp.industrial.entity
{
    public class Importe
    {
        public int hackersNumeroVenta;
        public string hackersNombreCliente;
        public string hackersNombreFertilizante;
        public int hackersCantidad;
        public double hackersPrecio;
        public double hackersDescuento;

        public double Monto()
        {
            return hackersCantidad * hackersPrecio;
        }

        public double Descuento()
        {
            if(hackersCantidad > 6)
            {
                return hackersDescuento/100;
            }
            else
            {
                return 0;
            }
        }

        public double MontoPagar()
        {
            return Monto() - (Monto() * Descuento());
        }
    }
}
