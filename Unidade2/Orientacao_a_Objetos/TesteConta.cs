using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteConta
    {
        private static void Main4()
        {
            Conta conta1 = new Conta();
            conta1.numero = 1234;
            conta1.saldo = 1000;
            conta1.limite = 500;

            Conta conta2 = new Conta();
            conta2.numero = 5678;
            conta2.saldo = 2000;
            conta2.limite = 250;

            Console.WriteLine(conta1.numero);
            Console.WriteLine(conta1.saldo);
            Console.WriteLine(conta1.limite);

            Console.WriteLine(conta2.numero);
            Console.WriteLine(conta2.saldo);
            Console.WriteLine(conta2.limite);

            Console.ReadKey();
        }
    }
}
