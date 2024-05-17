using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SemIdentity.Entities;

namespace SemIdentity.Contexto
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        

        // ModelBuilder serve para configurar como as entidades no modelo vão ser mapeadas.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    AlunoId = 1,
                    Nome = "Yuri",
                    Email = "yuri@gmail.com",
                    Idade = 27

                

                });

        }
    }







    }

