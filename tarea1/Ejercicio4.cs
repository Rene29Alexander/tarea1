using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            //Se capturan los datos que se quierem operar
            Console.WriteLine("Ingrese la temperatura en grados centigrados que decee trasformar a fahrenheit: ");
            double grados = Convert.ToDouble(Console.ReadLine());

            //Se hace la convercio de centigrados a fahrenheit
            double resultado;
            resultado = grados * 9 / 5 + 32;

            //se imprime el resultado
            Console.WriteLine("el resultado en grados fahrenheit es: {0}", resultado);

            Console.ReadKey();

        }
    }
}
