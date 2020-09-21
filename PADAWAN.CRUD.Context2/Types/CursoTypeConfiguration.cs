using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PADAWAN.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PADAWAN.CRUD.Context.Types
{
    public class CursoTypeConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(q => q.IdCurso);

            builder.Property(q => q.NomeCurso).HasMaxLength(100).IsRequired();
            builder.Property(q => q.SituacaoCurso).HasMaxLength(100).IsRequired();


        }
    }
}
