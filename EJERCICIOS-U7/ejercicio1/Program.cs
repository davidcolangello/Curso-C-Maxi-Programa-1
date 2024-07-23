using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {//inicio

            int[] numeros= new int[10];
            int pos=0;
            int mayor=0;
            bool flag=false;


            Console.WriteLine("Ingrese los 10 numeros");

            for (int x = 0; x < 10; x++)
            {//inicio for ingreso
                
                numeros[x] = int.Parse(Console.ReadLine());
            
            }//fin del for ingreso


            //inicio del for analisis
            for (int x = 0; x < numeros.Length; x++)
            {
                         
                //inicio if bandera
                if (flag){
                    mayor= numeros[x];
                    pos= x + 1;
                    flag=true;

                }//fin IF bandera

                //inicio if de analisis
                if (numeros[x] > mayor) 
                {
                    mayor= numeros[x];
                    pos= x + 1;
                }//fin if de analisis
           
            }//fin del for analisis

                                        //imprimir resultados
            Console.WriteLine("El valor maximo es: " + mayor + " y se encuentra en la posicion: " + pos);


       }//fin
    }
}
