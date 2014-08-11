using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.Array.ExercicioFixacao
{
    class ImprimeValores
    {
        private static void Main3()
        {
            int[] numeros = new int[] { 231, 124, 184, 94 };
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
