using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nota;

            Console.WriteLine("Ingrese la cantidad de alumnos...");
            n = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();

            for (int i = 1; i <= n; i++)
            {
                nota = r.Next(1, 11);
                Console.Write("Alumno " + i + "\t" + nota + "\t");
                for (int j = 0; j < nota; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
