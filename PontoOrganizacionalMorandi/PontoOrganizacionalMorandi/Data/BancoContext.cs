using Microsoft.EntityFrameworkCore;
using PontoOrganizacionalMorandi.Models;
namespace PontoOrganizacionalMorandi.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
            
        }
        public DbSet<ModelConfiguracaoBase> DBSetConfiguracaoBase { get; set; }
        public DbSet<ModelPonto> DBSetPonto { get; set; }
        public DbSet<ModelUsuario> DBSetUsuario { get; set; }
    }
}
