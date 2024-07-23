using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {//inicio


            int[] numeros= new int[10];
            int acu=0;
            int promedio, mayor=0;
            


            Console.WriteLine("Ingrese los 10 numeros");


            //inicio for ingreso y acumulador
            for (int x = 0; x < 10; x++)
            {
                
                numeros[x] = int.Parse(Console.ReadLine());
                acu+= numeros[x];
            
            }//fin del for ingreso

            //calculo de promedio
            promedio = (acu / 10);

            //inicio for mayores que promedio
            for (int x = 0; x < 10; x++)
            {
                if (numeros[x] > promedio)
                {
                    mayor= numeros [x];
                    Console.WriteLine("Este elemento fue mayor al promedio: " + mayor );
                }
                

            }//fin for mayores que promedio
            
            Console.WriteLine("El promedio de los numeros ingresados es de: " + promedio);
         




        }//fin

            


    }
}
