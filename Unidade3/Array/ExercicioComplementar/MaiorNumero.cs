using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.Array.ExercicioComplementar
{
    class MaiorNumero
    {
        private static void Main999()
        {
            Random random = new Random();

            int[] numeros = new int[15];

            int maiorNumero = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 100);

                if (maiorNumero < numeros[i])
                {
                    maiorNumero = numeros[i];
                }

                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("Maior número: " + maiorNumero);
            Console.ReadKey();
        } 
    }
}
