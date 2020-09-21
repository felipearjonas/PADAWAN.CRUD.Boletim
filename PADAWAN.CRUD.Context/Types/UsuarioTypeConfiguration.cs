using PADAWAN.CRUD.Models;

namespace PADAWAN.CRUD.Context.Types
{
    public class UsuarioTypeConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioTypeConfiguration()
        {
            HasKey(q => q.Id);

            Property(q => q.Login).HasMaxLength(50);
            Property(q => q.Password).HasMaxLength(50);
            Property(q => q.TipoUsuario);
        

        }
    }
}

