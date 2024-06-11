using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_villalba_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Console.WriteLine("ingrese un valor");
            int[] vector = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < vector.Count(); i++)
            {
                int respuesta = aleatorio.Next(0, 100);
                vector[i] = respuesta;
            }
            Console.WriteLine("BIENVENIDO AL MENU");
            Console.WriteLine("1- todos los elementos .");
            Console.WriteLine("2- ascendente ");
            Console.WriteLine("3- descendente ");
            Console.WriteLine("4- busqueda de numero dentro de los generados . ");
            Console.WriteLine("5- salir.");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion != 5)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("estos son los elementos");
                        for (int i = 0; i < vector.Count(); i++)
                        {
                            Console.WriteLine(vector[i]);


                        }
                        Console.WriteLine("BIENVENIDO AL MENU");
                        Console.WriteLine("1- todos los elementos .");
                        Console.WriteLine("2- ascendente ");
                        Console.WriteLine("3- descendente ");
                        Console.WriteLine("4- busqueda de numero dentro de los generados . ");
                        Console.WriteLine("5- salir.");
                        opcion = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        for (int i = 0; i < vector.Length; i++)
                        {
                            for (int j = 0; j < vector.Length - 1; j++)
                            {
                                if (vector[j] < vector[j + 1])
                                {
                                    int temp = vector[j];
                                    vector[j] = vector[j + 1];
                                    vector[j + 1] = temp;

                                }

                            }

                        }
                        for (int j = 0; j < vector.Count(); j++)
                        {
                            Console.WriteLine(vector[j]);
                        }
                        Console.WriteLine("BIENVENIDO AL MENU");
                        Console.WriteLine("1- todos los elementos .");
                        Console.WriteLine("2- ascendente ");
                        Console.WriteLine("3- descendente ");
                        Console.WriteLine("4- busqueda de numero dentro de los generados . ");
                        Console.WriteLine("5- salir.");
                        opcion = int.Parse(Console.ReadLine());
                        break;

                    case 3:


                        Console.WriteLine("-Orden descendente-");
                        for (int i = 0; i < vector.Length; i++)
                        {
                            for (int j = 0; j < vector.Length - 1; j++)
                            {
                                if (vector[j] > vector[j + 1])
                                {
                                    int temp = vector[j];
                                    vector[j] = vector[j + 1];
                                    vector[j + 1] = temp;

                                }

                            }

                        }
                        for (int j = 0; j < vector.Count(); j++)
                        {
                            Console.WriteLine(vector[j]);
                        }
                        Console.WriteLine("BIENVENIDO AL MENU");
                        Console.WriteLine("1- todos los elementos .");
                        Console.WriteLine("2- ascendente ");
                        Console.WriteLine("3- descendente ");
                        Console.WriteLine("4- busqueda de numero dentro de los generados . ");
                        Console.WriteLine("5- salir.");
                        opcion = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("ingrese el valor que quieras buscar");
                        int opcion2 = int.Parse(Console.ReadLine());
                        int y = 0;
                        while (y != vector.Count())
                        {
                            Console.WriteLine("el elemento " + y);
                            if (opcion2 == vector[y])
                            {
                                Console.WriteLine("es igual  al valor ingresado ");
                            }
                            else
                            {
                                Console.WriteLine("no es igual al valor ingresado ");
                            }
                            y++;
                        }
                        Console.WriteLine("BIENVENIDO AL MENU");
                        Console.WriteLine("1- todos los elementos .");
                        Console.WriteLine("2- ascendente ");
                        Console.WriteLine("3- descendente ");
                        Console.WriteLine("4- busqueda de numero dentro de los generados . ");
                        Console.WriteLine("5- salir.");
                        opcion = int.Parse(Console.ReadLine());

                        break;    
                }
            }
            Console.WriteLine("Hasta Luego");
            Console.ReadKey();           
        }
    }
}
