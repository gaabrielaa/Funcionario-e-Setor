using apifuncionario.Models;
using Microsoft.EntityFrameworkCore;

namespace apifuncionario.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base 
    (options)
    {
    }

    public DbSet<Funcionario> Funcionarios {get;set;}
    public DbSet<Setor> Setors {get;set;}
}