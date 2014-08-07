using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos.Complementar
{
    class TestaFuncionario
    {
        private static void Main()
        {

            Console.WriteLine("-------- Funcionario ---------");
            Console.Write("Informe o nome do funcionario: ");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Informe o salario do funcionario: ");
            double salarioFuncionario = Convert.ToDouble(Console.ReadLine());

            Funcionario funcionario = new Funcionario();

            funcionario.nome = nomeFuncionario;
            funcionario.salario = salarioFuncionario;

            int opcao = -1;

            while (opcao != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("----- Selecione sua opção -----");
                Console.WriteLine("1 - Alterar nome");
                Console.WriteLine("2 - Alterar sálario");
                Console.WriteLine("3 - Consultar dados");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("------- Mudar nome -------");
                        Console.Write("Informe o novo nome: ");
                        string nome = Console.ReadLine();
                        funcionario.nome = nome;
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("------- Mudar sálario -------");
                        Console.Write("Informe o novo salário : ");
                        double salario = Convert.ToDouble(Console.ReadLine());
                        funcionario.salario = salario;
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("-------- Consultar Dados ---------");
                        Console.WriteLine("Nome: " + funcionario.nome);
                        Console.WriteLine("Salário: " + funcionario.salario);
                        Console.WriteLine("");
                        break;
                    case 0:
                        Console.WriteLine("");
                        Console.WriteLine("Até mais!");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Opção incorreta digite novamente!");
                        Console.WriteLine("");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
