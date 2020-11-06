using System;

namespace ApiCatalogoProducao.BusinessObject
{
    public class Episodio
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public Ator[] Elenco { get; private set; }
        public Episodio(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        public void AdicionarAtorNoElenco(Ator ator)
        {
            if (ator == null)
                throw new Exception("É necessário informar um ator para adicionar no elenco.");

            //todo: adicionar ator no elenco
        }
    }
}