using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PADAWAN.CRUD.Models;

namespace PADAWAN.CRUD.Context.Types
{
    class NotaTypeConfiguration : IEntityTypeConfiguration<Nota>
    {
        public void Configure(EntityTypeBuilder<Nota> builder)
        {
            builder.HasKey(q => q.IdAluno);
            builder.HasKey(q => q.IdMateria);


            builder.Property(q => q.NotaAluno).IsRequired();


        }

    }
}
