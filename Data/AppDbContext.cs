using Microsoft.EntityFrameworkCore;
using TodoListGrpc.Models;

namespace TodoListGrpc.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();
}