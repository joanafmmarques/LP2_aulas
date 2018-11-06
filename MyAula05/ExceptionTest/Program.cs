using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere um numero inteiro: ");
            try 
            { 
                int i = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"Numero inserido: {i}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Nao e possivel converter para inteiro.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Numero muito grande.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um problema.");
            }
            finally
            {
                Console.WriteLine("Obrigado por ter utilizado este programa!");
            }

        }
    }
}
