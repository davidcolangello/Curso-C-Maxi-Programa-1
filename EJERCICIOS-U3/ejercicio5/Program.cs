﻿using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
// 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
        {
            int n1, n2, n3, n4;
            
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n3 = int.Parse(Console.ReadLine());            
            Console.WriteLine("Ingrese otro numero");
            n4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Los numeros mayores a 100 son:");
            if(n1 > 100)
                Console.WriteLine(n1);
            if(n2 > 100)
                Console.WriteLine(n2);
            if(n3 > 100)
                Console.WriteLine(n3);
            if(n4 > 100)
                Console.WriteLine(n4);


        }
    }
}
