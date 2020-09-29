using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PADAWAN.CRUD.Models
{
    public class AlunoMateria
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public int IdAluno { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public int IdMateria { get; set; }

        public double NotaAluno { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Aluno Aluno { get; set; }

        
        public virtual Materia Materia { get; set; }

    }
}
