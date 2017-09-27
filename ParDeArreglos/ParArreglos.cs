using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ParDeArreglos
{
    public class ParArreglos
    {
        public int[,] Arreglo1 { get; set; }
        public int[,] Arreglo2 { get; set; }

        public ArrayList Suma()
        {
            ArrayList listaSuma = new ArrayList();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int Suma = Arreglo1[i, j] + Arreglo2[i, j];
                    listaSuma.Add(Suma);
                }
            }
            return listaSuma;
        }

        public ArrayList Resta()
        {
            ArrayList listaResta = new ArrayList();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int Resta = Arreglo1[i, j] - Arreglo2[i, j];
                    listaResta.Add(Resta);
                }
            }
            return listaResta;
        }

        public ArrayList Producto()
        {
            ArrayList listaProd = new ArrayList();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int Producto = Arreglo1[i, j] * Arreglo2[i, j];
                    listaProd.Add(Producto);
                }
            }
            return listaProd;
        }

        public ArrayList Division()
        {
            ArrayList listaDiv = new ArrayList();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int Div = Arreglo1[i, j] / Arreglo2[i, j];
                    listaDiv.Add(Div);
                }
            }
            return listaDiv;
        }



    }
}
