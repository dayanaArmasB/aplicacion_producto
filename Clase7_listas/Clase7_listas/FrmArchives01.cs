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
    public partial class FrmArchives01 : Form
    {
        public FrmArchives01()
        {
            InitializeComponent();

            StreamWriter GGcreador = File.CreateText(@"C:\Fertilizantes\Fertilizantes_Agrícolas_Datos_de_Venta.txt");
            GGcreador.Close();
        }

        Fertilizante ft = new Fertilizante();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ft.GGNumVenta = int.Parse(txtNumVenta.Text);
                ft.GGNomCliente = txtNomCliente.Text;
                ft.GGNomFertilizante = txtNomFertilizante.Text;
                ft.GGCantidad = int.Parse(txtCantidad.Text);
                ft.GGPrecio = double.Parse(txtPrecio.Text);

                if (txtNomCliente.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese un nombre válido para el cliente", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomCliente.Clear();
                    txtNomCliente.Focus();
                }
                else if (txtNomFertilizante.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese un nombre válido para el fertilizante", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomFertilizante.Clear();
                    txtNomFertilizante.Focus();
                }
                else if (int.Parse(txtCantidad.Text) < 1)
                {
                    MessageBox.Show("Ingrese una cantidad válida", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCantidad.Clear();
                    txtCantidad.Focus();
                }
                else if (double.Parse(txtPrecio.Text) < 1)
                {
                    MessageBox.Show("Ingrese un precio válido", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPrecio.Clear();
                    txtPrecio.Focus();
                }
                else if (double.Parse(txtPorcentajeDescuento.Text) < 1)
                {
                    MessageBox.Show("Ingrese un porcentaje válido", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPorcentajeDescuento.Clear();
                    txtPorcentajeDescuento.Focus();
                }
                else if (double.Parse(txtPorcentajeDescuento.Text) == 5 || double.Parse(txtPorcentajeDescuento.Text) == 10)
                {
                    if (ft.GGCantidad < 6)
                    {
                        ft.GGPorcentajeDescuento = 0;

                        ft.Calculo();
                        //ft.Registrar(dgvDatos);
                        dgvDatos.Rows.Add(ft.GGNumVenta, ft.GGNomCliente, ft.GGNomFertilizante, ft.GGCantidad,
    ft.GGPrecio, ft.GGPorcentajeDescuento, Math.Round(ft.Calculo(), 2));
                    } else
                    {
                        if (double.Parse(txtPorcentajeDescuento.Text) == 5)
                        {
                            ft.GGPorcentajeDescuento = 0.05;

                            ft.Calculo();
                            //ft.Registrar(dgvDatos);
                            dgvDatos.Rows.Add(ft.GGNumVenta, ft.GGNomCliente, ft.GGNomFertilizante, ft.GGCantidad,
    ft.GGPrecio, ft.GGPorcentajeDescuento, Math.Round(ft.Calculo(), 2));
                        }
                        else if (double.Parse(txtPorcentajeDescuento.Text) == 10)
                        {
                            ft.GGPorcentajeDescuento = 0.10;

                            ft.Calculo();
                            //ft.Registrar(dgvDatos);
                            dgvDatos.Rows.Add(ft.GGNumVenta, ft.GGNomCliente, ft.GGNomFertilizante, ft.GGCantidad,
    ft.GGPrecio, ft.GGPorcentajeDescuento, Math.Round(ft.Calculo(), 2));
                        }
                    }
                } 
                else
                {
                    MessageBox.Show("Ingrese 5 o 10 como valores para el porcentaje de descuento", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, Verifique los datos nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string GGFertilizante = "";
            GGFertilizante += ft.GGNumVenta + " - ";
            GGFertilizante += txtNomCliente.Text + " - ";
            GGFertilizante += txtNomFertilizante.Text + " - ";
            GGFertilizante += txtCantidad.Text + " - ";
            GGFertilizante += txtPrecio.Text + " - ";
            GGFertilizante += ft.GGPorcentajeDescuento + " - ";
            GGFertilizante += txtRecomendaciones.Text;

            StreamWriter GGescritor = File.AppendText(@"C:\Fertilizantes\Fertilizantes_Agrícolas_Datos_de_Venta.txt");
            GGescritor.WriteLine(GGFertilizante);
            GGescritor.Close();
            MessageBox.Show("Registrado con éxito. Se ha generador un archivo de texto de registro en el Disco Local C", "Notificación",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}