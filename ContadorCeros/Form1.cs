using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContadorCeros
{
    public partial class Form1 : Form
    {
        Contador objContador = new Contador();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            rtcArreglo.Text = objContador.GenerarArreglo();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int[] ContadorCeros = objContador.intContarCeros();
            txtF1.Text = ContadorCeros[0].ToString();
            txtF2.Text = ContadorCeros[1].ToString();
            txtF3.Text = ContadorCeros[2].ToString();
            txtF4.Text = ContadorCeros[3].ToString();
            txtF5.Text = ContadorCeros[4].ToString();
        }

        private void txtCeros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
