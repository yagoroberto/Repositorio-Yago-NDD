using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteCartaoDeCredito
    {
        private static void Main2()
        {
            CartaoDeCredito cartaoDeCredito1 = new CartaoDeCredito(12312312);
            Cliente cliente1 = new Cliente();
            cartaoDeCredito1.dataDeValidade = "30/12/2015";

            cliente1.nome = "Yago Roberto";
            cliente1.codigo = 1234;
            
            cartaoDeCredito1.cliente = cliente1;


            CartaoDeCredito cartaoDeCredito2 = new CartaoDeCredito(829828);
            Cliente cliente2 = new Cliente();
            cartaoDeCredito2.dataDeValidade = "23/10/2016";

            cliente2.nome = "Joao da Silva";
            cliente2.codigo = 5678;

            cartaoDeCredito2.cliente = cliente2;

            Console.WriteLine(cartaoDeCredito1.numero);
            Console.WriteLine(cartaoDeCredito1.dataDeValidade);
            Console.WriteLine(cartaoDeCredito1.cliente.codigo);
            Console.WriteLine(cartaoDeCredito1.cliente.nome);


            Console.WriteLine(cartaoDeCredito2.numero);
            Console.WriteLine(cartaoDeCredito2.dataDeValidade);
            Console.WriteLine(cartaoDeCredito2.cliente.codigo);
            Console.WriteLine(cartaoDeCredito2.cliente.nome);

            cartaoDeCredito1.dataDeValidade = "11/11/2015";
            cartaoDeCredito2.dataDeValidade = "12/12/2015";
            Console.WriteLine("Data modificada no cartão numero " + cartaoDeCredito1.numero + ": " + cartaoDeCredito1.dataDeValidade);
            Console.WriteLine("Data modificada no cartão numero " + cartaoDeCredito2.numero + ": " + cartaoDeCredito2.dataDeValidade);

            Console.ReadKey();
        }
    }
}
