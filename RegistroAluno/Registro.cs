namespace Dominio
{
    public class Registro
    {
        private string nome;
        private string numMatricula;
        private string email;
        private string telefone;

        public Registro(string nome, string numMatricula, string email, string telefone)
        {
            if (string.IsNullOrEmpty(numMatricula)) throw new ArgumentException();
            if (string.IsNullOrEmpty(nome)) throw new ArgumentException();
            if (string.IsNullOrEmpty(email)) throw new ArgumentException();

            this.Nome = nome;
            this.NumMatricula = numMatricula;
            this.Email = email;
            this.Telefone = telefone;
        }

        public string Nome { get => nome; set => nome = value; }
        public string NumMatricula { get => numMatricula; set => numMatricula = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}