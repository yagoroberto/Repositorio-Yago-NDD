using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosComplementares
{
    class ExercicioComplementar5
    {
        static void Main13(string[] args)
        {
            Console.Write("Digite a quantidade de litros vendido: ");
            int litrosVendido = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o tipo de combustivel (Alcool ou Gasolina): ");
            string tipoCombustivel = Console.ReadLine();

            double total = 0;
            double desconto = 0;
            if (tipoCombustivel == "Gasolina" || tipoCombustivel == "gasolina")
            {
                if (litrosVendido > 20)
                {
                    desconto = 3.30 - (0.06 * 3.30);
                    total = litrosVendido * desconto;
                }
                else
                {
                    desconto = 3.30 - (0.04 * 3.30);
                    total = litrosVendido * desconto;
                }
                Console.WriteLine("Total = " + total);
            }
            else if (tipoCombustivel == "Alcool" || tipoCombustivel == "alcool")
            {
                if (litrosVendido > 20)
                {
                    desconto = 2.90 - (0.03 * 3.30);
                    total = litrosVendido * desconto;
                }
                else
                {
                    desconto = 2.90 - (0.05 * 3.30);
                    total = litrosVendido * desconto;
                }
                Console.WriteLine("Total = " + total);
            }
            else
            {
                Console.WriteLine("Opção incorreta");
            }
            Console.ReadKey();
        }
    }
}
