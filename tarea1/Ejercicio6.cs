using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
           /*PORFAVOR LEER: en este programa por ejemplo si ingresamos de nota: 10,10,10 de nota final da 9 porque
           si sumamos el porcetaje de las notes que son 35%, 30% y 25% da 90% por eso es que en el caso hipotetico
           que solo tuviera 10 en las tres notas sacaria 9*/

            //declarar las variables como decimales
            double Nota1, Nota2, Nota3, promedio;
            //pedir al usuario la primera nota
            Console.WriteLine("ingrese la primera nota");
            //convertirla la primera nota a decimal
            Nota1 = Convert.ToDouble(Console.ReadLine());
            //pedir al usuario la segunda  nota
            Console.WriteLine("Ingrese la segunda nota");
            //convertir nota2 a decimal
            Nota2 = Convert.ToDouble(Console.ReadLine());
            //pedir al usuario la tercera nota
            Console.WriteLine("ingrese la tercera nota");
            //convertir nota3 a decimal 
            Nota3 = Convert.ToDouble(Console.ReadLine());

            //mostrar notas por cada porcentaje respectivo
            Console.WriteLine("--------------------------");
            Console.WriteLine("Nota 1 30% = {0}", Nota1);
            Console.WriteLine("Nota 2 35% = {0}", Nota2);
            Console.WriteLine("Nota 3 25% = {0}", Nota3);

            Nota1 = Nota1 * 0.30;
            Nota2 = Nota2 * 0.35;
            Nota3 = Nota3 * 0.25;

            //sumar las tres notas para sacar el promedio 
            promedio = Nota1 + Nota2 + Nota3;
            Console.WriteLine("--------------------------");

            Console.WriteLine("Nota final=" + promedio);
            //mostrar la nota final mas promedio 

            System.Console.ReadKey();
        }
    }
}
