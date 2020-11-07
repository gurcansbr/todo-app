using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;

namespace TodoList.DataAccess.Concrete.EntityFramework.Contexts
{
    public class TodoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // db name - tododb
            // change server name
            optionsBuilder.UseSqlServer(@"Server=CHANGE_ME;initial catalog=tododb;integrated security=true");
        }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(
                new Todo
                {
                    Id = 1,
                    Title = "Job Interview",
                    Description = "Create a project for interview",
                    IsCompleted = true,
                    Period = Enums.Period.Daily,
                    CreatedAt = DateTime.Parse("07.11.2020 18:21"),
                    UpdatedAt = DateTime.Parse("07.11.2020 18:21")
                }
            );
        }
    }
}
