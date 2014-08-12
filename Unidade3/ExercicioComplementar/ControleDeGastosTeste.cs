using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Unidade3.ExercicioComplementar
{
    class ControleDeGastosTeste
    {
        public static void Main()
        {
            List<ControleDeGastos> controleGastos = new List<ControleDeGastos>();
            
            string opcao = "-1";
            int contador = -1;
            while (opcao != "0")
            {
                Console.WriteLine("");
                Console.WriteLine("--------- Selecione sua opção ---------");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("0 - Sair");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        contador++;
                        ControleDeGastos controleGasto = new ControleDeGastos();
                        Console.WriteLine("");
                        Console.WriteLine("--------- Cadastrar ---------");
                        Console.Write("Informe o tipo de gasto: ");
                        controleGasto.tipoDeGasto = Console.ReadLine();
                        Console.Write("Informe a data da compra: ");
                        controleGasto.dataGasto = Console.ReadLine();
                        Console.Write("Informe o valor cobrado: ");
                        controleGasto.valorGasto = Convert.ToDouble(Console.ReadLine());
                        int formaPagamento = -1;
                        while(formaPagamento != 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Informe a forma de pagamento: ");
                            Console.WriteLine("1 - Dinheiro");
                            Console.WriteLine("2 - Cheque");
                            Console.WriteLine("3 - Cartão");
                            Console.WriteLine("4 - Cheque pré");
                            controleGasto.formaDePagamento = Console.ReadLine();
                            switch (controleGasto.formaDePagamento)
                            {
                                case "1":
                                    controleGasto.formaDePagamento = "Dinheiro";
                                    formaPagamento = 0;
                                    break;
                                case "2":
                                    controleGasto.formaDePagamento = "Cheque";
                                    formaPagamento = 0;
                                    break;
                                case "3":
                                    controleGasto.formaDePagamento = "Cartão";
                                    formaPagamento = 0;
                                    break;
                                case "4":
                                    controleGasto.formaDePagamento = "Cheque pré";
                                    formaPagamento = 0;
                                    break;
                                default:
                                    Console.WriteLine("Opção incorreta digite novamente!");
                                    break;
                            }
                        }
                        controleGastos.Add(controleGasto);
                        Console.WriteLine("");
                        break;
                    case "2":
                        Console.WriteLine("");
                        Console.WriteLine("--------- Listar ---------");
                        Console.WriteLine("");
                        if (contador == -1)
                        {
                            Console.WriteLine("Nenhum gasto cadastrado!");
                        }
                        else
                        {
                            foreach (ControleDeGastos listar in controleGastos)
                            {
                                Console.WriteLine("Tipo de gasto: " + listar.tipoDeGasto);
                                Console.WriteLine("Data: " + listar.dataGasto);
                                Console.WriteLine("Valor gasto: R$ " + listar.valorGasto);
                                Console.WriteLine("Forma de Pagamento: " + listar.formaDePagamento);
                                Console.WriteLine("");
                            }
                        }
                        Console.WriteLine("");
                        break;
                    case "0":
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
