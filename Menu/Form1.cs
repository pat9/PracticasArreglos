using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            ContadorCeros.Form1 frm = new ContadorCeros.Form1();
            frm.Show();

        }

        private void btnCalf_Click(object sender, EventArgs e)
        {
           

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            ParDeArreglos.Form1 frm = new ParDeArreglos.Form1();
            frm.Show();
        }

        private void btnMagico_Click(object sender, EventArgs e)
        {
            CuadroMagico.Form1 frm = new CuadroMagico.Form1();
            frm.Show();
        }

        private void btnPromSal_Click(object sender, EventArgs e)
        {
            SumaPromedioFila.Form1 frm = new SumaPromedioFila.Form1();
            frm.Show();
        }

        private void btnDiagonal_Click(object sender, EventArgs e)
        {
            MatrizCuadrada.Form1 frm = new MatrizCuadrada.Form1();
            frm.Show();

        }
    }
}
