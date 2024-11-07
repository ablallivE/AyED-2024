using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_villalba_dibuvrnturas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int conteo = 0;
            int MaxP = 20; 
            string[,] personajes = new string[MaxP, 5]; 

            while (opcion != 9)
            {
                MostrarMenu(conteo, MaxP);
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                EjecutarOpcion(opcion, ref conteo, MaxP, ref personajes);
            }
            Console.WriteLine("¡Hasta luego!");
            Console.ReadKey();
        }

        static void MostrarMenu(int conteo, int MaxP)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("-----------------------------------------------------\nMenú Principal - Dibuaventuras Multiversales\n-----------------------------------------------------\n");
            Console.WriteLine("Personajes Registrados: " + conteo + "/" + MaxP + "\n");
            Console.WriteLine("1- Nuevo Personaje ");
            Console.WriteLine("2- Consultar Personaje");
            Console.WriteLine("3- Modificar Personaje ");
            Console.WriteLine("4- Eliminar Personaje ");
            Console.WriteLine("5- Mostrar Todos los Personajes");
            Console.WriteLine("6- Salir ");
            Console.Write("-----------------------------------------------------");
            Console.WriteLine();
            Console.Write("Ingrese la opción deseada: ");
        }

        static void EjecutarOpcion(int opcion, ref int conteo, int MaxP, ref string[,] personajes)
        {
            switch (opcion)
            {
                case 1:
                    NuevoPersonaje(ref conteo, MaxP, ref personajes);
                    break;
                case 2:
                    ConsultarPersonaje(ref conteo, ref personajes);
                    break;
                case 3:
                    ModificarPersonaje(ref conteo, MaxP, ref personajes);
                    break;
                case 4:
                    EliminarPersonaje(ref conteo, MaxP, ref personajes);
                    break;
                case 5:
                    MostrarTodosPersonajes(ref conteo, ref personajes);
                    break;
                case 6:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        
        static void NuevoPersonaje(ref int conteo, int MaxP, ref string[,] personajes)
        {
            if (conteo == MaxP)
            {
                Console.WriteLine("¡La lista de personajes está llena!");
                Console.ReadLine();
                return;
            }

            Console.Write("Ingrese el nombre del personaje: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la serie a la que pertenece el personaje: ");
            string serie = Console.ReadLine();
            Console.Write("Ingrese la fuerza del personaje: ");
            int fuerza = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la defensa del personaje: ");
            int defensa = int.Parse(Console.ReadLine());
            Console.Write("¿Es un héroe? (True/False): ");
            string heroe = Console.ReadLine();
            if (heroe != "true" || heroe != "false")
            {
               heroe = Console.ReadLine();
            }



            
            for (int i = 0; i < conteo; i++)
            {
                if (personajes[i, 0] == nombre)
                {
                    Console.WriteLine("¡Este personaje ya existe!");
                    return;
                }
            }

            
            personajes[conteo, 0] = nombre;
            personajes[conteo, 1] = serie;
            personajes[conteo, 2] = fuerza.ToString();
            personajes[conteo, 3] = defensa.ToString();
            personajes[conteo, 4] = heroe;
            conteo++;
            Console.WriteLine("¡Personaje agregado con éxito!");
            Console.ReadLine();
        }

        
        static void ConsultarPersonaje(ref int conteo, ref string[,] personajes)
        {
            Console.Write("Ingrese el nombre del personaje a consultar: ");
            string nombre = Console.ReadLine();

            bool encontrado = false;
            for (int i = 0; i < conteo; i++)
            {
                if (personajes[i, 0] == nombre)
                {
                    Console.WriteLine("Nombre: " + personajes[i, 0]);
                    Console.WriteLine("Serie: " + personajes[i, 1]);
                    Console.WriteLine("Fuerza: " + personajes[i, 2]);
                    Console.WriteLine("Defensa: " + personajes[i, 3]);
                    Console.WriteLine("Héroe: " + personajes[i, 4]);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró el personaje.");
            }

            Console.ReadLine();
        }

       
        static void ModificarPersonaje(ref int conteo, int MaxP, ref string[,] personajes)
        {
            Console.Write("Ingrese el nombre del personaje a modificar: ");
            string nombre = Console.ReadLine();

            bool encontrado = false;
            for (int i = 0; i < conteo; i++)
            {
                if (personajes[i, 0] == nombre)
                {
                    Console.WriteLine("Datos actuales del personaje:");
                    Console.WriteLine("Fuerza: " + personajes[i, 2]);
                    Console.WriteLine("Defensa: " + personajes[i, 3]);

                    Console.Write("Ingrese la nueva fuerza: ");
                    int nuevaFuerza = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nueva defensa: ");
                    int nuevaDefensa = int.Parse(Console.ReadLine());

                    personajes[i, 2] = nuevaFuerza.ToString();
                    personajes[i, 3] = nuevaDefensa.ToString();

                    Console.WriteLine("¡Personaje modificado con éxito!");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró el personaje.");
            }

            Console.ReadLine();
        }
        
        static void EliminarPersonaje(ref int conteo, int MaxP, ref string[,] personajes)
        {
            Console.Write("Ingrese el nombre del personaje a eliminar: ");
            string nombre = Console.ReadLine();

            bool encontrado = false;
            for (int i = 0; i < conteo; i++)
            {
                if (personajes[i, 0] == nombre)
                {
                    
                    for (int j = i; j < conteo - 1; j++)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            personajes[j, k] = personajes[j + 1, k];
                        }
                    }

                    
                    for (int k = 0; k < 5; k++)
                    {
                        personajes[conteo - 1, k] = null;
                    }

                    conteo--;
                    Console.WriteLine("¡Personaje eliminado con éxito!");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró el personaje.");
            }

            Console.ReadLine();
        }

        
        static void MostrarTodosPersonajes(ref int conteo, ref string[,] personajes)
        {
            if (conteo == 0)
            {
                Console.WriteLine("No hay personajes registrados.");
            }
            else
            {
                
                for (int i = 0; i < conteo - 1; i++)
                {
                    for (int j = i + 1; j < conteo; j++)
                    {
                        if (string.Compare(personajes[i, 0], personajes[j, 0]) > 0)
                        {
                            
                            for (int k = 0; k < 5; k++)
                            {
                                string temp = personajes[i, k];
                                personajes[i, k] = personajes[j, k];
                                personajes[j, k] = temp;
                            }
                        }
                    }
                }

                
                Console.WriteLine("Listado de personajes:");
                for (int i = 0; i < conteo; i++)
                {
                    Console.WriteLine(personajes[i, 0] + " - " + personajes[i, 1] + " - Fuerza: " + personajes[i, 2] + " - Defensa: " + personajes[i, 3] + " - Héroe: " + personajes[i, 4]);

                }
            }

            Console.ReadLine();
        }
    }
}
