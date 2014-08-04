using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComplementar.Exercicios
{
    class Exercicio4
    {
        static void Main12(string[] args)
        {
            Console.Write("Digite a quantidade atual de estoque: ");
            int quantidadeAtual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade máxima suportada: ");
            double quantidadeMaxima = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quantidade mínima: ");
            double quantidadeMinima = Convert.ToDouble(Console.ReadLine());
            
            double mediaEstoque = (quantidadeMaxima + quantidadeMinima)/2;
            if (mediaEstoque <= quantidadeAtual)
            {
                Console.WriteLine("Não efetuar compra!");
            }
            else
            {
                Console.WriteLine("Efetuar compra!");
            }
            Console.ReadKey();
        }
    }
}
