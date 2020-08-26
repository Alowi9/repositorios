using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           int numero = 7;
           int numero2; 
            Console.WriteLine("Bienvenido!, para ganar adivine el numero");
            
            do
            {
                
                string valor2 = Console.ReadLine();
                numero2 = int.Parse(valor2);

                if(numero != numero2)
                {
                    Console.WriteLine("No adivinaste, proba otro numero!");
                }
                

            } while (numero != numero2);
            
            Console.WriteLine("Ganaste!, BIEN AHI ");
        }
    }
}
