using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utp.industrial.entity;

namespace utp.industrial.view
{
    public partial class FrmArchives02 : Form
    {
        public FrmArchives02()
        {
            InitializeComponent();
            leeDatos();
        }
        Importe imp = new Importe();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string articulo = "";
            articulo += txtNumeroVenta.Text + ",";
            articulo += txtNombreCliente.Text + ",";
            articulo += txtNombreFertilizante.Text + ",";
            articulo += txtCantidad.Text + ",";
            articulo += txtPrecio.Text + ",";
            articulo += cbDescuento.Text + ",";
            articulo += imp.MontoPagar();
            StreamWriter writer = File.AppendText("C:\\Data\\Registro.txt");
            StreamWriter temp = File.AppendText("C:\\Data\\Temp.txt");
            writer.WriteLine(articulo);
            writer.Close();
            temp.Close();
            MessageBox.Show("Registro guardado con éxito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            leeDatos();

            int bandera = 0;
            try
            {
                imp.hackersNumeroVenta = int.Parse(txtNumeroVenta.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("¡Número de venta inválido! No se puede ingresar letras.", "Alerta"); bandera = 1;
                txtNumeroVenta.Clear();
                txtNumeroVenta.Focus();
            }
            try
            {
                imp.hackersNombreCliente = txtNombreCliente.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("¡Nombre del cliente inválido!", "Alerta"); bandera = 1;
                txtNombreCliente.Clear();
                txtNombreCliente.Focus();
            }
            try
            {
                imp.hackersNombreFertilizante = txtNombreFertilizante.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("¡Nombre del fertilizante inválido!", "Alerta"); bandera = 1;
                txtNombreFertilizante.Clear();
                txtNombreFertilizante.Focus();
            }
            try
            {
                imp.hackersCantidad = int.Parse(txtCantidad.Text);
                if (int.Parse(txtCantidad.Text) < 0)
                {
                    MessageBox.Show("La cantidad no puede ser menor que 0."); bandera = 1;
                }
                if (int.Parse(txtCantidad.Text) < 6)
                {
                    //pendiente
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Cantidad inválido! No se puede ingresar letras.", "Alerta"); bandera = 1;
                txtCantidad.Clear();
                txtCantidad.Focus();
            }
            try
            {
                imp.hackersPrecio = double.Parse(txtPrecio.Text);
                if (double.Parse(txtPrecio.Text) < 0)
                {
                    MessageBox.Show("El precio no puede ser menor que 0."); bandera = 1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Precio inválido! No se puede ingresar letras.", "Alerta"); bandera = 1;
                txtPrecio.Clear();
                txtPrecio.Focus();
            }
            try
            {
                imp.hackersDescuento = double.Parse(cbDescuento.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("¡Descuento inválido! No se puede ingresar letras.", "Alerta"); bandera = 1;
                cbDescuento.Focus();
            }
            if (bandera == 0)
            {
            }
        }

        private void leeDatos()
        {
            StreamReader reader = new StreamReader("C:\\Data\\Registro.txt");
            dgvRegistro.Rows.Clear();
            string linea = null;
            do
            {
                linea = reader.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(',');
                    dgvRegistro.Rows.Add(datos);
                }
            } while (linea != null);
            reader.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "Buscar")
            {
                StreamReader lector = new
                StreamReader("C:\\Data\\Registro.txt");
                bool flag = false;
                string[] datos = new string[6];
                string cod = txtIngreseNV.Text;
                string registro = lector.ReadLine();
                while (registro != null && flag != true)
                {
                    datos = registro.Split(',');
                    if (cod.Equals(datos[0]))
                    {
                        txtNumeroVenta.Text = datos[0];
                        txtNombreCliente.Text = datos[1];
                        txtNombreFertilizante.Text = datos[2];
                        txtCantidad.Text = datos[3];
                        txtPrecio.Text = datos[4];
                        cbDescuento.Text = datos[5];
                        flag = true;
                    }
                    else
                    {
                        registro = lector.ReadLine();
                    }
                }
                if (flag == false)
                    MessageBox.Show("Registro inexistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lector.Close();
                btnBuscar.Text = "Nuevo";
            }
            else
            {
                limpiaCajas();
                txtIngreseNV.Focus();
                btnBuscar.Text = "Buscar";
            }

        }
        private void limpiaCajas()
        {
            txtNumeroVenta.Text = ""; txtNombreCliente.Text = ""; txtNombreFertilizante.Text = "";
            txtCantidad.Text = ""; txtPrecio.Text = ""; cbDescuento.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro?", "Eliminar",MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
               StreamReader lector = new StreamReader("C:\\Data\\Registro.txt");
               StreamWriter escritor = new StreamWriter("C:\\Data\\Temp.txt");
                string prod = dgvRegistro.CurrentRow.Cells[0].Value.ToString();
                string registro = lector.ReadLine();
                while (registro != null)
                {
                    string[] datos = registro.Split(',');
                    if (!prod.Equals(datos[0]))
                    {
                        escritor.WriteLine(registro);
                    }
                    registro = lector.ReadLine();
                }
                lector.Close();
                escritor.Close();
                File.Delete("C:\\Data\\Registro.txt");
                File.Move("C:\\Data\\Temp.txt", "C:\\Data\\Registro.txt");
                leeDatos();
            }

        }
    }
}