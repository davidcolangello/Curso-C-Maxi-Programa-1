using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, resultado, contador = 0;

            Console.WriteLine("Ingrese 20 numeros para saber cuantos son par");

            for (int x = 0; x < 20; x++)
            {
                n1= int.Parse(Console.ReadLine());
                
                resultado = par(n1);
                
                if(resultado == 1)
                contador++;
            }

            Console.WriteLine("La cantidad de pares es de: " + contador);

        }

 
        static int par(int n1)
        {
           int resultado;

           if(n1 % 2 == 0)
           resultado= 1;
           else
           {
            resultado= 0;
           }

           return resultado;
        }

    }
}
