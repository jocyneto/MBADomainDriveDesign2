using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Domain
{
    public class Aluno
    {
      
        public int id { get; set; }
        public string nome { get; set; }
        public Email email { get; set; }
        public Telefone telefone { get; set; }

        public Aluno(int id, string nome, Email email, Telefone telefone)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }

    }

    public class Treinamento
    {
        public int id { get; set; }
        public CodigoTreinamento codigo { get; set; }
        public string descricao { get; set; }
        public int cargaHoraria { get; set; }
        public int capacidade { get; set; }

        public Treinamento(int id, CodigoTreinamento codigo, string descricao, int cargaHoraria, int capacidade)
        {
            this.id = id;
            this.codigo = codigo;
            this.descricao = descricao;
            this.cargaHoraria = cargaHoraria;
            this.capacidade = capacidade;
        }
    }

    public class Matricula
    {
        public int id { get; set; }
        public Aluno aluno { get; set; }
        public Treinamento treinamento { get; set; }
        public Periodo periodo { get; set; }
        public StatusMatricula status { get; set; } = StatusMatricula.ATIVO;
        public DateOnly dataInicio { get; set; }

        public Matricula(int id, Aluno aluno, Treinamento treinamento, Periodo periodo, DateOnly dataInicio)
        {
            this.id = id;
            aluno = aluno ?? throw new ArgumentNullException(nameof(aluno)); // Evita nulo
            treinamento = treinamento ?? throw new ArgumentNullException(nameof(treinamento)); // Evita nulo
            this.periodo = periodo;
            this.dataInicio = dataInicio;
        }
    }
}
