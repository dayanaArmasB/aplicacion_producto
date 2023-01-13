using utp.industrial.entity;

namespace utp.industrial.view
{
    public partial class FrmArray01 : Form
    {
        public FrmArray01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        int i = 0, j=0;
        Arrays ar1=new Arrays();
        Arrays ar2=new Arrays();
        Arrays aSuma=new Arrays();
        private void btnAgregarArray1_Click(object sender, EventArgs e)
        {
            if ((txtElementoArray1.Text).Length!=0)
            {
                if (i<5)
                {
                    ar1.elemento[i] = Convert.ToInt32(txtElementoArray1.Text);
                    //ar1.ingrssesar(txtElementoArray1,i);
                    // ar1.mostrar(txtArray1,i);
                    txtArray1.Text += ar1.elemento[i] + "    ";
                    txtElementoArray1.Clear();
                    txtElementoArray1.Focus();
                }
                else
                {
                    MessageBox.Show("El array está completo!!");
                    btnAgregarArray1.Enabled = false;
                    txtElementoArray1.Enabled = false;
                }
                i++;
            }
            else
            {
                MessageBox.Show("Ingrese número!!!");
                txtElementoArray1.Focus();
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            aSuma = ar1 + ar2;
            for (int k=0;k<5;k++)
            {
                MessageBox.Show(aSuma.elemento[k].ToString());
            }
        }

        private void btnAgregarArray2_Click(object sender, EventArgs e)
        {
            if ((txtElementoArray2.Text).Length != 0)
            {
                if (j < 5)
                {

                    ar2.elemento[j] = Convert.ToInt32(txtElementoArray2.Text);
                    txtArray2.Text += ar2.elemento[j] + "    ";
                    //ar2.ingresar(txtElementoArray2, j);
                    //ar2.mostrar(txtArray2, j);
                    txtElementoArray2.Clear();
                    txtElementoArray2.Focus();
                }
                else
                {
                    MessageBox.Show("El array está completo!!");
                    btnAgregarArray2.Enabled = false;
                    txtElementoArray2.Enabled = false;
                }
                j++;
            }
            else
            {
                MessageBox.Show("Ingrese número!!!");
                txtElementoArray2.Focus();
            }
        }
    }
}