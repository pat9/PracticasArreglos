using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumenVentas
{
    public class Ventas
    {
        int[,] ventas = {
            { 5,16,10,12,24 },
            {40,55,10,11,18},
            {15,41,78,14,51 },
            {35, 22,81,15,12},
            {50,12,71,10,20 },
            {70, 40, 60,28,22},
            {50,50,50,36,25 },
            {40,70,40,11,20 },
            {20,20,30,12,18 },
            {10,40,32,13,16 },
            {50,3,24,15,82 },
            {40,46,15,46,22 }

            

        };

        int ventaMayor = 0;
        int ventaMenor = 1000000;

        public string VentaMenor()
        {
            int dia = 0;
            int mes = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(ventas[i,j] < ventaMenor)
                    {
                        ventaMenor = ventas[i, j];
                        dia = j;
                        mes = i;
                    }
                }
            }
            return "La venta mayor es: " + ventaMenor + " hecha el dia: " + dia + " el  mes: " + mes;
        }


        public string VentaMayor()
        {
            int dia = 0;
            int mes = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (ventas[i, j] > ventaMayor)
                    {
                        ventaMenor = ventas[i, j];
                        dia = j;
                        mes = i;
                    }
                }
            }
            return "La venta mayor es: " + ventaMayor + " hecha el dia: " + dia + " el  mes: " + mes;
        }

        public int Total()
        {
            int suma = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    suma = suma + ventas[i, j];
                }
            }
            return suma;
        }

        public void VentaPorDia()
        {
            int suma = 0;
            string[] Dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    suma = suma + ventas[j, i];
                }
                Console.WriteLine("El dia " + Dias[i] + " se vendio: " + suma);
            }

        }




    }
}
