using System.Globalization;

namespace ExamenLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            Persona persona = new Persona();
            int opcion = 0;
            string opcionS = "";
            string nombre = "";
            int edad = 0;

            while (opcion != 4)
            {
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1.- Insertar Final\n" +
                                  "2.- Insertar Inicio\n" +
                                  "3.- Buscar\n" +
                                  "4.- Mostrar\n" +
                                  "5.- Salir");
                opcionS = Console.ReadLine();
                if(opcionS == "")
                {
                    Console.WriteLine("Ingrese un valor, intente de nuevo");
                }
                else
                {
                    switch (opcionS)
                    {
                        case "1":
                            Console.WriteLine("Ingresa un nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la edad");
                            edad = Convert.ToInt32(Console.ReadLine());
                            persona = new Persona
                            {
                                Nombre = nombre,
                                Edad = edad
                            };
                            lista.InsertarFinal(persona);
                            break;
                        case "2":
                            Console.WriteLine("Ingresa un nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la edad");
                            edad = Convert.ToInt32(Console.ReadLine());
                            persona = new Persona
                            {
                                Nombre = nombre,
                                Edad = edad
                            };
                            lista.InsertarInicio(persona);
                            break;
                        case "3":
                            Console.WriteLine("Ingrese el nombre que busca");
                            nombre = Console.ReadLine();
                            lista.Buscar(nombre);
                            break;
                        case "4":
                            lista.MostrarLista();
                            break;
                        case "5":
                            opcion = Convert.ToInt32(opcionS);
                            break;
                        default:
                            Console.WriteLine("No contemplado");
                            break;
                    }
                }

            }
        }
    }
}