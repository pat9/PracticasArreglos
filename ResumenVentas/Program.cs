using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumenVentas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ventas objV = new Ventas();
            Console.WriteLine(objV.VentaMayor());
            Console.WriteLine(objV.VentaMenor());

            Console.WriteLine("El total de ventas es: " + objV.Total());
            objV.VentaPorDia();
            Console.ReadKey();


        }
    }
}
