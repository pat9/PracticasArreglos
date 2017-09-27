using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Operaciones objCalf = new Operaciones();
            objCalf.LlenarArreglo();
            objCalf.Mostrar();
            Console.ReadKey();
        }
    }
}
