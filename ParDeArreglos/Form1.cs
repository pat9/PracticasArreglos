using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParDeArreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ParArreglos objArreglos = new ParArreglos();
            objArreglos.Arreglo1 = new int[2, 2];
            objArreglos.Arreglo2 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    TextBox TxtA1 = (TextBox)panelA1.Controls[i + j];
                    TextBox TxtA2 = (TextBox)PanelA2.Controls[i + j];
                    objArreglos.Arreglo1[i, j] = Convert.ToInt32(TxtA1.Text);
                    objArreglos.Arreglo2[i, j] = Convert.ToInt32(TxtA2.Text);
                }
            }

            lstSuma.DataSource = objArreglos.Suma();
            lstResta.DataSource = objArreglos.Resta();
            lstDivision.DataSource = objArreglos.Division();
            lstProd.DataSource = objArreglos.Producto();



        }
    }
}
