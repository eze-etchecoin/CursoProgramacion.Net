using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostoLlamadas
{
    class Program
    {
        static string[] codigoPais = new string[9];
        static string[] nombreZona = new string[9];
        static decimal[] precioMinuto = new decimal[9];


        static void Main(string[] args)
        {
            llenarArrayConDatos();
            
            Console.WriteLine("Ingrese el código de país...");
            string zona = Console.ReadLine();

            Console.WriteLine("Ingrese la duración en segundos...");
            int duracion = Convert.ToInt32(Console.ReadLine());

            decimal precio = calcularCostoLlamada(zona, duracion);

            if(precio == -1m)
            {
                Console.WriteLine("Zona no encontrada");
            }
            else
            {
                string destino = obtenerZona(zona);

                Console.WriteLine("El costo de la llamada a " + destino + " es: " + precio);
            }
            
       
            Console.ReadKey();
        }

        static void llenarArrayConDatos()
        {

            codigoPais[0] = "01";
            nombreZona[0] = "Estados Unidos";
            precioMinuto[0] = 0.13m;

            codigoPais[1] = "02";
            nombreZona[1] = "Canadá";
            precioMinuto[1] = 0.11m;

            codigoPais[2] = "05";
            nombreZona[2] = "América del Sut";
            precioMinuto[2] = 0.22m;

            codigoPais[3] = "06";
            nombreZona[3] = "América Central";
            precioMinuto[3] = 0.19m;

            codigoPais[4] = "07";
            nombreZona[4] = "México";
            precioMinuto[4] = 0.17m;

            codigoPais[5] = "09";
            nombreZona[5] = "Europa";
            precioMinuto[5] = 0.17m;

            codigoPais[6] = "10";
            nombreZona[6] = "Asia";
            precioMinuto[6] = 0.20m;

            codigoPais[7] = "15";
            nombreZona[7] = "África";
            precioMinuto[7] = 0.39m;

            codigoPais[8] = "20";
            nombreZona[8] = "Oceanía";
            precioMinuto[8] = 0.28m;
        }

        static decimal calcularCostoLlamada(string zona, int duracionLlamadaEnSegundos)
        {
            int columna = -1;
            for (int i = 0; i <= 8; i++)
            {
                if (zona == codigoPais[i])
                {
                    columna = i;
                    break;
                }
            }

            if(columna == -1)
            {
                return -1m;
            }
            decimal precio = precioMinuto[columna] * (duracionLlamadaEnSegundos/60m);

            return precio;
        }

        static string obtenerZona(string zona)
        {
            int columna = 0;
            for (int i = 0; i <= 8; i++)
            {
                if (zona == codigoPais[i])
                {
                    columna = i;
                    break;
                }
            }
            return nombreZona[columna];
        }


    }
}
