using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class Gerente
    {
        public string nome;
        public double salario;

        public void AumentoSalario()
        {
            this.AumentoSalario(0.1);
        }

        public void AumentoSalario(double taxa)
        {
            this.salario += this.salario * taxa;
        }
    }
}
