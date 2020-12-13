using ApiCatalogoProducao.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiCatalogoProducao.BusinessObject
{
    public class Filme
    {
        private List<Ator> elenco;
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime? DataPublicacao { get; private set; }
        public IEnumerable<Ator> Elenco { get { return elenco.AsEnumerable(); } }
        public Genero Genero { get; private set; }
        public TipoProducao TipoProducao { get; private set; }
        public bool Disponivel
        {
            get
            {
                return DataPublicacao != null &&
                    DataPublicacao.Value.Date.CompareTo(DateTime.Now) < 0;
            }
        }

        public Filme(int id, string nome, DateTime? dataPublicacao, List<Ator> elenco, Genero genero, TipoProducao tipoProducao)
        {
            Id = id;
            Nome = nome;
            DataPublicacao = dataPublicacao;
            Genero = genero;
            this.elenco = elenco;
            TipoProducao = TipoProducao;
        }       

        public void AdicionarAtorNoElenco(Ator ator)
        {
            if (ator.Idade < 18 && Genero == Genero.Terror)
                throw new Exception("Não é permitido ator menor de idade neste filme.");
            if (Disponivel)
                throw new Exception("Não é permitido adicionar ator no elenco após a publicação.");
            if (TipoProducao == TipoProducao.Curta && Elenco.Count() == 5)
                throw new Exception("Não é permitido adicionar mais de 5 atores no elenco.");
            if (TipoProducao == TipoProducao.Normal && Elenco.Count() == 50)
                throw new Exception("Não é permitido adicionar mais de 50 atores no elenco.");

            elenco.Add(ator);
        }
    }
}
