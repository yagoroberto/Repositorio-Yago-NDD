using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4.MetodosEstaticos
{
    class Conta
    {
        public static int contador;
        public int numero;

        public Conta()
        {
            Conta.contador++;
            this.numero = Conta.contador;
        }

        public static void ZeraContador() 
        {
            Console.WriteLine(" Contador: " + Conta.contador);
            Console.WriteLine(" Zerando o contador de contas...");

            Conta.contador = 0;
        }
    }
}
