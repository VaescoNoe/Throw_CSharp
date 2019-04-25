using System;

namespace ClaseChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("I");
                        break;
                    case 2:
                        Console.WriteLine("II");
                        break;
                    case 3:
                        Console.WriteLine("III");
                        break;
                    case 4:
                        Console.WriteLine("IV");
                        break;
                    case 5:
                        Console.WriteLine("V");
                        break;
                    default:
                        throw new InvalidOperationException("El dato no es valido");

                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("No se permiten letras");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally siempre se executa");
            }
          

            Console.ReadLine();
        }
    }
}
