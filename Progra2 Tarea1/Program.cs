using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2_Tarea1
{
    class Program
    {
        static void Main()
        {
            int n = 10;

           
            if (n > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else
            {
                Console.WriteLine("El número es negativo o cero.");
            }

            Console.WriteLine("Ingresa un número del 1 al 5:");
            int numero = Convert.ToInt32(Console.ReadLine());

            
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                default:
                    Console.WriteLine("Ingresa otro numero");
                    break;
            }
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            int contador = 1;
            while (contador <= 5)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }
    }
}
