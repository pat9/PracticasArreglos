using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuadroMagico
{
    public partial class Form1 : Form
    {
        CuadroMagico objCuadro = new CuadroMagico();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int NumeroColumnas = Convert.ToInt32(txtColumnas.Text);
            int AnchoBoton = PanelCuadro.Width / NumeroColumnas;
            int NumeroFilas = Convert.ToInt32(txtFilas.Text);
            int LargoBoton = PanelCuadro.Height / NumeroFilas;
            int AnchoOcupado = 0;
            int LargoOcupado = 0;

            for (int i = 0; i < NumeroFilas; i++)
            {

                for (int j = 0; j < NumeroColumnas; j++)
                {
                    TextBox TxtDinamico = new TextBox();
                    TxtDinamico.Multiline = true;
                    TxtDinamico.Font = new Font("Arial", 14);
                    TxtDinamico.Width = AnchoBoton;
                    TxtDinamico.Height = LargoBoton;
                    TxtDinamico.Location = new Point(AnchoBoton * j, LargoBoton * i);
                    TxtDinamico.Name = "txt" + i + j;
                    AnchoOcupado = AnchoOcupado + AnchoBoton;
                    PanelCuadro.Controls.Add(TxtDinamico);
                }
                LargoOcupado = LargoBoton + LargoOcupado;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Filas = Convert.ToInt32(txtFilas.Text);
            int Columnas = Convert.ToInt32(txtColumnas.Text);
            int[,] Cuadro = new int[Filas, Columnas];

            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    TextBox Valor = (TextBox)PanelCuadro.Controls[i + j];
                    Cuadro[i, j] = Convert.ToInt32(Valor.Text);
                }
            }


            if (objCuadro.ComprobarCuadro(Cuadro, Filas, Columnas))
            {
                MessageBox.Show("Es un cuadro magico");
            }
            else
            {
                MessageBox.Show("No es un cuadro magico");
            }
                
        }
    }
}

