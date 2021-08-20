using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt03
{
    class Aluno
    {
        private string aluno;
        private int[] notas;

        public Aluno(string aluno, int[] notas)
        {
            this.aluno = aluno;
            this.notas = notas;
        }
        public void SetAluno(string aluno)
        {
            this.aluno = aluno;
        }
        public string GetAluno()
        {
            return aluno;
        }
        public void SetNotas(int [] notas)
        {
            this.notas = notas;
        }
        public int [] GetNotas()
        {
            return notas;
        }
    }
}
