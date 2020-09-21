using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PADAWAN.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PADAWAN.CRUD.Context.Types
{
    class AlunoTypeConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(q => q.IdAluno);

            builder.Property(q => q.Nome).HasMaxLength(100).IsRequired();
            builder.Property(q => q.Sobrenome).HasMaxLength(100).IsRequired();
            builder.Property(q => q.DataNascimento).IsRequired();
            builder.Property(q => q.Cpf).HasMaxLength(16).IsRequired();

           
        }


    }
}
