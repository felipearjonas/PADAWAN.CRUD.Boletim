using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PADAWAN.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PADAWAN.CRUD.Context.Types
{
    public class CursoMateriaTypeConfiguration : IEntityTypeConfiguration<CursoMateria>
    {
        public void Configure(EntityTypeBuilder<CursoMateria> builder)
        {
            builder.HasKey(q => q.IdCurso);
            builder.HasKey(q => q.IdMateria);

        }
    }
}
