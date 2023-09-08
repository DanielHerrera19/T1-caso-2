using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudocodigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();

            // Pedir al cliente la cantidad de vehículos
            Console.Write("Ingrese la cantidad de vehículos a enviar: ");
            int vehiculo = int.Parse(Console.ReadLine());

            // Calculamos el precio de envío
            int precio = (vehiculo * vehiculo) - (2 * vehiculo) + 1;

            string calificacion;

            // Según la calificación haremos que tenga un mensaje

            if (precio >= 61)
            {
                calificacion = "Excelente";
            }
            else if (precio >= 31 && precio <= 60)
            {
                calificacion = "Bueno";
            }
            else if (precio >= 11 && precio <= 30)
            {
                calificacion = "Medio";
            }
            else if (precio >= 0 && precio <= 10)
            {
                calificacion = "Bajo";
            }
            else
                calificacion = "Error";

         
            // Mostrar el costo y la calificación
            Console.WriteLine("El costo por envío del cliente " + nombre + " para " + vehiculo + " vehículos es de: " + precio + " soles");
            Console.WriteLine("La calificación del precio es de: " + calificacion);
        }
    }
}