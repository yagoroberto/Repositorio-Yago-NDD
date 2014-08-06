using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteGerente
    {
        private static void Main11()
        {
            Gerente gerente = new Gerente();

            gerente.nome = "Joao da Silva";
            gerente.salario = 5000;

            Console.WriteLine("Nome: " + gerente.nome);
            Console.WriteLine("Salario: " + gerente.salario);

            gerente.AumentoSalario();

            Console.WriteLine("Salario aumentado por padrão (10%): " + gerente.salario);

            gerente.AumentoSalario(0.2);

            Console.WriteLine("Salario aumentado 20%: " + gerente.salario);

            Console.ReadKey();
        }
    }
}
