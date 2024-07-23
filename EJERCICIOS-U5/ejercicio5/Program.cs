using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int maxpar = 0;
            int mimpar = 2147483647;
            
            Console.WriteLine("Ingrese un numero para averiguar el par maximo y el impar minimo de los ingresados");
            n= int.Parse(Console.ReadLine());

            if (n % 2 == 0){
                maxpar= n;
            }else
            
            if(n % 2 > 0){
                mimpar= n;
            }       
             


            for (int x = 0; x < 19; x++)
            {
                Console.WriteLine("Ingrese un numero para averiguar el par maximo y el impar minimo de los ingresados");
                n= int.Parse(Console.ReadLine());
                              
                if ((n % 2) == 0){
                    if(n > maxpar){
                    maxpar= n;
                    }
                }else if((n % 2) != 0){
                    if(n < mimpar){
                    mimpar= n;
                    }
                }                             
            }        
                
                Console.WriteLine("El maximo par es:  " + maxpar + "  El minimo impar es:  " + mimpar );
        
            
        }
    }
}
