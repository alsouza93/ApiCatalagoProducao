using ApiCatalogoProducao.BusinessObject;
using System.Collections.Generic;

namespace ApiCatalogoProducao.Repositories
{
    public interface IFilmeRepository
    {
        List<Filme> ListarFilmes();
        Filme AdicionarFilme(Filme filme);
        Filme PublicarFilme(Filme filme);       
        void RemoverFilme(Filme filme);
    }
}