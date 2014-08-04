using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComplementar.Exercicios
{
    class Exercicio1
    {
        static void Main9(string[] args)
        {
            Console.Write("Digite a hora incial da partida: ");
            int horaInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a hora final da partida: ");
            int horaFinal = Convert.ToInt32(Console.ReadLine());
            int duracao = 0;
            if (horaFinal > horaInicial)
            {
                duracao = (24 - horaInicial) - (24 - horaFinal);
                if (duracao > 24)
                {
                    Console.WriteLine("A partida nao pode durar mais de 24h");
                }
                else
                {
                    Console.WriteLine("Duração: " + duracao);
                }
            }
            else
            {
                duracao = (24 - horaFinal) - (24 - horaInicial);
                duracao = 24 - duracao;
                if (duracao > 24)
                {
                    Console.WriteLine("A partida nao pode durar mais de 24h");
                }
                else
                {
                    Console.WriteLine("Duração: " + duracao);
                }
            }
            Console.ReadKey();
        }
    }
}
