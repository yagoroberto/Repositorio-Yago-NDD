using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4.MetodosEstaticos
{
    class TesteConta
    {
        private static void Main1()
        {
            Console.WriteLine("Contador: " + Conta.contador);
            Conta conta1 = new Conta();
            Console.WriteLine("Número da primeira conta: " + conta1.numero);

            Console.WriteLine("Contador: " + Conta.contador);
            
            Conta conta2 = new Conta();

            Console.WriteLine("Número da primeira conta: " + conta2.numero);

            Console.WriteLine("Contador: " + Conta.contador);

            Conta.ZeraContador();

            Console.ReadKey();
        }
    }
}
