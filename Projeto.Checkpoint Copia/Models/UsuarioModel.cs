namespace Projeto.Checkpoint.Models
{
    public class UsuarioModel
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}
        public string TipoUsuario {get; set;}

    public UsuarioModel(string nome, string email, string senha, string tipousuario)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.TipoUsuario = tipousuario;
        }

    public UsuarioModel(int id, string nome, string email, string senha, string tipousuario)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.TipoUsuario = tipousuario;
        }
    }
}