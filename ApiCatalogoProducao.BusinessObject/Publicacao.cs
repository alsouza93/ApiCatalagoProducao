using System;

namespace ApiCatalogoProducao.BusinessObject
{
    public abstract class Publicacao
    {       
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public abstract DateTime? DataPublicacao { get; }
        public Ator[] Elenco { get; private set; }
        public Genero[] Generos { get; private set; }


        public bool Disponivel
        {
            get
            {
                return DataPublicacao != null && DataPublicacao.Value.Date <= DateTime.Now.Date;
            }
        }
        public Publicacao()
        {
        }

        public abstract void Publicar();

    }
}