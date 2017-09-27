using System;
using System.Collections.Generic;
using System.Text;

namespace SumaPromedioFila
{
    public class Matriz
    {
        int[,] MatrizPrincipal = new int[5, 10];
        int[] SumaFilas = new int[5];
        int[] SumaColumnas = new int[10];
        int[] PromedioFilas = new int[5];
        int[] PromedioColumnas = new int[10];

        public string LlenarArreglo()
        {
            Random rnd = new Random();
            string contenido = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    MatrizPrincipal[i,j] = rnd.Next(1, 10);
                    contenido = contenido + MatrizPrincipal[i, j];
                }

                contenido = contenido + "\r\n";

            }
            return contenido;
        }

        public int[] SumarColumnas()
        {
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    suma = suma + MatrizPrincipal[j, i];
                }
                SumaColumnas[i] = suma;
                suma = 0;
            }
            return SumaColumnas;
        }

        public int[] PromediarColumnas()
        {
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    suma = suma + MatrizPrincipal[j, i];
                }
                PromedioColumnas[i] = suma/5;
                suma = 0;
            }
            return PromedioColumnas;
        }

        public int[] SumarFilas()
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    suma = suma + MatrizPrincipal[i, j];
                }
                SumaFilas[i] = suma;
                suma = 0; 
            }

            return SumaFilas;
        }

        public int[] PromediarFilas()
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    suma = suma + MatrizPrincipal[i, j];
                }
                PromedioFilas[i] = suma/10;
                suma = 0;
            }

            return PromedioFilas;
        }


    }
}
