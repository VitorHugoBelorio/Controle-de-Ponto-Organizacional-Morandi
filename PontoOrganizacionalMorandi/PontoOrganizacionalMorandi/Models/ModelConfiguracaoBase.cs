namespace PontoOrganizacionalMorandi.Models
{
    public class ModelConfiguracaoBase
    {
        public DateTime Inicio_expediente { get; set; }
        public DateTime Fim_expediente { get; set; }
        public int Tempo_intervalo { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
