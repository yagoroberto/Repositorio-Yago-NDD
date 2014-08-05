using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteAluno
    {
        private static void Main6()
        {
            Aluno aluno1 = new Aluno();
            aluno1.nome = "Yago Roberto";
            aluno1.dataNascimento = "13/12/1996";
            aluno1.rg = "209938-7";

            Aluno aluno2 = new Aluno();
            aluno2.nome = "João da Silva";
            aluno2.dataNascimento = "24/04/1989";
            aluno2.rg = "123456-7";

            Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.dataNascimento);
            Console.WriteLine(aluno1.rg);

            Console.WriteLine(aluno2.nome);
            Console.WriteLine(aluno2.dataNascimento);
            Console.WriteLine(aluno2.rg);

            Console.ReadKey();
        }
    }
}
