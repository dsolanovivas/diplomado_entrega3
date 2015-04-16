using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaadioButtonCal
{
    public partial class Form1 : Form
    {
        Double num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtsuma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtsuma_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Double.Parse(textBox1.Text);
                num2 = Double.Parse(textBox2.Text);
                MessageBox.Show("La suma es : " + (num1 + num2));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al tratar de sumar " + textBox1.Text
                    + " con " + textBox2.Text + ex.Message);
            }
        }

        private void rbtresta_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Double.Parse(textBox1.Text);
                num2 = Double.Parse(textBox2.Text);
                MessageBox.Show("La resta es : " + (num1 - num2));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al tratar de restar " + textBox1.Text
                    + " con " + textBox2.Text + ex.Message);
            }
            
        }

        private void rbtmul_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Double.Parse(textBox1.Text);
                num2 = Double.Parse(textBox2.Text);
                MessageBox.Show("La multiplicación es : " + (num1 * num2));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al tratar de multiplicar " + textBox1.Text
                    + " con " + textBox2.Text + ex.Message);
            } 
        }

        private void rbtdiv_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Double.Parse(textBox1.Text);
                num2 = Double.Parse(textBox2.Text);
                MessageBox.Show("La division es : " + (num1 / num2));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al tratar de dividir " + textBox1.Text
                    + " con " + textBox2.Text + ex.Message);
            }
        }



        
    }
}
