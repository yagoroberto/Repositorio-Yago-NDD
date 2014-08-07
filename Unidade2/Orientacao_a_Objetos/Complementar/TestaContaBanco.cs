using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos.Complementar
{
    class TestaContaBanco
    {
        private static void Main222()
        {
            Console.WriteLine("-------- Conta de Banco ---------");
            Console.Write("Informe o número da conta: ");
            int numeroConta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o limite da conta: ");
            double limiteConta = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o saldo da conta: ");
            double saldoConta = Convert.ToDouble(Console.ReadLine());

            ContaBanco contaBanco = new ContaBanco();

            contaBanco.numero = numeroConta;
            contaBanco.limite = limiteConta;
            contaBanco.saldo = saldoConta;

            int opcao = -1;

            while (opcao != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("----- Selecione sua opção -----");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Imprimir extrato");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("------- Depositar -------");
                        Console.Write("Informe o valor que deseja depositar: ");
                        double depositar = Convert.ToDouble(Console.ReadLine());
                        contaBanco.Deposita(depositar);
                        Console.WriteLine("Saldo total: " + contaBanco.saldo);
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("------- Sacar -------");
                        Console.Write("Informe o valor que deseja sacar: ");
                        double sacar = Convert.ToDouble(Console.ReadLine());
                        contaBanco.Saca(sacar);
                        Console.WriteLine("Saldo total: " + contaBanco.saldo);
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("-------- Imprimir Extrato ---------");
                        Console.WriteLine("Número da conta: " + contaBanco.numero);
                        Console.WriteLine("Limite: " + contaBanco.limite);
                        Console.WriteLine("Saldo: " + contaBanco.saldo);
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
