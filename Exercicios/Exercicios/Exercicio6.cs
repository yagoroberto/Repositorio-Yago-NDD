using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
    class Exercicio6
    {
        static void Main6(string[] args)
        {
            Console.WriteLine("---------- Exercício 6 ----------");
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
        }
    }
}
