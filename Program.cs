using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Clear();  
            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Se vc deseja Somar digite 1");
            Console.WriteLine("Se vc deseja Subtrair digite 2");
            Console.WriteLine("Se vc deseja Multiplicar digite 3");
            Console.WriteLine("Se vc deseja Dividir digite 4");
            int Calcular= int.Parse(Console.ReadLine());
            if(Calcular == 1){
                float resultado = n1 + n2;
                Console.WriteLine("Resultado da soma é: ",resultado);
            }
            if(Calcular == 2){
             float resultado = n1 - n2;
             Console.WriteLine("Resultado da subtração é: ",resultado);
            }
            if(Calcular == 3){
             float resultado = n1 * n2;
             Console.WriteLine("Resultado da multiplicação é: ",resultado);
            }
            if(Calcular == 4){
             float resultado = n1 / n2;
             Console.WriteLine("Resultado da divisão é: ",resultado);
            }
            if(Calcular >= 5 || Calcular<= 0){           
             Console.WriteLine("Opção digitada não corresponde a nenhuma das alternativas");
            }
            
            

        }
    }
}