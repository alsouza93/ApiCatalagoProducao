using ApiCatalogoProducao.BusinessObject;
using System.Collections.Generic;

namespace ApiCatalogoProducao.Services
{
    public interface IFilmeService
    {
        List<Filme> ListarFilmes();
        Filme AdicionarFilme(Filme filme);
        Filme PublicarFilme(Filme filme);
        //Filme AdicionarElenco(Filme filme);
        //void RemoverFilme(Filme filme);
    }
}
