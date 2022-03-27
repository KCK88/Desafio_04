using System.Collections.Generic;
using System.Linq;
namespace Desafio_04
{
    public class Aluno
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Aluno(string Name, int Age, double Grade)
        {
            this.Name = Name;
            this.Age = Age;
            this.Grade = Grade;
        }
    }
}