using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    public class Operaciones
    {
        double[,] calf = new double[12, 3];
        double promedio = 0;
        double suma = 0;
        double mayor = 0;
        double menor = 11;
        int reprobados;
        int[] distribucion = new int[6];


        public void LlenarArreglo()
        {
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    calf[i, j] = Math.Round(rnd.Next(0, 10) + rnd.NextDouble(),1);
                    Console.Write(calf[i, j] + " || ");
                }
                Console.Write("\n");
            }
        }

        public void Mostrar()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma = suma + calf[i, j];
                }

                promedio = suma / 3;

                Console.WriteLine("El promedio del alumno: " + (i+1) + " es: " + Math.Round(promedio, 1));

                if (promedio > mayor)
                {
                    mayor = promedio;
                }
                if(promedio < menor)
                {
                    menor = promedio;
                }
                if(promedio < 7)
                {
                    reprobados++;
                }
                if(promedio >= 0 && promedio <=4.9)
                {
                    distribucion[0]++;
                }
                else if(promedio >= 5 && promedio <= 5.9)
                {
                    distribucion[1]++;
                }
                else if (promedio >= 6 && promedio <= 6.9)
                {
                    distribucion[2]++;
                }
                else if (promedio >= 7 && promedio <= 7.9)
                {
                    distribucion[3]++;
                }
                else if (promedio >= 8 && promedio <= 8.9)
                {
                    distribucion[4]++;
                }
                else if (promedio >= 9 && promedio <= 10)
                {
                    distribucion[5]++;
                }

                promedio = 0;
                suma = 0;
                



            }
            Console.WriteLine("El promedio mas alto es: " + mayor);
            Console.WriteLine("El promedio mas bajo es: " + menor);
            Console.WriteLine("El numero de parciales reprobados es: " + reprobados);
            Console.WriteLine("Las calificaciones entre 0 y 4.9: " + distribucion[0]);
            Console.WriteLine("Las calificaciones entre 5 y 5.9: " + distribucion[1]);
            Console.WriteLine("Las calificaciones entre 6 y 6.9: " + distribucion[2]);
            Console.WriteLine("Las calificaciones entre 7 y 7.9: " + distribucion[3]);
            Console.WriteLine("Las calificaciones entre 8 y 8.9: " + distribucion[4]);
            Console.WriteLine("Las calificaciones entre 9 y 10:  " + distribucion[5]);
        }
         
    }
}
