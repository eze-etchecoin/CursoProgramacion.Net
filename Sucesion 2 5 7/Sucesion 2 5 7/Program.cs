using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucesion_2_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; //Para los números de la sucesión.
            int termino = 0; //Para determinar el nº de término de la sucesión.
            int suma = 0; //Para sumar los números de la sucesión.

            while (num < 1800)
            {
                ++termino;

                //Si el término de la sucesión es impar, suma 2 al anterior.
                if (termino % 2 == 1)
                {
                    num = num + 2;
                }

                //Si el término de la sucesión es par, suma 3 al anterior.
                if (termino % 2 == 0)
                {
                    num = num + 3;
                }

                //Sumamos el número actual al total
                suma = suma + num;

                Console.WriteLine(num);

                //Esto es sólo para comprobar si la sucesión esta bien generada,
                //antes de imprimir hasta 1800.
                if (termino == 10)
                {
                    Console.WriteLine("Revise si la sucesión se esta generando correctamente.");
                    Console.WriteLine("La suma de los términos es " + suma);
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey();
                }

                //Esto es para demorar un poquito la impresión.
                System.Threading.Thread.Sleep(2);
            }

            Console.WriteLine("La suma de los términos es " + suma);
            Console.WriteLine("Pulse una tecla para concluir...");
            Console.ReadKey();
        }
    }
}
