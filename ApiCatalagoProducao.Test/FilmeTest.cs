using ApiCatalogoProducao.BusinessObject;
using ApiCatalogoProducao.BussinessObject;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions.Brazil;
using Bogus.Extensions.UnitedStates;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ApiCatalagoProducao.Test
{
    public class FilmeTest
    {
        [Fact]
        public void AdicionarAtorNoElenco_ProducaoNormal_NaoPodeAdicionarAcimaDe2Atores()
        {
            //Arrange
            var ator = GerarAtores(1);
            var filme = new Filme(192, "Harry Potter", DateTime.Now.AddYears(-1), GerarAtores(2), Genero.Acao, TipoProducao.Curta);
                      
            //Act & Assert
            Assert.Throws<Exception>(() => filme.AdicionarAtorNoElenco(ator[0]));
        }

        [Fact]
        public void AdicionarAtorNoElenco_ProducaoNormal_DeveAdicionar50Atores()
        {
            //Arrange
            var atores = new Faker<Ator>("pt_BR")
                .CustomInstantiator(a => new Ator(
                    new Guid(),
                    a.Name.FirstName(),
                    a.PickRandom<Sexo>(),
                    a.Date.Past(20),
                    Cpf.FromString(a.Person.Cpf())))
                .Generate(50);

            var filme = new Filme(
                192,
                "Harry Potter",
                DateTime.Now.AddMonths(1),
                new List<Ator>(),
                Genero.Acao,
                TipoProducao.Normal);

            //Act 
            foreach (var ator in atores)
            {
                filme.AdicionarAtorNoElenco(ator);
            }

            //Assert
            Assert.Equal(50, filme.Elenco.Count());
        }

        [Fact]
        public void AdicionarAtorNoElenco_ProducaoNormal_DeveAdicionar0Atores()
        {
            //Arrange
            var atores = GerarAtores(50);

            var filme = new Filme(
                192,
                "Harry Potter",
                DateTime.Now.AddMonths(1),
                new List<Ator>(),
                Genero.Acao,
                TipoProducao.Normal);

            //Act 
            foreach (var ator in atores)
            {
                filme.AdicionarAtorNoElenco(ator);
            }

            //Assert
            Assert.Equal(50, filme.Elenco.Count());
        }

        private List<Ator> GerarAtores(int quantidade)
        {
            var genero = new Faker().PickRandom<Name.Gender>();
            return new Faker<Ator>("pt_BR")
                .CustomInstantiator(a => new Ator(
                    new Guid(),
                    a.Name.FirstName(genero),
                    genero == Name.Gender.Female ? Sexo.feminino : Sexo.masculino,
                    a.Date.Past(20),
                    Cpf.FromString(a.Person.Ssn())))
                .Generate(quantidade);
        }
    }
}
