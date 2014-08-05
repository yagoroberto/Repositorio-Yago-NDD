using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExerciciosComplementares
{
    class TesteAluno
    {
        private static void Main6()
        {
            Aluno aluno1 = new Aluno();
            aluno1.nome = "Yago Roberto";
            aluno1.dataNascimento = "13/12/1996";
            aluno1.rg = "209938-7";

            Turma turma1 = new Turma();
            turma1.periodo = "Vespertino";
            turma1.serie = "1ª Fase";
            turma1.sigla = "Fac";
            turma1.tipoEnsino = "Ensino Superior";

            aluno1.turma = turma1;

            Aluno aluno2 = new Aluno();
            aluno2.nome = "João da Silva";
            aluno2.dataNascimento = "24/04/1989";
            aluno2.rg = "123456-7";

            Turma turma2 = new Turma();
            turma2.periodo = "Matutino";
            turma2.serie = "7ª Fase";
            turma2.sigla = "Fac";
            turma2.tipoEnsino = "Ensino Superior";

            aluno2.turma = turma2;

            Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.dataNascimento);
            Console.WriteLine(aluno1.rg);
            Console.WriteLine(aluno1.turma.periodo);
            Console.WriteLine(aluno1.turma.serie);
            Console.WriteLine(aluno1.turma.sigla);
            Console.WriteLine(aluno1.turma.tipoEnsino);


            Console.WriteLine(aluno2.nome);
            Console.WriteLine(aluno2.dataNascimento);
            Console.WriteLine(aluno2.rg);
            Console.WriteLine(aluno2.turma.periodo);
            Console.WriteLine(aluno2.turma.serie);
            Console.WriteLine(aluno2.turma.sigla);
            Console.WriteLine(aluno2.turma.tipoEnsino);

            Console.ReadKey();
        }
    }
}
