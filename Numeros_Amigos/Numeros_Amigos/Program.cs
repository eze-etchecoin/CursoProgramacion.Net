using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Amigos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, mayor;
            int div;
            int sumadivn = 0;
            int sumadivm = 0;

            Console.WriteLine("Análisis: Números amigos\n");
            Console.WriteLine("Ingrese el 1er número. Ingrese 0 para salir...");

            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0) //Opcíón de salida del programa
            {
                Console.WriteLine("Ingrese el 2do número");
                m = Convert.ToInt32(Console.ReadLine());

                //Selecciona el mayor número de los dos. Luego, en el bucle 'for',
                //se analizan solo la mitad de los posibles divisores del mayor número,
                //ya que el máximo divisor de un número es su mitad. Esto es para
                //mejorar la eficiencia del bucle.
                if (m > n)
                {
                    mayor = m;
                }
                else
                {
                    mayor = n;
                }

                for(div = 1; div <= (mayor/2); div++)
                {
                    if(n % div == 0)
                    {
                        sumadivn = sumadivn + div;
                    }

                    if(m % div == 0)
                    {
                        sumadivm = sumadivm + div;
                    }
                }

                //Se analiza la suma de los divisores de cada número con su otro par.
                if(sumadivn == m && sumadivm == n)
                {
                    if(m == n) //Este es un agregado mío. Si es amigo de sí mismo, es un número perfecto.
                    {
                        Console.WriteLine(n + " ES AMIGO DE SÍ MISMO. ES UN NÚMERO PERFECTO!.\n");
                    }
                    else
                    {
                        Console.WriteLine(n + " Y " + m + " SON AMIGOS.\n");
                    }
                }
                else
                {
                    Console.WriteLine(n + " Y " + m + " NO SON AMIGOS.\n");
                }

                //Se resetean los acumuladores para analizar nuevos números.
                sumadivn = 0;
                sumadivm = 0;
                Console.WriteLine("De nuevo? Ingrese el 1er número. Ingrese 0 para salir...");
                n = Convert.ToInt32(Console.ReadLine());

            }

        }
    }
}
