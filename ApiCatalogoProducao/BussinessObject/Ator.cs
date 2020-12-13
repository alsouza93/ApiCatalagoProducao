using ApiCatalogoProducao.BusinessObject;
using System;

namespace ApiCatalogoProducao.BussinessObject
{
    public class Ator
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public Sexo Sexo { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Cpf Cpf { get; private set; }
        public int Idade { get { return DateTime.Now.Year - DataNascimento.Year; } }
        public Ator(Guid id, string nome, Sexo sexo, DateTime dataNascimento, Cpf cpf)
        {
            Id = id;
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }
    }
}