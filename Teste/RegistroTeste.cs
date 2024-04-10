using Bogus;
using Dominio;
using ExpectedObjects;

namespace Teste 
{ 
    public class RegistroTeste
    {
        private string       _nome;
        private string       _numMatricula;
        private string       _email;
        private string       _telefone;

        public RegistroTeste()
        {
            Faker faker = new Faker();

            _nome = faker.Person.FullName;
            _numMatricula = faker.Random.Int(1000, 9999).ToString() + "-" +
                            faker.Random.Int(2010, 2024).ToString() + "-" +
                            faker.Random.Int(1, 2).ToString();
            _email = faker.Person.Email;
            _telefone = faker.Person.Phone;
        }

        [Fact]

        public void CriarObjetoRegistro()
        {
            var registroEsperado = new
            {
                Nome = _nome,
                NumMatricula = _numMatricula,
                Email = _email,
                Telefone = _telefone
            };

            Registro registro = new Registro( _nome, _numMatricula, _email, _telefone);  
            
            registroEsperado.ToExpectedObject().ShouldMatch( registro );
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]

        public void MatriculaObrigatoria(string numMatriculaErrada)
        {
            Assert.Throws<ArgumentException>(
                () =>
                new Registro(numMatriculaErrada, _nome, _email, _telefone)
                );
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]

        public void NomeObrigatorio(string nomeErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                new Registro(_numMatricula, nomeErrado, _email, _telefone)
                );
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]

        public void EmailObrigatorio(string emailErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                new Registro( _numMatricula, emailErrado, _nome, _telefone)
                );
        }

        [Theory]
        [InlineData("teste.com")]
        [InlineData("xxx.com.br")]
        [InlineData("teste8")]
        [InlineData("xunda@.br")]

        public void EmailInvalido(string emailErrado)
        {
            Assert.Throws<ArgumentException>(
                () =>
                new Registro(_numMatricula, emailErrado, _nome, _telefone)
                );
        }
    }
}