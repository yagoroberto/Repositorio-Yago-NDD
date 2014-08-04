
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.Exercicios
{
    class Exercicio2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("---------- Exercício 2 ----------");
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
            Console.ReadKey();
        }
    }
}
