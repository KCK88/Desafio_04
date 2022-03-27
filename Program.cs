using System;
using System.Collections.Generic;

namespace Desafio_04
{
    class Program
    {
        static void Main(string[] args)
        {   
            var AlunoUm = new Aluno("Paulo", 21, 7.5 );
            var AlunoDois = new Aluno("Claudio", 20, 6.5);
            var AlunoTres = new Aluno("Matheus", 23, 6.0);

            Aluno[] Alunos = {AlunoUm, AlunoDois, AlunoTres};
            List<Aluno> AlunosList = new List<Aluno>(Alunos);
            
            foreach (var aluno in AlunosList)
            {
                Console.WriteLine(aluno.Name);
                Console.WriteLine(aluno.Age);
                Console.WriteLine(aluno.Grade);
            }
        }
    }
}
