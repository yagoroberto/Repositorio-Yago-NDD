using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAPP.Exercicios
{
    class Exercicio5
    {
        static void main(string[] args)
        {
            Console.WriteLine("---------- Exercício 5 ----------");
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
        }
    }
}
