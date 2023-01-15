using utp.industrial.entity;

namespace utp.industrial.view
{
    public partial class FrmArray03 : Form
    {
        public FrmArray03()
        {
            InitializeComponent();
        }
        char[] Array;
        Random r = new Random();
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int tamanio = int.Parse(txtTamanio.Text);
            Array = new char[tamanio];
            for (int i = 0; i < Array.Length; i++)
            {
                int numero = r.Next(26);

               Array[i] = (char)(((int)'A') + numero); 
            }
            Mostrar(Array, txtMostrar);
            gbOrdenamiento.Enabled=true;
        }
        public void Mostrar(Char[] A, TextBox txtMostrar)
        {
            txtMostrar.Clear();
            for (int j = 0; j < A.Length; j++)
            {
                if (j == Array.Length - 1)
                {
                    txtMostrar.Text += A[j];
                }
                else
                {
                    txtMostrar.Text += A[j] + " - ";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbOrdenamiento.Enabled=false;
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            Char aux;
            for (int i=0;i<Array.Length;i++)
            {
                for (int j = i + 1; j < Array.Length;j++)
                {
                    if (Array[i]>Array[j])// ascendente
                    {
                        aux=Array[i];
                        Array[i]=Array[j];
                        Array[j]=aux;
                    }
                }
            }
            Mostrar(Array,txtBurbuja);
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int menor = 0, posicion;
            Char aux;
            for (int i=0; i<Array.Length;i++)
            {
                //hallar el  menor elemento
                menor=Array[i];
                posicion = i;
                for (int j=i+1;j<Array.Length;j++)
                {
                    if (Array[j]<menor)
                    {
                        menor = Array[j];
                        posicion=j;
                    }
                }
                //intercambio
                if (posicion!=i)
                {
                    aux = Array[i];
                    Array[i] = Array[posicion];
                    Array[posicion]=aux;
                }
            }
            Mostrar(Array,txtSeleccion);
        }

        private void btnInserción_Click(object sender, EventArgs e)
        {
            Char actual;
            int j;
            for (int i=0;i<Array.Length;i++)
            {
                actual=Array[i];
                for (j=i;j>0 && Array[j-1]>actual;j--)
                {
                    Array[j] = Array[j - 1];

                }
                Array[j] = actual;
            }
            Mostrar(Array, txtInsercion);
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            
        }

        private void bnb_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int r=binarySearch(Array, 0, Array.Length-1, Char.Parse(txtBuscar.Text));
            if (r!=-1)
            {
                MessageBox.Show("Encontrado en la posición: " + r);
            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }

        public int binarySearch(Char[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be present
                // in right subarray
                return binarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }

    }
}