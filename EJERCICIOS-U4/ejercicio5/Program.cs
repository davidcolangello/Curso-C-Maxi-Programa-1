using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
         int n1, n2, n3, n4;
         
         
            Console.WriteLine("ingresa un numero");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa otro numero");
            n2= int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa otro numero");
            n3= int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa otro numero");
            n4= int.Parse(Console.ReadLine());

            if(n1 > n2 && n2 > n3 && n3 > n4)
                Console.WriteLine("Se encuentran ordenados de manera decreciente");
            else
                Console.WriteLine("NO se encuentran ordenados de manera decreciente");
         
         
         
         
         
         
         
         
         
         ;
        }
    }
}
