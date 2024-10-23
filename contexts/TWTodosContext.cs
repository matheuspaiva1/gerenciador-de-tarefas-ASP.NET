using Microsoft.EntityFrameworkCore;
using TWtodos2.Models;

namespace TWtodos2.Contexts;

public class TWTodosContext : DbContext {
  public DbSet<Todo> Todos => Set<Todo>();
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
    optionsBuilder.UseSqlite("Data source=todos.sqlite3");
  }
}