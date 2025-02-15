namespace PontoOrganizacionalMorandi.Models
{
    public class ModelUsuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set;}
        public string Email { get; set;}

        // public int Cargo { get; set;}  // A ver se é possível definir os níveis de importância sem necessitar passar para o banco.
    }
}
