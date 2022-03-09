using System;
namespace calculadoraConvertidor
{
    public class Convertidor
    {
        // Variables
        double Celsius;
        double Fahrenheit;
        double Kelvin;
        double f = 1.8;
        public void convertidor()
        {
            int menu = 0;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("**********BIENVENIDOS AL CONVERTIDOR*********");
                    Console.WriteLine("Opcion 1: Celsius a Fahrenheit-Kelvin");
                    Console.WriteLine("Opcion 2: Fahrenheit a Celsius-Kelvin");
                    Console.WriteLine("Opcion 3: Kelvin a Celsius-Fahrenheit");
                    Console.WriteLine("Opcion 4: Volver al menu principal");
                    Console.Write("DIGITE SU OPCION: ");
                    menu = Convert.ToInt32(Console.ReadLine());



                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Bienvenidos a la opcion Celsius - Fahrenheit_Kelvin");
                            Celsius_Fahrenheit_Kelvin();
                            break;
                        case 2:
                            Console.WriteLine("Bienvenidos a la opcion Fahrenheit - Celsius_Kelvin");
                            Fahrenheit_Celsius_Kelvin();
                            break;
                        case 3:
                            Console.WriteLine("Bienvenidos a la opcion Kelvin - Celsius_Fahrenheit");
                            Kelvin_Celsius_Fahrenheit();
                            break;
                        case 4:
                            MENU.menuPrincipal();
                            break;
                        default:
                            Console.WriteLine("Por favor, digite una opcion que este en el menu");
                            break;
                    }
                    Console.ReadKey();
                } while (menu != 4);
            }
            catch (Exception ex)
            {
                if(ex is FormatException || ex is OverflowException)
                {
                    Console.WriteLine("Ingrese un numero");
                }

            }
        }

        public void Celsius_Fahrenheit_Kelvin()
        {
            Console.Write("Digita la temperatura: ");
            Celsius = int.Parse(Console.ReadLine());

            Fahrenheit = (Celsius * f) + 32;
            Console.WriteLine(Celsius+" Grados Celsius = "+ Fahrenheit+ " Grados Fahrenheit");

            Kelvin = Celsius + 273.15;
            Console.WriteLine(Celsius+" Grados Celsius = "+ Kelvin+ " Grados Kelvin");
        }

        public void Fahrenheit_Celsius_Kelvin()
        {
            Console.Write("Digita la temperatura: ");
            Fahrenheit = int.Parse(Console.ReadLine());

            Celsius = (Fahrenheit - 32) / f;
            Console.WriteLine(Fahrenheit+" Grados Fahrenheit = "+ Celsius+ " Grados Celsius");

            Kelvin = (Fahrenheit - 32) / f + 273.15;
            Console.WriteLine(Fahrenheit+" Grados Fahrenheit = "+ Kelvin+ " Grados Kelvin");
        }

        public void Kelvin_Celsius_Fahrenheit()
        {
            Console.Write("Digita la temperatura: ");
            Kelvin = int.Parse(Console.ReadLine());

            Celsius = Kelvin - 273.15;
            Console.WriteLine(Kelvin+" Grados Kelvin = "+ Celsius+ " Grados Celsius");

            Fahrenheit = 1.8*(Kelvin - 273.15) + 32;
            Console.WriteLine(Kelvin+" Grados Kelvin = "+ Fahrenheit+ " Grados Fahrenheit");
        }
    }
}