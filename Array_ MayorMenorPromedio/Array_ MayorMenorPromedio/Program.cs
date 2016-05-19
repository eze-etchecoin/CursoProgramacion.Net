using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array__MayorMenorPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] a = new decimal[10];
            
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Ingrese el elemento nº" + (i + 1));
                a[i] = Convert.ToDecimal(Console.ReadLine());
            }

            decimal mayor = a[0];
            decimal menor = a[0];
            decimal suma = a[0];

            for (int i = 1; i < 10; i++)
            {
                if(a[i] > mayor)
                {
                    mayor = a[i];
                }
                if(a[i] < menor)
                {
                    menor = a[i];
                }
                suma += a[i];
            }

            decimal promedio = suma / 10;

            Console.WriteLine("\nEl mayor elemento es: " + mayor);
            Console.WriteLine("El menor elemento es: " + menor);
            Console.WriteLine("El promedio de los elementos es: " + promedio);

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
