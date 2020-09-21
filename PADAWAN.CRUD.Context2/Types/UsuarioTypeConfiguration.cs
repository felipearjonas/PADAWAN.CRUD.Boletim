using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PADAWAN.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PADAWAN.CRUD.Context.Types
{
    public class UsuarioTypeConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.Login).HasMaxLength(50);
            builder.Property(q => q.Password);
            builder.Property(q => q.TipoUsuario);


        }
    }
}


