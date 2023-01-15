using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace utp.industrial.entity
{
    public class Fertilizante
    {
        public int GGNumVenta, GGCantidad;
        public string GGNomCliente, GGNomFertilizante, GGRecomendaciones;
        public double GGPrecio, GGPorcentajeDescuento, GGTotal;

        public double Calculo()
        {
            GGTotal = GGCantidad * GGPrecio;
            GGTotal -= (GGTotal * GGPorcentajeDescuento);

            return GGTotal;

        }

        //public void Registrar(DataGridView dgv)
        //{
        //    dgv.Rows.Add(GGNumVenta, GGNomCliente, GGNomFertilizante, GGCantidad, 
        //        GGPrecio, GGPorcentajeDescuento, Math.Round(Calculo(),2));
        //}
    }
}
