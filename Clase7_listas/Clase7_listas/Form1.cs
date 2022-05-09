namespace Clase7_listas
{
    public partial class Form1 : Form
    {
        public Form1()
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



        //definición de mètodos 

       
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



        //actualizará por nombre
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
    }
}