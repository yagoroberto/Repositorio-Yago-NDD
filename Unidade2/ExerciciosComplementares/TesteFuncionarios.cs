using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExerciciosComplementares
{
    class TesteFuncionarios
    {
        private static void Main()
        {
            Funcionarios funcionario = new Funcionarios();
            funcionario.nome = "Yago Roberto";
            funcionario.salario = 1000;

            funcionario.ConsultaDados();
            
            funcionario.AumentarSalario(200);

            funcionario.ConsultaDados();

            Console.ReadKey();
        }
    }
}
