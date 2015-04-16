using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTextBox
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            double num1,num2;
            try
            {
                num1 = double.Parse(txtnum1.Text);
                num2 = double.Parse(txtnum2.Text);
                txtres.Text = "" + (num1 + num2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Valor no es un numero : " + ex.Message);
                txtnum1.Focus();
            }
  
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtres.Text="";
            txtnum1.Text = "";
            txtnum2.Text = "";

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtnum1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            txtnum2.Focus();
        }

        private void txtnum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            btnaceptar.Focus();
        }
    }
}
