using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = default!;
    public DbSet<User> User { get; set; } = default!;

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     // configures one-to-many relationship
    //     modelBuilder.Entity<User>()
    //     .HasMany(c => c.Todo)
    //     .WithOne(e => e.User)
    //     .IsRequired();         
    // }
}