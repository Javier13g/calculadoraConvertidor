using System;
namespace calculadoraConvertidor
{
    public class Calculadora
    {
        decimal uno, dos, res;
        public void calculadora()
        {
            int menu = 0;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("**********BIENVENIDOS A LA CALCULADORA*********");
                    Console.WriteLine("Opcion 1: Suma");
                    Console.WriteLine("Opcion 2: Resta");
                    Console.WriteLine("Opcion 3: Multiplicacion");
                    Console.WriteLine("Opcion 4: Division");
                    Console.WriteLine("Opcion 5: Volver al menu principal");
                    Console.Write("DIGITE SU OPCION: ");
                    menu = Convert.ToInt32(Console.ReadLine());



                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Bienvenidos a la opcion suma");
                            suma();
                            break;
                        case 2:
                            Console.WriteLine("Bienvenidos a la opcion resta");
                            resta();
                            break;
                        case 3:
                            Console.WriteLine("Bienvenidos a la opcion multiplicacion");
                            multiplicacion();
                            break;
                        case 4:
                            Console.WriteLine("Bienvenidos a la opcion division");
                            division();
                            break;
                        case 5:
                            MENU.menuPrincipal();
                            break;
                        default:
                            Console.WriteLine("Por favor, digite una opcion que este en el menu");
                            break;
                    }
                    Console.ReadKey();
                } while (menu != 5);
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    Console.WriteLine("Ingrese una letra");
                }

            }
        }

        public void suma()
        {
            try
            {
                Console.Write("Digita primer numero: ");
                uno = int.Parse(Console.ReadLine());

                Console.Write("Digita segundo numero: ");
                dos = int.Parse(Console.ReadLine());

                res = uno + dos;
                Console.Write("EL resultado de la suma es: " + res);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Solo Numeros por favor");
            }
        }

        public void resta()
        {
            Console.Write("Digita primer numero: ");
            uno = int.Parse(Console.ReadLine());

            Console.Write("Digita segundo numero: ");
            dos = int.Parse(Console.ReadLine());

            res = uno - dos;
            Console.Write("EL resultado de la resta es: " + res);
        }

        public void multiplicacion()
        {
            Console.Write("Digita primer numero: ");
            uno = int.Parse(Console.ReadLine());

            Console.Write("Digita segundo numero: ");
            dos = int.Parse(Console.ReadLine());

            res = uno * dos;
            Console.Write("EL resultado de la multiplicacion es: " + res);
        }

        public void division()
        {
            Console.Write("Digita primer numero: ");
            uno = int.Parse(Console.ReadLine());

            Console.Write("Digita segundo numero: ");
            dos = int.Parse(Console.ReadLine());

            res = uno / dos;
            Console.Write("EL resultado de la division es: " + res);
        }
    }
}
