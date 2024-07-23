using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float importetotal, importefinal, litrosvendidos;
            

            Console.WriteLine("Ingrese el importe total");
            importetotal= float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los litros vendidos");
            litrosvendidos= float.Parse(Console.ReadLine());

            if(litrosvendidos >= 101 && litrosvendidos <= 300 ){
                importefinal= importetotal * 0.9f;
                Console.WriteLine("Obtuviste un descuento del 10% en tu importe, importe final es: $" + importefinal);
                
            }
             if(litrosvendidos >= 301 && litrosvendidos <= 500 ){
                importefinal= importetotal * 0.85f;
                Console.WriteLine("Obtuviste un descuento del 15% en tu importe, importe final es: $" + importefinal);
            }           
            
            if(litrosvendidos > 500){
                importefinal= importetotal * 0.75f;
                Console.WriteLine("Obtuviste un descuento del 25% en tu importe, importe final es: $" + importefinal);  
            }else if(litrosvendidos < 100){
                Console.WriteLine("No aplicaste ningun descuento ya que no alcanzaste cant. de litros mayorista, tu monto final a pagar es de: $" + importetotal);
            }
        }
    }
}
