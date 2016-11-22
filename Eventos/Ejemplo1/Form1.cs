using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Biblioteca.Cuenta cuenta;
        public Form1()
        {
            InitializeComponent();
            this.cuenta = new Biblioteca.Cuenta();
            this.cuenta.SaldoNegativo += new Biblioteca.CuentaDelegado(this.MostrarSaldoNegativo);
        }

        public void MostrarSaldoNegativo(float dinero) 
        {
            MessageBox.Show(dinero.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cuenta.SacarDinero(1000);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox1_KeyPress");
        }
        private void textBox1_KeyPress2(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox1_KeyPress2");
        }
        private void mio(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("mio");
        }
    }
}
