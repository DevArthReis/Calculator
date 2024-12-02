using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[]args)
        {
          Menu();
            

        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que deseja calcular");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());
            switch(res){
                case 1 :Soma();break;
                case 2 :Subtracao();break;
                case 3 :Multiplicacao();break;
                case 4 :Divisao();break;
                case 5 :System.Environment.Exit(0);break;
                default: Menu();break;
            }
           


        }

        static void Soma(){
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 + n2;
            Console.WriteLine($"O Resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();



        }
        static void Subtracao(){
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 - n2;
            Console.WriteLine($"O Resultado da subtraçõa é {resultado}");
            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao(){
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 * n2;
            Console.WriteLine($"O Resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();

        }
        static void Divisao(){
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 / n2;
            Console.WriteLine($"O Resultado da Divisão é {resultado}");
            Console.ReadKey();
            Menu();

        }
    }
}