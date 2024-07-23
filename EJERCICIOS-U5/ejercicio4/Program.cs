using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int contador = 0;

            Console.WriteLine("Ingrese un numero para saber si es primo");
            n = int.Parse(Console.ReadLine());


            for (int x = 1; x <= n; x++)
            {
                if((n % x) == 0)
                contador++;
                
            }
            if(n == 2)
                Console.WriteLine(n + "  Es un numero primo ");
            else if (contador > 2)  
                Console.WriteLine(n + "  No es un numero primo ");
            else
                Console.WriteLine(n + "  Es un numero primo ");



        }
    }
}
