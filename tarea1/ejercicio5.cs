using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    class ejercicio5
    {
        static void Main(string[] args)
        {
            // se capturan los datos con los que se quiere operar
            Console.WriteLine("Ingrese el precio del productos que desee comprar: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El producto que esta pagando es medicina? si/no:");
            string iva = Console.ReadLine();

            //Se hace la condicio if si el producto es medicina
            if (iva == "si" || iva== "SI")
            {
                Console.WriteLine("El productos es medicina asi que no se le cobra impuestos, el precio es: {0}", precio);
            }

            //Se hace la condicion else if si el producto no es medicina
            else if (iva == "no" || iva == "NO")
            {
                double precio_porcentaje;
                precio_porcentaje = precio * 13.00 / 100;

                double precio_final;
                precio_final = precio + precio_porcentaje;

                Console.WriteLine("El precio con IVA es: {0}", precio_final);

            }

            //se coloca else si las condiciones anteriores no se cumplen
            else
            {
                Console.WriteLine("la respuesta de, si el producto era medicina o no, no es valida");
            }

            Console.ReadKey();
        }
    }
}
