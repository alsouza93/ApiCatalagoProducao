using System;

namespace ApiCatalogoProducao.BusinessObject
{
    public abstract class Publicacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataPublicacao { get; set; }
        public Ator[] Elenco { get; set; }
        public Genero[] Generos { get; set; }
        public Publicacao()
        {

        }

    }
}