using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.Array.ExercicioFixacao
{
    class OrdenaValores
    {
        private static void Main4()
        {
            string[] nomes = new string[] { "Thiago", "Yago", "Matheus", "Sabrina", "Camila", "Keyve", "Natacha", "Rafael", "Guilherme", "Arnaldo" };
            System.Array.Sort(nomes);
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }
    }
}
