using System;

namespace calculadoraConvertidor
{
    class Program
    {
        static void Main(string[] args)
        {
            MENU.menuPrincipal();
        }

    }

    class MENU
    {
        public static void menuPrincipal()
        {
            Calculadora Cal = new Calculadora();
            Convertidor Conv = new Convertidor();
            
            int menu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("**********BIENVENIDOS AL PROGRAMA PA ELEGIR LOS EJERCICIOS DE LA TAREA**********");
                Console.WriteLine("Opcion 1: Calculadora");
                Console.WriteLine("Opcion 2: Convertidor");
                Console.WriteLine("Opcion 3: Salir");
                Console.Write("DIGITE SU OPCION: ");
                menu = Convert.ToInt32(Console.ReadLine());


                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Bienvenidos");
                        Cal.calculadora();
                        break;
                    case 2:
                        Console.WriteLine("BIENVENIDOS");
                        Conv.convertidor();
                        break;
                    case 3:
                        Console.WriteLine("Adios");
                        func();
                        break;
                    default:
                        Console.WriteLine("Por favor, digite una opcion que este en el menu");
                        break;
                }
                Console.ReadKey();
            } while (menu != 3);
        }
        static void func()
        {
            Environment.Exit(0);
        }
    }
}
