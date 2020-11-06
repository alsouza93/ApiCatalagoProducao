using System;
using System.Linq;

namespace ApiCatalogoProducao.BusinessObject
{
    public class Temporada
    {
        private DateTime dataPublicacao;
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataPublicacao { get { return dataPublicacao; } }
        public Episodio[] Episodios { get; set; }
        public Temporada()
        {
        }

        public void Publicar()
        {
            if (!Episodios.Any())
                throw new Exception("Para publicar uma temporada é necessário ter pelo menos 1 episódio.");

            if (Episodios.Count() <= 5)
                throw new Exception("Só é permitido publicar uma temporada com pelo menos 5 episódios.");

            dataPublicacao = DateTime.Now;
        }
    }
}
