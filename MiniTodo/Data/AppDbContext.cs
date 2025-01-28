using Microsoft.EntityFrameworkCore;
using MiniTodo.Model;

namespace MiniTodo.Data;

public class AppDbContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Data Source=localhost;Initial Catalog=MinimalAppTodo;Trusted_Connection=True; max pool size=500;TrustServerCertificate=true");
}