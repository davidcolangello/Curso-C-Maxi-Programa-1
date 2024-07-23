using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           int acumulador, opcion;
            acumulador = 0;

           Console.WriteLine("Elegí tu procesador presionando la opcion que quieras, opcion 1 i5, opcion 2 i7, opcion 3 i9");
           opcion= int.Parse(Console.ReadLine());

           switch(opcion){
                case 1:
                acumulador+= 800;
                break;
                case 2:
                acumulador+= 900;
                break;
                case 3:
                acumulador+= 1200;
                break;
                default:
                Console.WriteLine("No coincide con ninguna opción, ingrese 1 , 2 o 3");
                break;
             }
Console.WriteLine(acumulador);













        }
    }
}
