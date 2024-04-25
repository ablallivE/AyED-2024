using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Villalba_MiPrimerMenuObjetivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = 0;
            
            Console.WriteLine("*bienvendio al programa*");
            Console.WriteLine("elija una de las opciones");
            Console.WriteLine("1 suma de numeros");
            Console.WriteLine("2 resta de numeros");
            Console.WriteLine("3 multiplicacion de numeros");
            Console.WriteLine("4 salir");

            while (numero != 4)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero == 1)
                {
                    Console.WriteLine("*menu 1: suma de numeros*");
                    Console.WriteLine("elije 2 numeros para sumarlos");
                    int num1;
                    num1 = int.Parse(Console.ReadLine());

                    int num2;
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("esta es el resultado " + (num1 + num2));

                    Console.WriteLine("*elija una de las opciones de nuevo*");
                    Console.WriteLine("1 suma de numeros");
                    Console.WriteLine("2 resta de numeros");
                    Console.WriteLine("3 multiplicacion de numeros");
                    Console.WriteLine("4 salir");
                    
                }
                if (numero == 2)
                {
                    Console.WriteLine("*menu 2: resta de numeros*");
                    Console.WriteLine("elije 2 numeros para restarlos");
                    int num3;
                    num3 = int.Parse(Console.ReadLine());

                    int num4;
                    num4 = int.Parse(Console.ReadLine());

                    Console.WriteLine("*esta es el resultado*" + (num3 - num4));

                    Console.WriteLine("elija una de las opciones de nuevo");
                    Console.WriteLine("1 suma de numeros");
                    Console.WriteLine("2 resta de numeros");
                    Console.WriteLine("3 multiplicacion de numeros");
                    Console.WriteLine("4 salir");
                    
                }
                if (numero == 3)
                {
                    Console.WriteLine("*menu 3: multiplicacion de numeros*");
                    Console.WriteLine("elije 2 numeros para multiplicarlos");
                    int num5;
                    num5 = int.Parse(Console.ReadLine());

                    int num6;
                    num6 = int.Parse(Console.ReadLine());

                    Console.WriteLine("*esta es el resultado*" + (num5 * num6));

                    Console.WriteLine("elija una de las opciones de nuevo");
                    Console.WriteLine("1 suma de numeros");
                    Console.WriteLine("2 resta de numeros");
                    Console.WriteLine("3 multiplicacion de numeros");
                    Console.WriteLine("4 salir");
                    
                }    
                if(numero >= 5 )
                {
                    Console.WriteLine("elija una de las opciones de nuevo");
                    Console.WriteLine("1 suma de numeros");
                    Console.WriteLine("2 resta de numeros");
                    Console.WriteLine("3 multiplicacion de numeros");
                    Console.WriteLine("4 salir");

                }         
            }
            Console.WriteLine("hasta luego");
            Console.ReadKey();

        }
    }
}
