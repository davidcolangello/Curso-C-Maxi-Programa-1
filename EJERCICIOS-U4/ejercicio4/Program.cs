using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            int suma, producto;

            Console.WriteLine("ingresa un numero");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa otro numero");
            n2= int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa otro numero");
            n3= int.Parse(Console.ReadLine());

            suma= n1 + n2;
            producto= n2 * n3;

            if(suma > producto)
                Console.WriteLine("la suma de los dos primeros ES mayor al producto del segundo con el tercero. Resultado de la suma es: "+ suma + " resultado del producto es: " + producto);
            else
                Console.WriteLine("la suma de los dos primeros NO es mayor al producto del segundo con el tercero. Resultado de la suma es: "+ suma + " resultado del producto es: " + producto);









        }
    }
}
