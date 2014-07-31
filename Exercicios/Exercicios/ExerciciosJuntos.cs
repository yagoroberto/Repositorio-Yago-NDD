using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
    class ExerciciosJuntos
    {
        public static int menu()
        {
            Console.WriteLine("---------- Menu ----------");
            Console.WriteLine("1 - Imprimir nome");
            Console.WriteLine("2 - Imprimir números");
            Console.WriteLine("3 - Impar & Par");
            Console.WriteLine("4 - Múltiplos de 4");
            Console.WriteLine("5 - Triangulo");
            Console.WriteLine("6 - Triangulo Repetidos");
            Console.WriteLine("7 - Fibonacci");
            Console.WriteLine("0 - Fechar");
            Console.Write("Selecione sua opção: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {

            Console.WriteLine("");
            Console.WriteLine("Bem Vindo!!");
            Console.WriteLine("");
            int opcao = -1;
            while (opcao != 0)
            {
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("---------- Imprimir Nome ----------");
                        Console.Write("Digite o nome que deseja imprimir: ");
                        String nome = Console.ReadLine();
                        Console.Write("Digite quantas vezes que deseja repetir o nome: ");
                        int repetirNome = Convert.ToInt32(Console.ReadLine());
                        for (int contadorNome = 1; contadorNome <= repetirNome; contadorNome++)
                        {
                            Console.WriteLine(contadorNome + " - " + nome);
                        }
                        Console.WriteLine("");
                            break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("---------- Imprimir Números ----------");
                        Console.Write("Informe até quando deseja contar: ");
                        int contarNumeros = Convert.ToInt32(Console.ReadLine());
                        for (int contadorNumeros = 1; contadorNumeros <= contarNumeros; contadorNumeros++)
                        {
                            if (contadorNumeros == 8000)
                            {
                                Console.WriteLine("É MAIS DE 8 MIL!!!!!!!!!!!1");
                            }
                            Console.WriteLine(contadorNumeros);
                        }
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("---------- Impar & Par ----------");
                        Console.Write("Informe até quando deseja contar: ");
                        int numeroParImpar = Convert.ToInt32(Console.ReadLine());
                        for (int contadorParImpar = 1; contadorParImpar <= numeroParImpar; contadorParImpar++)
                        {
                            int restoDoNumero = contadorParImpar % 2;
                            if (restoDoNumero == 1)
                            {
                                Console.WriteLine(contadorParImpar + " - *");
                            } else {
                                Console.WriteLine(contadorParImpar + " - **");
                            }
                        }
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("---------- Múltiplos de 4 ----------");
                        Console.Write("Informe até quando deseja contar: ");
                        int contarMultiplosDe4 = Convert.ToInt32(Console.ReadLine());
                        for (int contadorMultiplosDe4 = 1; contadorMultiplosDe4 <= contarMultiplosDe4; contadorMultiplosDe4++)
                        {
                            int multiplos = contadorMultiplosDe4 % 4;
                            if (multiplos == 0)
                            {
                                Console.WriteLine("PI");
                            } else {
                                Console.WriteLine(contadorMultiplosDe4);
                            }
                        }
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("---------- Triangulo ----------");
                        Console.Write("Informe quantas linhas o triangulo deve ter: ");
                        int linhasDoTriangulo = Convert.ToInt32(Console.ReadLine());
                        for (int contadorLinhas = 0; contadorLinhas <= linhasDoTriangulo; contadorLinhas++)
                        {
                            Console.WriteLine("");
                            if (contadorLinhas > 0)
                            {
                                Console.Write(contadorLinhas + " - ");
                            }
                            for (int contadorQuantidade = 0; contadorQuantidade < contadorLinhas; contadorQuantidade++)
                            {
                                Console.Write("*");
                            }
                        }
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine("---------- Triangulo repetido ----------");
                        Console.Write("Informe quantas linhas o triangulo deve ter: ");
                        int linhasTriangulo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Quantas vezes deve-se repetir o triangulo: ");
                        int repetirTriangulo = Convert.ToInt32(Console.ReadLine());
                        for (int contadorRepetirTriangulo = 0; contadorRepetirTriangulo < repetirTriangulo; contadorRepetirTriangulo++)
                        {
                            for (int contadorLinhas = 0; contadorLinhas <= linhasTriangulo; contadorLinhas++)
                            {
                                Console.WriteLine("");
                                for (int contadorQuantidade = 0; contadorQuantidade < contadorLinhas; contadorQuantidade++)
                                {
                                    Console.Write("*");
                                }
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                    case 7: 
                        Console.WriteLine("");
                        Console.WriteLine("---------- Fibonacci ----------");
                        Console.Write("Proximo de qual número deseja parar: ");
                        int pararFibonacci= Convert.ToInt32(Console.ReadLine());
                        int inicioFibonacci = 0;
                        int fimFibonacci = 1;
                        int calculoFibonacci = 0;
                        do
                        {
                            calculoFibonacci = inicioFibonacci + fimFibonacci;
                            inicioFibonacci = fimFibonacci;
                            fimFibonacci = calculoFibonacci;
                            Console.Write(calculoFibonacci);
                            if (pararFibonacci >= fimFibonacci)
                            {
                                Console.Write(", ");
                            }
                            else
                            {
                                Console.Write("...");
                            }
                        } while (pararFibonacci >= fimFibonacci);
                        Console.WriteLine("");
                        Console.WriteLine("O número mais proximo depois de " + pararFibonacci + " foi " + calculoFibonacci);
                        Console.WriteLine("");
                        break;
                    case 0:
                        Console.WriteLine("");
                        Console.WriteLine("Até mais!");
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Opção incorreta, digite novamente!");
                        Console.WriteLine("");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
