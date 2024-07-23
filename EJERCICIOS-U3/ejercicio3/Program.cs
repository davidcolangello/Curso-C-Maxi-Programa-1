using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
//3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
//   Si el importe es menor a ARS 1000, no hay descuento.
//   Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
//   Si el importe es ARS 5000 o más, aplica un descuento del 18%.
//Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.    
        {
        float impventa;
        float impfinal;
        float desc1=0.90f;
        float desc2=0.82f;

        Console.WriteLine("ingrese el importe de la compra");
        impventa= float.Parse(Console.ReadLine());

        if(impventa < 1000){
            impfinal= impventa;
            Console.WriteLine("No hay descuento, su importe final a pagar es "+ impfinal);
        }else if(impventa >= 5000){
            impfinal=  impventa * desc2;
            Console.WriteLine("Obtuvo un descuento del 18%, su importe final a pagar es "+ impfinal);
        }else{
            impfinal=  impventa * desc1;
            Console.WriteLine("Obtuvo un descuento del 10%, su importe final a pagar es "+ impfinal);
        }

        Console.WriteLine("Fin");
        }
    }
}
