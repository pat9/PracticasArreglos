using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CuadroMagico
{
    public class CuadroMagico
    {

        public bool ComprobarCuadro(int[,] Cuadro, int Filas, int Columnas)
        {
            int SumaAnterior = 0;
            int SumaActual = 0;
            int SumaDiagonal = 0;

            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    SumaActual = SumaActual + Cuadro[i, j];
                    if(i==j)
                    {
                        SumaDiagonal = SumaDiagonal + Cuadro[i, j];
                    }
                }
                if(SumaActual != SumaAnterior)
                {
                    return false;
                }
                else
                {
                    SumaAnterior = SumaActual;
                    SumaActual = 0;
                }
            }

            if(SumaActual == SumaDiagonal)
            {
                return true;
            }
            else
            {
                return false;
            }



        }


    }
}
