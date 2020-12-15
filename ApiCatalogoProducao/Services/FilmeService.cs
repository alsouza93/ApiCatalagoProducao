using ApiCatalogoProducao.BusinessObject;
using ApiCatalogoProducao.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoProducao.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository filmeRepository;
        public FilmeService(IFilmeRepository filmeRepository)
        {
            this.filmeRepository = filmeRepository;
        }

        public Filme AdicionarElenco(Filme filme)
        {
            throw new NotImplementedException();
        }

        public Filme AdicionarFilme(Filme filme)
        {
            return filmeRepository.AdicionarFilme(filme);
        }

        public List<Filme> ListarFilmes()
        {
            return filmeRepository.ListarFilmes();
        }

        public Filme PublicarFilme(Filme filme)
        {
            //Adicionar data de publicacao como data atual
            //

            throw new NotImplementedException();
        }

        //public void RemoverFilme(Filme filme)
        //{
        //    filmeRepository.RemoverFilme(filme);
        //}
    }
}
