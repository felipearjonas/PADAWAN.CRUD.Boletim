using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PADAWAN.CRUD.Models;

namespace PADAWAN.CRUD.Context
{
    public class BoletimContext : DbContext
    {
        public BoletimContext()
        {
        }

        public BoletimContext(DbContextOptions<BoletimContext> options): base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<AlunoMateria> Notas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlServer("Data Source=NT-03185\\SQLEXPRESS;Initial Catalog=PadawanBoletim;Integrated Security=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BoletimContext).Assembly);


            modelBuilder.Entity<CursoMateria>().HasKey(sc => new { sc.IdCurso, sc.IdMateria });
            modelBuilder.Entity<AlunoMateria>().HasKey(sc => new { sc.IdAluno, sc.IdMateria });
        }
    }
}
