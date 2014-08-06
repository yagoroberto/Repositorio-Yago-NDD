using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos.Complementar
{
    class TestaContaBanco
    {
        private static void Main()
        {
            ContaBanco contaBanco = new ContaBanco();
            contaBanco.numero = 1234;
            contaBanco.saldo = 1000;
            contaBanco.limite = 2000;

        }
    }
}
