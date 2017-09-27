using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SumaPromedioFila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Matriz objMat = new Matriz();

            rtbArreglo.Text = objMat.LlenarArreglo();
            int[] SumaFilas = objMat.SumarFilas();
            int[] SumaColumnas = objMat.SumarColumnas();
            int[] PromedioFilas = objMat.PromediarFilas();
            int[] PromedioColumnas = objMat.PromediarColumnas();

            for (int i = 0; i < 5; i++)
            {
                panelSumasF.Controls[i].Text = SumaFilas[i].ToString();
                panelPromedio.Controls[i].Text = PromedioFilas[i].ToString();
            }

            for (int i = 0; i <10 ; i++)
            {
                panelSumasCol.Controls[i].Text = SumaColumnas[i].ToString();
                panelPromCol.Controls[i].Text = PromedioColumnas[i].ToString();
            }


        }
    }
}
