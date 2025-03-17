using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aula.Domain
{

    public enum Periodo
    {
        MANHA = 0,
        TARDE = 1,
        NOITE = 2,
    }

    public enum StatusMatricula
    {
        ATIVO = 0,
        CONCLUIDO = 1,
        DESERTADO = 2,
    }

    public class Email
    {
        private string _emailAdress;

        public string emailAdress 
        { 
            get { return _emailAdress; }
            set 
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    throw new ArgumentException("\nEndereço de E-mail inválido.");
                }
                _emailAdress = value;
            } 
        }

        public Email(string emailAdress)
        {
            this.emailAdress = emailAdress;
        }
    }

    public class Telefone 
    {
        private string _numero; 
        public string numero 
        { 
            get { return _numero; } 
            set
            {
                if (!Regex.IsMatch(value, @"^\d{2}-\d{4,5}-\d{4}$"))
                {
                    throw new ArgumentException("\nFormato de telefone inválido.\nO formato deve ser DDD-99999-9999.");
                }
                _numero = value;
            } 
        }

        public Telefone(string numero)
        {
            this.numero = numero;
        }

    }

    public class CodigoTreinamento
    {
        private string _codigo;

        public string codigo 
        { 
            get 
            { return _codigo; } 
            set 
            {
                if (!Regex.IsMatch(value, @"^[A-Z]{2}[0-9]{2}$"))
                {
                    throw new ArgumentException($"\nO Código de treinamento { value } é inválido...");
                }
                _codigo = value;
            }
        }

        public CodigoTreinamento(string codigo)
        {
            this.codigo = codigo;
        }
    }
}
