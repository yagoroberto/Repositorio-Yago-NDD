using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExerciciosComplementares
{
    class TestaFuncionario
    {
        private static void Main10()
        {
            Funcionario funcionario1 = new Funcionario();

            funcionario1.nome = "Anilsom Luiz";
            funcionario1.cargo = "Matematica";
            funcionario1.cargoFuncionario = "Professor";

            Funcionario funcionario2 = new Funcionario();

            funcionario2.nome = "Jao Da Silva";
            funcionario2.cargo = "Programador";
            funcionario2.cargoFuncionario = "Desenvolvedor de software";


            Console.WriteLine(funcionario1.nome);
            Console.WriteLine(funcionario1.cargo);
            Console.WriteLine(funcionario1.cargoFuncionario);


            Console.WriteLine(funcionario1.nome);
            Console.WriteLine(funcionario1.cargo);
            Console.WriteLine(funcionario1.cargoFuncionario);

            Console.ReadKey();
        }
    }
}
