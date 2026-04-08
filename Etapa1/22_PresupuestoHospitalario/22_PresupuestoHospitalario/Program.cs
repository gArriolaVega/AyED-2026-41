using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el presupuesto anual: ");
            double anual = double.Parse(Console.ReadLine());
            double ginecologia = (anual / 10) * 4;
            double traumatologia = (anual / 10) * 3;
            double pediatria = (anual / 10) * 3;
            Console.WriteLine("Ginecologia recibe un total de: " + ginecologia);
            Console.WriteLine("Traumatologia recibe un total de: " + traumatologia);
            Console.WriteLine("Pediatria recibe un total de: " + pediatria);
            Console.ReadKey();

        } 
    }
}
