using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExerciciosComplementares
{
    class Funcionarios
    {
        public string nome;
        public double salario;

        public void AumentarSalario(double valor)
        {
            this.salario += valor;
        }

        public void ConsultaDados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Salario: " + this.salario);
        }
    }
}
