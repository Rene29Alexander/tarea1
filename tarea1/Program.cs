using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {   //Capturamos los datos
            Console.WriteLine("escriba un numero: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("escriba otro numero: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //Se realizan las operaciones
            double resultado_1;
            resultado_1 = a + b * a - b;

            double resultado_2;
            resultado_2 = a * 2 - b;

            //Imprimimos los resultados
            Console.WriteLine("El resultado de el primer valor es: {0}", resultado_1);

            Console.WriteLine("El resultado de la segunda segunda operacion es:{0}", resultado_2);

            Console.ReadKey();




            
            

         
           

        }
    }
}
