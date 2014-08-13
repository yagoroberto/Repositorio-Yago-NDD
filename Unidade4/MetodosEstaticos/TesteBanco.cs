using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4.MetodosEstaticos
{
    class TesteBanco
    {
        private static void Main()
        {
            FuncionarioBanco funcionario1 = new FuncionarioBanco();

            FuncionarioBanco.valeRefeicao = 20;

            Console.WriteLine("Vale refeição do funcionario: " + FuncionarioBanco.valeRefeicao);

            FuncionarioBanco.ReajusteValeRefeicao(0.1);

            Console.WriteLine("Vale refeição aumentado 10%: " + FuncionarioBanco.valeRefeicao);

            Console.ReadKey();
        }
    }
}
