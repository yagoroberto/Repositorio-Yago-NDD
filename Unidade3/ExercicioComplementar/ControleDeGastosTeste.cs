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
            int contador = 1;
            while (opcao != "0")
            {
                Console.WriteLine("");
                Console.WriteLine("--------- Selecione sua opção ---------");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Procurar por codigo");
                Console.WriteLine("0 - Sair");
                opcao = Console.ReadLine();
                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        ControleDeGastos controleGasto = new ControleDeGastos();
                        Console.WriteLine("");
                        controleGasto.codigo = contador;
                        Console.WriteLine("--------- Cadastrar ---------");
                        Console.WriteLine("Codigo do gasto: " + contador);
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
                        Console.Clear();
                        Console.WriteLine("");
                        contador++;
                        break;
                    case "2":
                        Console.WriteLine("");
                        Console.WriteLine("--------- Listar ---------");
                        Console.WriteLine("");

                        double valorTotal = 0;
                        if (controleGastos.Count < 1)
                        {
                            Console.WriteLine("Nenhum gasto cadastrado!");
                        }
                        else
                        {
                            foreach (ControleDeGastos listar in controleGastos)
                            {
                                Console.WriteLine("Codigo do gasto: " + listar.codigo);
                                Console.WriteLine("Tipo de gasto: " + listar.tipoDeGasto);
                                Console.WriteLine("Data: " + listar.dataGasto);
                                Console.WriteLine("Valor gasto: R$ " + listar.valorGasto);
                                Console.WriteLine("Forma de Pagamento: " + listar.formaDePagamento);
                                Console.WriteLine("");
                                valorTotal += listar.valorGasto;
                            }
                        }

                        Console.WriteLine("Valor total: " + valorTotal);
                        Console.WriteLine("");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("");
                        Console.WriteLine("--------- Procurar ---------");
                        Console.WriteLine("");
                        Console.Write("Digite o código do gasto que deseja procurar: ");
                        int codigoGasto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        if (controleGastos.Count < 1)
                        {
                            Console.WriteLine("Nenhum gasto cadastrado!");
                        }
                        else
                        {
                            foreach (ControleDeGastos listar in controleGastos)
                            {
                                if (listar.codigo == codigoGasto) { 
                                    Console.WriteLine("Gasto encontrado!!");
                                    Console.WriteLine("");
                                    Console.WriteLine("Tipo de gasto: " + listar.tipoDeGasto);
                                    Console.WriteLine("Data: " + listar.dataGasto);
                                    Console.WriteLine("Valor gasto: R$ " + listar.valorGasto);
                                    Console.WriteLine("Forma de Pagamento: " + listar.formaDePagamento);
                                    string acao = "-1";
                                    while (acao != "0")
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Deseja fazer alguma dessas ações: ");
                                        Console.WriteLine("1 - Excluir");
                                        Console.WriteLine("2 - Alterar");
                                        Console.WriteLine("0 - Não desejo");
                                        acao = Console.ReadLine();
                                        switch (acao)
                                        {
                                            case "1":
                                                controleGastos.Remove(listar);
                                                Console.WriteLine("Removido com sucesso!");
                                                acao = "0";
                                                break;
                                            case "2":
                                                //Necessário aperfeiçoar!
                                                Console.WriteLine("");
                                                Console.WriteLine("--------- Alterar ---------");
                                                Console.Write("Informe o tipo de gasto: ");
                                                listar.tipoDeGasto = Console.ReadLine();
                                                Console.Write("Informe a data da compra: ");
                                                listar.dataGasto = Console.ReadLine();
                                                Console.Write("Informe o valor cobrado: ");
                                                listar.valorGasto = Convert.ToDouble(Console.ReadLine());
                                                int formaPagamentoo = -1;
                                                while(formaPagamentoo != 0)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Informe a forma de pagamento: ");
                                                    Console.WriteLine("1 - Dinheiro");
                                                    Console.WriteLine("2 - Cheque");
                                                    Console.WriteLine("3 - Cartão");
                                                    Console.WriteLine("4 - Cheque pré");
                                                    listar.formaDePagamento = Console.ReadLine();
                                                    switch (listar.formaDePagamento)
                                                    {
                                                        case "1":
                                                            listar.formaDePagamento = "Dinheiro";
                                                            formaPagamentoo = 0;
                                                            break;
                                                        case "2":
                                                            listar.formaDePagamento = "Cheque";
                                                            formaPagamentoo = 0;
                                                            break;
                                                        case "3":
                                                            listar.formaDePagamento = "Cartão";
                                                            formaPagamentoo = 0;
                                                            break;
                                                        case "4":
                                                            listar.formaDePagamento = "Cheque pré";
                                                            formaPagamentoo = 0;
                                                            break;
                                                        default:
                                                            Console.WriteLine("Opção incorreta digite novamente!");
                                                            break;
                                                    }
                                                }
                                                acao = "0";
                                                break;
                                            case "0":
                                                break;
                                            default:
                                                Console.WriteLine("Opção incorreta!");
                                                break;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
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