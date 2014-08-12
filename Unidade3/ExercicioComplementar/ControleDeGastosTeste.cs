using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.ExercicioComplementar
{
    class ControleDeGastosTeste
    {
        private static void Main()
        {

            ControleDeGastos[] controleGastos = new ControleDeGastos[10];

            int opcao = -1;
            int contador = -1;
            while (opcao != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("----- Selecione sua opção -----");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("----- Cadastrar -----");
                        Console.WriteLine("-------- Controle de gastos ---------");
                        Console.Write("Informe o tipo de gasto: ");
                        controleGastos[contador].tipoDeGasto = Console.ReadLine();
                        Console.Write("Informe a data da compra: ");
                        controleGastos[contador].dataGasto = Console.ReadLine();
                        Console.Write("Informe o valor cobrado: ");
                        controleGastos[contador].valorGasto = Convert.ToDouble(Console.ReadLine());
                        int formaPagamento = -1;
                        while(formaPagamento != 0)
                        {
                            Console.WriteLine("Informe a forma de pagamento: ");
                            Console.WriteLine("1 - Dinheiro");
                            Console.WriteLine("2 - Cheque");
                            Console.WriteLine("3 - Cartão");
                            Console.WriteLine("4 - Cheque pré");
                            controleGastos[contador].formaDePagamento = Console.ReadLine();
                            switch (controleGastos[contador].formaDePagamento)
                            {
                                case "1":
                                    controleGastos[contador].formaDePagamento = "Dinheiro";
                                    formaPagamento = 0;
                                    break;
                                case "2":
                                    controleGastos[contador].formaDePagamento = "Cheque";
                                    formaPagamento = 0;
                                    break;
                                case "3":
                                    controleGastos[contador].formaDePagamento = "Cartão";
                                    formaPagamento = 0;
                                    break;
                                case "4":
                                    controleGastos[contador].formaDePagamento = "Cheque pré";
                                    formaPagamento = 0;
                                    break;
                                default:
                                    Console.WriteLine("Opção incorreta digite novamente!");
                                    break;
                            }
                        }
                        Console.WriteLine("");
                        contador++;
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("------- Listar -------");
                        if (contador == -1)
                        {
                            Console.WriteLine("Nenhum gasto cadastrado!");
                        }
                        else
                        {
                            for (int i = 0; i < contador; i++)
                            {
                                Console.WriteLine("Tipo de gasto: " + controleGastos[i].tipoDeGasto);
                                Console.WriteLine("" + controleGastos[contador].dataGasto);
                                Console.WriteLine("" + controleGastos[contador].valorGasto);
                                Console.WriteLine("" + controleGastos[contador].formaDePagamento);
                                Console.WriteLine("");
                            }
                        }
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
