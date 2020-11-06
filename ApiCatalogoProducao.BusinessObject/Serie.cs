using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiCatalogoProducao.BusinessObject
{
    public class Serie : Publicacao
    {
        private DateTime? dataPublicacao;
        public Temporada[] Temporadas { get; private set; }
        public override DateTime? DataPublicacao { get { return dataPublicacao; } }
        public Serie()
        {

        }

        public override void Publicar()
        {
            //Todo: série já publicada não pode ser publicada novamente para não mudar a data
            if (!Temporadas.Any())
                throw new Exception("Para publicar uma série é necessário ter temporadas.");

            dataPublicacao = DateTime.Now;
        }
    }
}