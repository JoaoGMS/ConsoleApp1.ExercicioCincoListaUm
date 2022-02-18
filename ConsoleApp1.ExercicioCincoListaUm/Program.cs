using System;

namespace ConsoleApp1.ExercicioCincoListaUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salário, Desconto e Impostos");
            Console.WriteLine("=============================");
            do
            {
                
                //Não sei pq o Double não funciona ;-; 
                const decimal valorAumento = 0.15m;
                const decimal impostos = 0.8m;

                decimal salarioAtual, salarioComAumento, salarioFinal;

                Console.Write("Digite o seu salário atual: ");
                salarioAtual = Convert.ToDecimal(Console.ReadLine());

                salarioComAumento = salarioAtual + salarioAtual * valorAumento;

                salarioFinal = salarioComAumento - salarioComAumento * impostos;

                Console.WriteLine("\nO salário com aumento é: " + salarioComAumento);
                Console.WriteLine("O salário final é: " + salarioFinal);

            }while(true);
        }
    }
}
