using System;

namespace _01092020
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            int numeroSecreto = r.Next(10);
            int numero= 0;
            int maxIntentos = 3;
            
            Console.WriteLine("Bienvenido!, para ganar adivine el numero");
            Console.WriteLine("numero secreto " + numeroSecreto);

            for (int i=0; i< maxIntentos; i++)
            {
               
                pedirNumero("ingrese un numero", ref numero);

                if (numeroSecreto == numero) break;

            }


            if(numeroSecreto == numero)
            {
                Ganaste();
            }
              
            else
            {
                Perdiste(numeroSecreto);
            }
            
            
            
            static void Ganaste()
            {
                Console.WriteLine("Ganaste!, BIEN AHI ");
            }

           
           static void Perdiste(int n)
            {
                Console.WriteLine("Perdiste el numero era " + n);
            }
            

            static void pedirNumero (String mensaje, ref int numero)
            {
                Console.WriteLine(mensaje);
                string valor2 = Console.ReadLine();
                numero = int.Parse(valor2);
            }


        }

        /* 
            ref en variables sirven para llamar a las variables en otros metodos siempre
        y cuando las variables esten inicializadas

        out  sirven cuando llamas a un metodo y dentro del metodo te devuelven con los 
        valores cargado, no es necesario inicializar las variables

         */ 

    }
    
}

