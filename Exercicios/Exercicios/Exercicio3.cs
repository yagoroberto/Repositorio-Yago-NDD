using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
    class Exercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Exercício 3 ----------");
            Console.WriteLine("---------- Impar & Par ----------");
            Console.Write("Informe até quando deseja contar: ");
            int numeroParImpar = Convert.ToInt32(Console.ReadLine());
            for (int contadorParImpar = 1; contadorParImpar <= numeroParImpar; contadorParImpar++)
            {
                int restoDoNumero = contadorParImpar % 2;
                if (restoDoNumero == 1)
                {
                    Console.WriteLine(contadorParImpar + " - *");
                }
                else
                {
                    Console.WriteLine(contadorParImpar + " - **");
                }
            }
            Console.WriteLine("");
        }
    }
}
