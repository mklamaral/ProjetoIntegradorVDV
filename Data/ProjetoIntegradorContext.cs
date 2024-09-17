using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjetoIntegrador.Data
{
    public class ProjetoIntegradorContext : DbContext
    {
        public ProjetoIntegradorContext(DbContextOptions<ProjetoIntegradorContext> options) : base(options)
        {
        }
        public DbSet<ProjetoIntegrador.Models.Motorista> Motoristas { get; set; } = default!;

        public DbSet<ProjetoIntegrador.Models.Responsavel> Responsaveis { get; set; } = default!;

        public DbSet<ProjetoIntegrador.Models.Crianca> Criancas { get; set; } = default!;

        public DbSet<ProjetoIntegrador.Models.FrmDuvida> Duvidas { get; set; } = default!;

    }
}
