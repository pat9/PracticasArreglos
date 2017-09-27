using System;
using System.Collections.Generic;
using System.Text;

namespace ContadorCeros
{
    public class Contador
    {
        private int[,] Arreglo = new int[5,5]; 
        public string GenerarArreglo()
        {
            Random Rdn = new Random();
            string ArregloGenerado = "";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Arreglo[i, j] = Rdn.Next(0, 10);
                    ArregloGenerado = ArregloGenerado + Arreglo[i, j] + " "; 
                }
                ArregloGenerado = ArregloGenerado + "\n\r";
            }

            return ArregloGenerado;
        }

        public int[] intContarCeros()
        {

            int[] CerosFilas = new int[5];


            for (int j = 0; j < 5; j++)
            {
                if(Arreglo[0,j] == 0)
                {
                    CerosFilas[0]++;
                }
                else if (Arreglo[1,j] == 0)
                {
                    CerosFilas[1]++;
                }
                else if(Arreglo[2, j] == 0)
                {
                    CerosFilas[2]++;
                }
                else if (Arreglo[3, j] == 0)
                {
                    CerosFilas[3]++;
                }
                else if (Arreglo[4, j] == 0)
                {
                    CerosFilas[4]++;
                }
            }
            return CerosFilas;

        }



    }
}
