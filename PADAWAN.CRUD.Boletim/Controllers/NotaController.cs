using Microsoft.AspNetCore.Mvc;
using PADAWAN.CRUD.Models;
using PADAWAN.CRUD.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PADAWAN.CRUD.Boletim.Controllers
{
    [ApiController]

    [Route("CadastroNotas")]
    public class NotasController : ControllerBase
    {

        public static List<Nota> listaNotas = new List<Nota>();
        [HttpGet]
        [Route("MostraNotas")]
        public ActionResult Get()
        {

            return Ok(listaNotas);
        }

        [HttpPost]
        [Route("Notas")]
        public ActionResult Post(Nota notas)
        {
            listaNotas.Add(notas);
            return Ok(listaNotas);
        }

        [HttpGet]
        [Route("FiltrarNotas")]
        public ActionResult Filtro(string nome)
        {
            var resultado = listaNotas.Where(q => q.Aluno.Nome.Contains(nome)).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NoSucess);
            }
            return Ok(listaNotas);
        }

        [HttpPut]
        [Route("PessoaNotas")]
        public ActionResult Atualizar(int id, int nota)
        {

            var resultado = listaNotas.Where(q => q.NotaAluno == nota).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            resultado.NotaAluno = nota;
            return Ok(Resultado.Sucess);

        }

        [HttpDelete]
        [Route("DeletarNotas")]
        public ActionResult Deletar(int nota)
        {

            var resultado = listaNotas.Where(q => q.NotaAluno == nota).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            listaNotas.Remove(resultado);
            return Ok(Resultado.Sucess);
        }
    }
}
