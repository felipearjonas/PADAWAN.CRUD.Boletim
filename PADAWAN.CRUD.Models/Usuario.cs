using PADAWAN.CRUD.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PADAWAN.CRUD.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
