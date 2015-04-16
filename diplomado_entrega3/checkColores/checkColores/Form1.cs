using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkColores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (chkAmarillo.Checked == true) {
                MessageBox.Show("El color selecionado es: Amarillo");
            }
            if (chkRojo.Checked == true)
            {
                MessageBox.Show("El color selecionado es: Rojo");
            }
            if (chkAzul.Checked == true)
            {
                MessageBox.Show("El color selecionado es: Azul");
            }
        }
    }
}
