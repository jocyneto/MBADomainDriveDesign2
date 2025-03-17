using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Domain
{
    public class MatriculaService
    {
        private static int _proximoIdMatricula = 1;
        public static List<Matricula> matriculas { get; set; } = new List<Matricula>();
        public static List<Aluno> alunos { get; set; } = new List<Aluno>();
        public static List<Treinamento> treinamentos { get; set; } = new List<Treinamento>();

        public MatriculaService()
        {
            
        }

        public Matricula matricularAluno(Aluno aluno, Treinamento treinamento, Periodo periodo, DateOnly dataInicio)
        {
            if(alunoPossuiMatriculaAtiva(aluno))
                throw new ArgumentException("\nAluno já possui matricula.");

            var matricula = new Matricula(_proximoIdMatricula, aluno, treinamento, periodo, dataInicio);

            _proximoIdMatricula += 1;

            return matricula;
        }

        public bool alunoPossuiMatriculaAtiva(Aluno aluno)
        {
            foreach (var m in matriculas)
            {
                if (m.aluno.id == aluno.id && m.status == StatusMatricula.ATIVO)
                    return true;
            }
            return false;
        }

        public void adicionarAluno(Aluno aluno)
        {
            if (aluno == null)
                throw new ArgumentException("\nAluno vazio.");

            foreach (var a in alunos)
            {
                if (a.id == aluno.id)
                    throw new ArgumentException("\nAluno de ID já criado.");
            }

            alunos.Add(aluno);
            return;
        }

        public void adicionarTreinamento(Treinamento treinamento)
        {
            if (treinamento == null)
                throw new ArgumentException("\nTreinamento vazio.");

            foreach (var t in treinamentos)
            {
                if (t.id == treinamento.id)
                    throw new ArgumentException("\nTreinamento de ID já criado.");

                if(t.codigo.codigo == treinamento.codigo.codigo)
                    throw new ArgumentException("\nCodigo de treinamento já criado.");
            }

            treinamentos.Add(treinamento);
            return;
        }
    }
}
