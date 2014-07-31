using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
    class Exercicio7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Exercício 7 ----------");
            Console.WriteLine("---------- Fibonacci ----------");
            Console.Write("Proximo de qual número deseja parar: ");
            int pararFibonacci = Convert.ToInt32(Console.ReadLine());
            int inicioFibonacci = 0;
            int fimFibonacci = 1;
            int calculoFibonacci = 0;
            do
            {
                calculoFibonacci = inicioFibonacci + fimFibonacci;
                inicioFibonacci = fimFibonacci;
                fimFibonacci = calculoFibonacci;
                Console.Write(calculoFibonacci);
                if (pararFibonacci >= fimFibonacci)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write("...");
                }
            } while (pararFibonacci >= fimFibonacci);
            Console.WriteLine("");
            Console.WriteLine("O número mais proximo depois de " + pararFibonacci + " foi " + calculoFibonacci);
            Console.WriteLine("");
        }
    }
}
