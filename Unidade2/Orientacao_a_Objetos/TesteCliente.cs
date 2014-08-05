using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteCliente
    {
        private static void Main1()
        {
            Cliente cliente = new Cliente();
            cliente.nome = "Yago Roberto";
            cliente.codigo = 172;

            Cliente cliente2 = new Cliente();
            cliente2.nome = "Thiago";
            cliente2.codigo = 142;

            Console.WriteLine(cliente.nome);
            Console.WriteLine(cliente.codigo);

            Console.WriteLine(cliente2.nome);
            Console.WriteLine(cliente2.codigo);

            cliente.nome = "Yago Roberto Neto Schmitz";
            cliente2.nome = "Thiago Sartor";
            Console.WriteLine(cliente.nome);
            Console.WriteLine(cliente2.nome);

            Console.ReadKey();
        }
    }
}
