using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            //declarar las variables a utilizar
            int i, s, m;
            //pedirle al usuario el primer numero
            Console.WriteLine("ingrese el primer numero");
            //convertir a enteros
            i = Convert.ToInt32(Console.ReadLine());
            //pedir que ingrese el segundo numero 
            Console.WriteLine("ingrese el segundo numero");
            //convertir a enteros
            s = Convert.ToInt32(Console.ReadLine());
            //declarar la funcion
            if (s != 0 && i != 0)
            {
                m = i / s;

                Console.WriteLine("respuesta =" + m);

            }
            else
            {
                Console.WriteLine("error no se puede dividir entre 0");
                //fin de la funcion
            }
            Console.ReadLine();
            System.Console.ReadKey();
        }
    }
}
