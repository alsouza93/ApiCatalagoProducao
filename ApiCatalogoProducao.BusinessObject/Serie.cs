using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCatalogoProducao.BusinessObject
{
    public class Serie : Publicacao
    {
        public Temporada[] Temporadas { get; private set; }
    }
}