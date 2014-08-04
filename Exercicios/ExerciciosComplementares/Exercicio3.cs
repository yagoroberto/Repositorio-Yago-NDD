using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComplementar.Exercicios
{
    class Exercicio3
    {
        static void Main11(string[] args)
        {
            Console.Write("Digite o número da conta: ");
            int numeroConta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o saldo da conta: ");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do debito: ");
            double debito = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do credito: ");
            double credito = Convert.ToDouble(Console.ReadLine());

            double saldoAtual = saldo - debito + credito;
            if (saldoAtual > 0)
            {
                Console.WriteLine("Saldo positivo!");
                Console.WriteLine("Saldo atual: " + saldoAtual);
            }
            else
            {
                Console.WriteLine("Saldo negativo!");
                Console.WriteLine("Saldo atual: " + saldoAtual);
            }
        }
    }
}
