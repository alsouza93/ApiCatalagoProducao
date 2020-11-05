using System;

namespace ApiCatalogoProducao.BusinessObject
{
    public class Episodio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Ator[] Elenco { get; set; }
        public DateTime DataPublicacao { get; set; }

        public Episodio()
        {

        }
    }
}