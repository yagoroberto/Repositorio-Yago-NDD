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
            CartaoDeCredito cartaoDeCredito1 = new CartaoDeCredito();
            cartaoDeCredito1.numero = 123098591;
            cartaoDeCredito1.dataDeValidade = "30/12/2015";
            
            CartaoDeCredito cartaoDeCredito2 = new CartaoDeCredito();
            cartaoDeCredito2.numero = 0982471712;
            cartaoDeCredito2.dataDeValidade = "23/10/2016";

            Console.WriteLine(cartaoDeCredito1.numero);
            Console.WriteLine(cartaoDeCredito1.dataDeValidade);


            Console.WriteLine(cartaoDeCredito2.numero);
            Console.WriteLine(cartaoDeCredito2.dataDeValidade);

            cartaoDeCredito1.dataDeValidade = "11/11/2015";
            cartaoDeCredito2.dataDeValidade = "12/12/2015";
            Console.WriteLine("Data modificada no cartão numero " + cartaoDeCredito1.numero + ": " + cartaoDeCredito1.dataDeValidade);
            Console.WriteLine("Data modificada no cartão numero " + cartaoDeCredito2.numero + ": " + cartaoDeCredito2.dataDeValidade);

            Console.ReadKey();
        }
    }
}
