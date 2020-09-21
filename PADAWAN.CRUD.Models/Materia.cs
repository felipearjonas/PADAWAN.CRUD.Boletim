using PADAWAN.CRUD.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PADAWAN.CRUD.Models
{
    public class Materia
    {
        public int IdMateria { get; set; }

        public string NomeMateria { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdCurso { get; set; }
        public string SituacaoMateria { get; set; }

        public virtual ICollection<Nota> Notas { get; set; } = new HashSet<Nota>();
        public virtual ICollection<CursoMateria> CursoMateria { get; set; } = new HashSet<CursoMateria>();


    }
}
