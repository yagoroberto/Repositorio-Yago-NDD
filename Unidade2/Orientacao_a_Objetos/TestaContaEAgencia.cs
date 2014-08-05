using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TestaContaEAgencia
    {
        private static void Main4()
        {
            ContaEAgencia conta1 = new ContaEAgencia();
            conta1.numero = 1234;
            conta1.saldo = 1000;
            conta1.limite = 500;

            Agencia agencia1 = new Agencia();
            agencia1.numero = 1234;

            conta1.agencia = agencia1;

            ContaEAgencia conta2 = new ContaEAgencia();
            conta2.numero = 5678;
            conta2.saldo = 2000;
            conta2.limite = 250;

            Agencia agencia2 = new Agencia();
            agencia2.numero = 5678;

            conta2.agencia = agencia2;

            Console.WriteLine(conta1.numero);
            Console.WriteLine(conta1.saldo);
            Console.WriteLine(conta1.limite);
            Console.WriteLine(conta1.agencia.numero);

            Console.WriteLine(conta2.numero);
            Console.WriteLine(conta2.saldo);
            Console.WriteLine(conta2.limite);
            Console.WriteLine(conta2.agencia.numero);

            Console.ReadKey();
        }
    }
}
