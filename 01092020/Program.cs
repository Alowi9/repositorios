using System;

namespace _01092020
{
    class Program
    {
        static void Main(string[] args)
        {

           /* Random r = new Random();
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
         
            */

            /* 
           armar un programa que le pida al usuario ingresar el año de la fecha de nacimiento 
           y calcular si fue biciesto o no
           encapsular en un metodo el ingreso de datos pasando el texto a mostrarle al usuario
            y en otro metodo el calculo de si es biciesto devolviendo un valor booleano

            */

            
           Console.WriteLine(calcularAnioBisiesto(pedirAño("Ingrese su año de nacimiento")) );


            static int pedirAño(string mensaje)
            {
                Console.WriteLine(mensaje);
                string valor = Console.ReadLine();
                return int.Parse(valor);
            }

            static bool calcularAnioBisiesto(int a)
            {
                
                if (a % 4 == 0 && a % 100 != 0 )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
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

