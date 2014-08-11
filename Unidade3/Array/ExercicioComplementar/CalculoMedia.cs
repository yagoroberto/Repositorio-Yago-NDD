using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.Array.ExercicioComplementar
{
    class CalculoMedia
    {
        private static void Main5()
        {
            Console.Write("Informe quantos elementos deseja: ");
            int elemento = Convert.ToInt32(Console.ReadLine());

            double[] elementos = new double[elemento];
            double total = 0;

            for (int i = 0; i < elemento; i++)
            {
                Console.Write("Elemento " + (i + 1) + ": ");
                elementos[i] = Convert.ToDouble(Console.ReadLine());
                total += elementos[i];
            }

            total = total / elemento;

            Console.WriteLine("Média: " + total);

            Console.ReadKey();
        }
    }
}
