using Microsoft.EntityFrameworkCore;
using Flexco.API.Data;  
using Flexco.API.Models;
using System;

namespace Flexco.API.Data; 

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Ferramenta> Ferramentas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Contrato> Contratos { get; set; }
}
