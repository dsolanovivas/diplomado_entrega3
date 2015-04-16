using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxNavegadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        { 
            this.Text="";
            if (chkfirefox.Checked == true)
            {
                Text = Text + " Google Chrome ";
            }
            if (chkgoogle.Checked == true)
            {
                Text = Text + " Mozilla Firefox ";
            }
            if (chksafari.Checked == true)
            {
                Text = Text + " safari ";
            }
        }
    }
}
