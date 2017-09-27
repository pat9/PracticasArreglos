using System;
using System.Collections.Generic;
using System.Text;

namespace MatrizCuadrada
{
    public class Matriz
    {
        int[,] Arreglo;

        public void Generar(int filas)
        {
            Arreglo = new int[filas, filas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    if(i==j)
                    {
                        Arreglo[i, j] = 1;
                    }
                    else
                    {
                        Arreglo[i, j] = 0;
                    }
                }
            }
        }

        public string Mostrar(int filas)
        {
            string contenido = "";
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    contenido = contenido + Arreglo[i, j];
                }
                contenido = contenido + "\r\n";
            }
            return contenido;
        }

    }
}
