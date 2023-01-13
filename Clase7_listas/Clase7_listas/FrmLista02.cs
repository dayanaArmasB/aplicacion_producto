using utp.industrial.entity;

namespace utp.industrial.view
{
    public partial class FrmLista02 : Form
    {
        public FrmLista02()
        {
            InitializeComponent();
        }

        List<Mascota> listaMascota = new List<Mascota>();

        double precio = 45, sumatorioEdad = 0, sumatorioRaza = 0, precioFinal;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int Raza = cmbRaza.SelectedIndex;

            if (double.Parse(txtEdad.Text) > 5)
            {
                sumatorioEdad = (45 * 0.05);
            }
            if (Raza == 2)
            {
                sumatorioRaza += (45 * 0.10);
            }
            precioFinal = (precio + sumatorioEdad + sumatorioRaza);

            listaMascota.Add (new Mascota()
            {
                ggDueño = txtDueño.Text,
                ggRazaEsp = txtRazaEsp.Text,
                ggMascota = txtMascota.Text,
                ggRaza = cmbRaza.Text,
                ggPadecimiento = txtPadecimiento.Text,
                ggEdad = txtEdad.Text,
                ggFechaConsulta = dtpFechaConsulta.Text,
                ggPrecioFinal = precioFinal.ToString()
            }) ;

            lbLista.Items.Clear();
            foreach (var c in listaMascota)
            {
                lbLista.Items.Add("Dueño: " + c.ggDueño 
                    + " / Mascota: " + c.ggMascota 
                    + " / Tamaño de Raza: " + c.ggRaza 
                    + " / Raza: " + c.ggRazaEsp 
                    + " / Edad: " + c.ggEdad 
                    + " / Fecha de Consulta: " + c.ggFechaConsulta 
                    + " / Padecimiento: " + c.ggPadecimiento 
                    + " / Precio Final: " + c.ggPrecioFinal);
            }
        }
    }

}
