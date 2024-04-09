//O cadastro de um novo aluno
//deve ser realizado com seu nome, número de matrícula, e-mail e
//telefone de contato.
namespace Dominio
{
    public class Registro
    {
        private string nome;
        private string numMatricula;
        private string email;
        private int telefone;

        public Registro(string nome, string numMatricula, string email, int telefone)
        {
            this.Nome = nome;
            this.NumMatricula = numMatricula;
            this.Email = email;
            this.Telefone = telefone;
        }

        public string Nome { get => nome; set => nome = value; }
        public string NumMatricula { get => numMatricula; set => numMatricula = value; }
        public string Email { get => email; set => email = value; }
        public int Telefone { get => telefone; set => telefone = value; }
    }
}