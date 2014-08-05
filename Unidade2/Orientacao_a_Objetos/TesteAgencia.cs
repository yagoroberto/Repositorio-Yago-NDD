using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteAgencia
    {
        private static void Main3()
        {
            Agencia agencia1 = new Agencia();
            agencia1.numero = 1234;

            Agencia agencia2 = new Agencia();
            agencia2.numero = 5678;

            Console.WriteLine(agencia1.numero);
            Console.WriteLine(agencia2.numero);

            Console.ReadKey();
        }
    }
}
