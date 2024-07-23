using System;

namespace EJERCICIO2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1;
            int nota2;
            int nota3;
            int promedio;
            
            Console.WriteLine("Ingrese la primer nota");
            nota1= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            nota2= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota");
            nota3= int.Parse(Console.ReadLine());

            promedio= (nota1 + nota2 + nota3)/3;

            Console.WriteLine("Su promedio es de:" + promedio);   

            
        }
    }
}
