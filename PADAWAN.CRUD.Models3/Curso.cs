using PADAWAN.CRUD.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PADAWAN.CRUD.Models
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string NomeCurso { get; set; }
        public string SituacaoCurso { get; set; }

       
        public virtual ICollection<Aluno> Alunos { get; set; } = new HashSet<Aluno>();
        public virtual ICollection<CursoMateria> CursoMateria { get; set; } = new HashSet<CursoMateria>();

    }
}
