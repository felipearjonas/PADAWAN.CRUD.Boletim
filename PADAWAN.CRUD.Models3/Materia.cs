using PADAWAN.CRUD.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
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

      [JsonIgnore]
      [IgnoreDataMember]
        public virtual ICollection<AlunoMateria> Notas { get; set; } = new HashSet<AlunoMateria>();

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CursoMateria> CursoMateria { get; set; } = new HashSet<CursoMateria>();


    }
}
