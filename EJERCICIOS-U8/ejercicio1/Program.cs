using System;

namespace ejercicio1
{// 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
//Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese un numero");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2= int.Parse(Console.ReadLine());

            resultado = producto(n1, n2);


            Console.WriteLine("El producto de los numeros es: " + resultado);


        }



        static int producto(int n1, int n2)
        {
            int r;
            r = n1 * n2;
            return r;
        }
    }
}
