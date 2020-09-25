using Microsoft.AspNetCore.Mvc;
using PADAWAN.CRUD.Context;
using PADAWAN.CRUD.Models;
using PADAWAN.CRUD.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PADAWAN.CRUD.Boletim.Controllers
{
    [ApiController]

    [Route("CadastroNotas")]
    public class NotasController : ControllerBase
    {

        BoletimContext Meubanquinho = new BoletimContext();
        [HttpGet]
        [Route("MostraNotas")]
        public ActionResult Get()
        {
            var auxiliar =  new List<Auxiliar>();
            var listas = (from Nota in Meubanquinho.Notas
                          join Materia in Meubanquinho.Materias on Nota.IdMateria equals Materia.IdMateria
                          select new { Nota.IdAluno, Nota.NotaAluno, Materia.NomeMateria }).ToList();
            foreach (var item in listas)
            {
                var aux = new Auxiliar()
                {
                    IdAluno = item.IdAluno,
                    NomeMateria = item.NomeMateria,
                    NotaAluno = item.NotaAluno
                };
                auxiliar.Add(aux);
            }
            return Ok(auxiliar);
        }

        [HttpPost]
        [Route("AddNotas")]
        public ActionResult Post(Nota notas)
        {
            Meubanquinho.Notas.Add(notas);
            Meubanquinho.SaveChanges();
            return Ok(Resultado.Sucess);
        }

        [HttpGet]
        [Route("FiltrarNotas")]
        public ActionResult Filtro(string nome)
        {
            var resultado = Meubanquinho.Notas.Where(q => q.Aluno.Nome.Contains(nome)).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NoSucess);
            }
            return Ok(Meubanquinho.Notas.ToList());
        }

        [HttpPut]
        [Route("AtualizarNotas")]
        public ActionResult Atualizar(int idAluno, int idMateria, double nota)
        {
            using (Meubanquinho)
            {
                var resultado = Meubanquinho.Notas.Where(q => q.IdAluno.Equals(idAluno) && q.IdMateria.Equals(idMateria)).FirstOrDefault();
                if (resultado != null)
                {
                    resultado.NotaAluno = nota;
                    Meubanquinho.SaveChanges();
                    return Ok(Resultado.Sucess);
                    
                }
                return BadRequest(Resultado.NoSucess);
            }

        }

        [HttpDelete]
        [Route("DeletarNotas")]
        public ActionResult Deletar(int idAluno)
        {

            var resultado = Meubanquinho.Notas.Where(q => q.IdAluno == idAluno).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            Meubanquinho.Notas.Remove(resultado);
            Meubanquinho.SaveChanges();
            return Ok(Resultado.Sucess);

            
        }
    }
    public class Auxiliar
    {
        public int IdAluno { get; set; }
        public string NomeMateria { get; set; }
        public double NotaAluno { get; set; }
    }
}
