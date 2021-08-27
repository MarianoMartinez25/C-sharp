using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma;
            float promedio;
            string linea;
            Console.Write("Ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese el tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.Write("Ingrese el cuarto numero: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);
            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;
            Console.Write("La suma de los cuatro numeros es: ");
            Console.WriteLine(suma);
            Console.Write("El promedio es: ");
            Console.WriteLine(promedio);
            Console.ReadKey();
        }
    }
}


