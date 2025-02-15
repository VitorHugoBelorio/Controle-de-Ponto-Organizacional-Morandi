namespace PontoOrganizacionalMorandi.Models
{
    public class ModelPonto
    {
        public int Id { get; set; }
        public ModelUsuario Id_usuario { get; set; }
        public ModelUsuario Nome_usuario { get; set; }
        public DateTime Hora_entrada { get; set; }
        public DateTime Hora_saida { get; set; }
        public DateTime Total_horas_do_dia { get; set; }
    }
}
