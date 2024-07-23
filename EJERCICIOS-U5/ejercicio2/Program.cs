using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
//2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla.
//   Solo se debe emitir UN valor por pantalla.
        {   int n;
            int mayor = 0;

        
            for (int x = 0; x < 10; x++) 
            {
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            if (n > mayor)
                mayor = n;
                
            }

            Console.WriteLine("El numero mayor ingresado fue: " + mayor);
            
        
        
        
        
        
        
        }
    }
}
