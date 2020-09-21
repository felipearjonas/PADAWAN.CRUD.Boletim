using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PADAWAN.CRUD.Models
{
    public class Nota
    {
        public int IdAluno { get; set; }

        public int IdMateria { get; set; }

        public double NotaAluno { get; set; }

        public virtual Aluno Aluno { get; set; }

        public virtual Materia Materia { get; set; }

    }
}
