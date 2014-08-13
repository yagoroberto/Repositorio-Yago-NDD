using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4.MetodosEstaticos
{
    class FuncionarioBanco
    {
        public string nome;
        public double salario;
        public static double valeRefeicao;

        public static void ReajusteValeRefeicao(double taxa)
        {
            valeRefeicao += valeRefeicao * taxa;
        }

    }
}
