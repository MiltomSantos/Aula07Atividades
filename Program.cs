using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Atividades
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, div;

            Console.WriteLine("Digite um numero:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            num2 = double.Parse(Console.ReadLine());

            div = num1 % num2;

            if (div == 0)
            {
                Console.WriteLine("O resto da sua divisão é exata");
            }
            else
            {
                Console.WriteLine("O resto da sua divisão não é exata");
            }
            Console.ReadKey();
        }

        void Atividade01()
        {
            double num;

            Console.WriteLine("Digite um numero: ");
            num = double.Parse(Console.ReadLine());
            if (num > 10)
            {
                num = num * 0.1;
            }
            Console.WriteLine("O resultado é: " + num);
            Console.ReadKey();
        }
        void Atividade02()
        {
            int num;

            Console.WriteLine("Digite um numero:");
            num = int.Parse(Console.ReadLine());
            if (num > 100)
            {
                num = num + 150;
            }
            Console.WriteLine("O seu numero é: " + num);
            Console.ReadKey();
        }
        void Atividade03Media()
        {
            string nome;
            double media;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite qual foi a sua média:");
            media = double.Parse(Console.ReadLine());

            if (media > 6.0)
            {
                Console.WriteLine($"{nome} foi aprovado com uma média de {media}");
            }
            else
            {
                Console.WriteLine($"{nome} foi reprovado com uma média de {media}");
            }
            Console.ReadKey();
        }
        void Atividade04MaiorNum()
        {
            double nota1;
            double nota2;
            double nota3;

            Console.WriteLine("Digite a primeira nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            nota3 = double.Parse(Console.ReadLine());

            if (nota1 > nota2 && nota1 > nota3)
            {
                Console.WriteLine($"A sua maior nota é a nota {nota1}");
            }
            if (nota2 > nota1 && nota2 > nota3)
            {
                Console.WriteLine($"A sua maior nota é a nota {nota2}");
            }
            if (nota3 > nota1 && nota3 > nota2)
            {
                Console.WriteLine($"A sua maior nota é a nota {nota3}");
            }
            Console.ReadKey();
        }
        void Atividade05Media()
        {
            double nota1;
            double nota2;
            double media;

            Console.WriteLine("Digite a sua primeira nota:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua segunda nota:");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media > 6.0)
            {
                Console.WriteLine("Média superior a média minima 6,0");
            }
            if (media == 6.0)
            {
                Console.WriteLine("Média igual a média minima 6,0");
            }
            if (media < 6.0)
            {
                Console.WriteLine("Média inferior a média minnima 6,0");
            }
            Console.ReadKey();
        }
        void RestoDivisao()
        {
            double num1, num2, div;

            Console.WriteLine("Digite um numero:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            num2 = double.Parse(Console.ReadLine());

            div = num1 % num2;

            if (div == 0)
            {
                Console.WriteLine("O resto da sua divisão é exata");
            }
            else
            {
                Console.WriteLine("O resto da sua divisão não é exata");
            }
            Console.ReadKey();
        }
    }
}
