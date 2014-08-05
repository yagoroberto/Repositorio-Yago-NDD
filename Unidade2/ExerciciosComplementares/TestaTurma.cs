using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExerciciosComplementares
{
    class TestaTurma
    {
        private static void Main7()
        {
            Turma turma1 = new Turma();
            turma1.periodo = "Matutino";
            turma1.serie = "1º Ano";
            turma1.sigla = "Mat";
            turma1.tipoEnsino = "Ensino Médio";

            Console.WriteLine(turma1.periodo);
            Console.WriteLine(turma1.serie);
            Console.WriteLine(turma1.sigla);
            Console.WriteLine(turma1.tipoEnsino);

            Turma turma2 = new Turma();
            turma2.periodo = "Vespertino";
            turma2.serie = "7ª Fase";
            turma2.sigla = "Fac";
            turma2.tipoEnsino = "Ensino Superior";

            Console.WriteLine(turma2.periodo);
            Console.WriteLine(turma2.serie);
            Console.WriteLine(turma2.sigla);
            Console.WriteLine(turma2.tipoEnsino);

            Console.ReadKey();
        }
    }
}
