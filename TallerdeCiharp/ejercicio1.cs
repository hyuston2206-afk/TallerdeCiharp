using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerdeCiharp
{
    public class ejercicio1
    {
        public void areatriangulo()
        {

            // solicitar dato
            Console.WriteLine("Ingrse lado a");
            //guardar datos
            var a = int.Parse(Console.ReadLine());
            // solicitar dato
            Console.WriteLine("Ingrse lado b");
            //guardar datos
            var b = int.Parse(Console.ReadLine());
            // solicitar dato
            Console.WriteLine("Ingrse lado c");
            //guardar datos
            var c = int.Parse(Console.ReadLine());

            //proceso
            var s = (a + b + c) / 2; // s = semiperimetro
            var area = Math.Sqrt(s *(s - a)* (s - b) * (s - c));

            //salida de datos 
            Console.WriteLine($"El ara del triangulo segun lados{a},{b},{c} es: {area} m2 ");

            Console.WriteLine(); //saltoo de linea
            Console.WriteLine("Algoritmo adre triangulo");
            
            ejercicio1 ej1 = new ejercicio1(); 
            ej1.areatriangulo();
            //detener pantalla para ver resultados
            Console.ReadKey();
        }

    }
}
