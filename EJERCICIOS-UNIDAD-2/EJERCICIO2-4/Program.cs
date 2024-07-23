using System;

namespace EJERCICIO2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const float sueldo= 15000f;
            float facturado;
            float sueldototal;
            const float comision= 0.05f;

            Console.WriteLine("Ingrese total facturado");
            facturado= float.Parse(Console.ReadLine());

            sueldototal= sueldo + (facturado * comision);
            
            Console.WriteLine("Su sueldo total incluido comisiones es de $" + sueldototal);

        }
    }
}
