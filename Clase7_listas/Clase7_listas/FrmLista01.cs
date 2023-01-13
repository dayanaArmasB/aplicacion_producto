using utp.industrial.entity;

namespace utp.industrial.view
{
    public partial class FrmLista01 : Form
    {
        public FrmLista01()
        {
            InitializeComponent();
        }
        List<Producto> ListaProductos =  new List<Producto>();

        private void verProducto()
        {
            DgvProductos.DataSource = null;
            DgvProductos.DataSource = ListaProductos;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                createProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);;
            }

        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxType.Items.Add("baterias");
            cbxType.Items.Add("guitarras");
            cbxType.Items.Add("flautas");
            cbxType.Items.Add("saxofones");
            cbxType.Items.Add("trompetas");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            DgvProductos.Rows.RemoveAt(DgvProductos.CurrentRow.Index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateProduct(new Producto()
            {
                Marca = txtBrand.Text,
                Precio = double.Parse(txtPrice.Text),
                Tipo = cbxType.Text,
                Nombre = txtName.Text,
                Cantidad = int.Parse(txtAmount.Text)
            });

            DgvProductos.DataSource = ListaProductos; //refresh 
        }



        //definici�n de m�todos 

       
        public void createProduct()
        {

            DgvProductos.AutoGenerateColumns = false;
            DgvProductos.AllowUserToAddRows = false;
            var source = new BindingSource();
            ListaProductos.Add(new Producto()
            {
                Marca = txtBrand.Text,
                Precio = double.Parse(txtPrice.Text),
                Tipo = cbxType.Text,
                Nombre = txtName.Text,
                Cantidad = int.Parse(txtAmount.Text)
            });

            verProducto();

            //DgvProductos.Rows.Add(txtName.Text, txtBrand.Text, cbxType.Text, txtPrice.Text, txtAmount.Text);
        }



        //actualizar� por nombre
        public void updateProduct(Producto o)
        {
            int index = 0;
            foreach (var item in ListaProductos)
            {
                if (item.Nombre == o.Nombre)
                {
                    ListaProductos[index] = o; // aqui actualiza
                    break;
                }
                index++;
            }
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Form1
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "Form1";
        //    this.Load += new System.EventHandler(this.Form1_Load_1);
        //    this.ResumeLayout(false);

        //}

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}