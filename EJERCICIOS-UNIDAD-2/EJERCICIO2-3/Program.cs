using System;

namespace EJERCICIO2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float distancia;
            float velocidad;
            float tiempo;

            Console.WriteLine("Ingrese Distancia en km");
            distancia= float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Velocidad promedio en km/h");
            velocidad= float.Parse(Console.ReadLine());

            tiempo= (distancia / velocidad);

            Console.WriteLine("Usted va a tardar la siguiente cantidad de horas: " + tiempo);
            tiempo= (tiempo * 60);
            Console.WriteLine("Usted va a tardar la siguiente cantidad de minutos: " + tiempo);
            
        }
    }
}
