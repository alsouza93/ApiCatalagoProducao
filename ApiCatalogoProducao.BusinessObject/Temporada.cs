using System;

namespace ApiCatalogoProducao.BusinessObject
{
    public class Temporada
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public Episodio[] Episodios { get; set; }
        public bool Disponivel { get; set; }
        public Temporada()
        {

        }
    }
}
