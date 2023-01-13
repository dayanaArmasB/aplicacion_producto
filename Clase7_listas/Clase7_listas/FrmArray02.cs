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
    public partial class FrmArray02 : Form
    {

        Util myvectorclass2 = new Util();
        Util myvectorclass1 = new Util();
        public FrmArray02()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void grp_Vector1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //suma de los componentes de los vectores 1 y 2 
            Util myvectorclasssum  = new Util();

            myvectorclasssum = myvectorclass1 + myvectorclass2;
            string mresult = "";
            mresult = "El vector suma es :\n ";
            for (int i = 0; i < myvectorclasssum.vec.Length; i++)
            {
                mresult  += myvectorclasssum.vec[i].ToString() + "\n ";
            }

            txt_result.Text = mresult;
        }

        private void btn_aleatorios_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //componentes del vector 1    
            txt_component1_1.Text = random.Next(1, 10).ToString();
            txt_component1_2.Text = random.Next(1, 10).ToString();
            txt_component1_3.Text = random.Next(1, 10).ToString();
            txt_component1_4.Text = random.Next(1, 10).ToString();
            txt_component1_5.Text = random.Next(1, 10).ToString();
            //componentes del vector 2
            txt_component2_1.Text = random.Next(1, 10).ToString();
            txt_component2_2.Text = random.Next(1, 10).ToString();
            txt_component2_3.Text = random.Next(1, 10).ToString();
            txt_component2_4.Text = random.Next(1, 10).ToString();
            txt_component2_5.Text = random.Next(1, 10).ToString();

            myvectorclass1.vec[0] = Convert.ToInt32(txt_component1_1.Text);
            myvectorclass1.vec[1] = Convert.ToInt32(txt_component1_2.Text);
            myvectorclass1.vec[2] = Convert.ToInt32(txt_component1_3.Text);
            myvectorclass1.vec[3] = Convert.ToInt32(txt_component1_4.Text);
            myvectorclass1.vec[4] = Convert.ToInt32(txt_component1_5.Text);
            myvectorclass2.vec[0] = Convert.ToInt32(txt_component2_1.Text);
            myvectorclass2.vec[1] = Convert.ToInt32(txt_component2_2.Text);
            myvectorclass2.vec[2] = Convert.ToInt32(txt_component2_3.Text);
            myvectorclass2.vec[3] = Convert.ToInt32(txt_component2_4.Text);
            myvectorclass2.vec[4] = Convert.ToInt32(txt_component2_5.Text);
            //componentes del vector 2    
            //for (int i = 0; i < myvectorclass2.vec.Length; i++)
            //{
            //    myvectorclass2.vec[i] = random.Next(1, 10);
            //}
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_component1_1.Clear();
            txt_component1_2.Clear();
            txt_component1_3.Clear();
            txt_component1_4.Clear();
            txt_component1_5.Clear();
            txt_component2_1.Clear();
            txt_component2_2.Clear();
            txt_component2_3.Clear();
            txt_component2_4.Clear();
            txt_component2_5.Clear();
            txt_result.Clear();
        }
    }
}
