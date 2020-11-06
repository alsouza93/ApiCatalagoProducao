using System;

namespace ApiCatalogoProducao.BusinessObject
{
    public class Ator
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Sexo Sexo { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Ator(int id, string nome, Sexo sexo, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
        }
    }
}