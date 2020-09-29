using System;
using System.Collections.Generic;
using System.Text;

namespace PADAWAN.CRUD.Models
{
    public class CursoMateria
    {
        public int IdCurso { get; set; }
        public int IdMateria { get; set; }

        public virtual Curso Cursos { get; set; }
        public virtual Materia Materia { get; set; }

    }
}
