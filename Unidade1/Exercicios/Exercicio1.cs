﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.Exercicios
{
    class Exercicio1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("---------- Exercício 1 ----------");
            Console.WriteLine("---------- Imprimir Nome ----------");
            Console.Write("Digite o nome que deseja imprimir: ");
            String nome = Console.ReadLine();
            Console.Write("Digite quantas vezes que deseja repetir o nome: ");
            int repetirNome = Convert.ToInt32(Console.ReadLine());
            for (int contadorNome = 1; contadorNome <= repetirNome; contadorNome++)
            {
                Console.WriteLine(contadorNome + " - " + nome);
            }
            Console.ReadKey();
        }
    }
}
