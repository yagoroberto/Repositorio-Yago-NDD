using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExercicioComplementar.Exercicios
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int horaInicio = gerador.Next(1, 24);
            int horaFim = gerador.Next(1, 24);
            int duracao = 0;

            if (horaInicio >= horaFim)
            {
                duracao = 24 + (horaInicio - horaFim);
            }
            else
            {
                duracao = horaInicio - horaFim;
            }

            if (duracao > 24)
            {
                Console.WriteLine("O jogo não pode passar de 24h!");
            }
            else
            {
                Console.WriteLine("Hora inicial: " + horaInicio);
                Console.WriteLine("Hora final: " + horaFim);
                Console.WriteLine("Duração da partida: " + duracao);
            }
            Console.ReadKey();
        }
    }
}
