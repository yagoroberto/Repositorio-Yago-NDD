using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAPP.Exercicios
{
    class Exercicio4
    {
        static void main(string[] args)
        {
            Console.WriteLine("---------- Exercício 4 ----------");
            Console.WriteLine("---------- Múltiplos de 4 ----------");
            Console.Write("Informe até quando deseja contar: ");
            int contarMultiplosDe4 = Convert.ToInt32(Console.ReadLine());
            for (int contadorMultiplosDe4 = 1; contadorMultiplosDe4 <= contarMultiplosDe4; contadorMultiplosDe4++)
            {
                int multiplos = contadorMultiplosDe4 % 4;
                if (multiplos == 0)
                {
                    Console.WriteLine("PI");
                }
                else
                {
                    Console.WriteLine(contadorMultiplosDe4);
                }
            }
            Console.WriteLine("");
        }
    }
}
