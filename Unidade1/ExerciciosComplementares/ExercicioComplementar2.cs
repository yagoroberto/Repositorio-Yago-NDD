using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosComplementares
{
    class ExercicioComplementar2
    {
        static void Main10(string[] args)
        {
            Console.Write("Digite as horas trabalhadas: ");
            int horaTrabalhada = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor dado para cada hora trabalhada: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            double salario = 0;
            double horaExtra = 0;
            if (horaTrabalhada > 40)
            {
                horaExtra = (horaTrabalhada - 40) * (valorHora * 0.5);
                salario = (valorHora * 40) + horaExtra;
            }
            else
            {
                salario = horaTrabalhada * valorHora;
            }

            Console.WriteLine("Salario: " + salario);
            Console.ReadKey();
        }
    }
}
