using Bogus;
using Dominio;
using ExpectedObjects;

namespace Teste 
{ 
    public class RegistroTeste
    {
        private string    _nome;
        private string    _numMatricula;
        private string    _email;
        private int       _telefone;

        Faker faker = new Faker();
        public RegistroTeste()
        {
            this._nome = "Bryann";
            this._numMatricula = faker.Random.Int(1000, 9999).ToString() + "-" +
                                 faker.Random.Int(2010, 2024).ToString() + "-" +
                                 faker.Random.Int(1, 2).ToString();
            this._email = "branncena@penis.com";
            this._telefone = 69696669;
        }

        [Fact]

        public void CriarObjetoRegistro()
        {
            var RegistroEsperado = new
            {
                Nome = _nome,
                NumMatricula = _numMatricula,
                Email = _email,
                Telefone = _telefone
            };
            Registro registro = new Registro(
                _nome, _numMatricula,
                _email, _telefone
            );  
            
            RegistroEsperado.ToExpectedObject().ShouldMatch( registro );
        }
    }
}