using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoDeDados
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<SangueColetado> SangueColetados { get; set; }
        public DbSet<ProcedimentoPaciente> ProcedimentoPacientes { get; set; }
        public DbSet<ProcedimentoAfereseDoador> ProcedimentoAfereseDoadors { get; set; }
        public DbSet<Paciente>  Pacientes { get; set; }
        public DbSet<Hemocentro>  Hemocentros { get; set; }
        public DbSet<Doador>  Doadores { get; set; }
        public DbSet<DadosMedico>  DadosMedicos { get; set; }
        public DbSet<BancoDeSangue>  BancoDeSangues { get; set; }
    }
}
