using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerdeCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir mensaje
            Console.WriteLine("Bienvenido a C#");

            //-- Definir variables --
            int a, b, producto;

            //Entrada datos
            Console.WriteLine("Ingrese Primer Numero");

            //Guardar vaolor de la consola
            a = int.Parse(Console.ReadLine());
            //a = int.TryParse(Console.ReadLine()); //boolean true o face

            Console.WriteLine("Ingrese segundo Numero");
            //Guardar vaolor de la consola
            b = Convert.ToInt32(Console.ReadLine());
            //a = int.TryParse(Console.ReadLine()); //boolean true o face

            //-- prceso --
            producto = a * b;

            //-- salida datos--
            Console.WriteLine("El producto es: " + (producto + 2));
            Console.WriteLine($"el producto de {a} * {b} = {producto}");


            //Detener pantalla para mostrar resultado
            Console.ReadKey();
        }
    }
}
