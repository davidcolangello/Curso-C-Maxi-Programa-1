using System;

namespace   primer_programa{
class Program
{
    static bool EsPar(int numero)
    {
        if (numero % 2 == 0)
        {
            return true ;
        }
        else
        {
            return false ;
        }
    }

    static void Main()
    {
        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());

        bool esPar = EsPar(numero);

        if (esPar == true)
        {
            Console.WriteLine("El número ingresado es par.");
        }
        else
        {
            Console.WriteLine("El número ingresado es impar.");
        }
    }
}}