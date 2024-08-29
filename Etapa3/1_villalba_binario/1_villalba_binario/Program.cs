using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_villalba_binario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero a convertir");
            Binario(int.Parse(Console.ReadLine()));
            Console.WriteLine("ingrese el numero a convertir");
            BinarioADecimal(Console.ReadLine());



            Console.ReadKey();
        }
        static int Binario(int numeroB)
        {
            int auxiliar = numeroB;

            string B = "";

            while (auxiliar != 0)
            {

                if (auxiliar % 2 == 0)
                {
                    B = "0" + B;
                }
                else if (auxiliar % 2 == 1)
                {
                    B = "1" + B;
                }
                auxiliar = auxiliar / 2;
            }
            numeroB = int.Parse(B);
            Console.WriteLine(numeroB);
            return numeroB;
        }

        static int BinarioADecimal(string input)
        {
            char[] array = input.ToCharArray();
            // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    sum += (int)Math.Pow(2, i);
                }
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
