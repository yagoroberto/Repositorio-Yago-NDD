using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TestaMetodoTransfere
    {
        private static void Main12()
        {
            Conta origem = new Conta();
            origem.saldo = 1000;

            Conta destino = new Conta();

            origem.Transfere(destino, origem.saldo);

            Console.WriteLine("Saldo conta destino: " + destino.saldo);
            Console.WriteLine("Saldo conta origem: " + origem.saldo);

            Console.ReadKey();
        }
    }
}
