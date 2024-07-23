using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, promedio;
            int contador = 0;
            int acumulador = 0;

            for (int x = 0; x < 20; x++)
            {
            Console.WriteLine("Ingrese edad");
            edad= int.Parse(Console.ReadLine());
            if (edad > 18){
                acumulador+= edad ;
                contador++;
                }     
            }
            if(contador != 0){
            promedio = (acumulador / contador);
            Console.WriteLine("El promedio de edad para los mayores de 18 años es de: " + promedio);
            }else{
            Console.WriteLine("No hay mayores de 18 años");
            }


        }
    }
}
