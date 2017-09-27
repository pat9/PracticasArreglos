using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MatrizCuadrada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int filas = 0;
            int.TryParse(textBox1.Text, out filas);

            Matriz objMat = new Matriz();

            objMat.Generar(filas);
            rtcArreglo.Text = objMat.Mostrar(filas);


        }
    }
}
