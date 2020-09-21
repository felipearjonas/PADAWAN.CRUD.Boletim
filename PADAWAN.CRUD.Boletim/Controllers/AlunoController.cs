using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PADAWAN.CRUD.Models;
using PADAWAN.CRUD.Models.Util;

namespace PADAWAN.CRUD.Boletim.Controllers
{
    [ApiController]
    [Route("Cadastro")]
    public class AlunoController : ControllerBase
    {
        public static List<Aluno> listaalunos = new List<Aluno>();
        [HttpGet]
        [Route("MostraAlunos")]
        public ActionResult Get()
        {
            return Ok(listaalunos);
        }

        [HttpPost]
        [Route("AddAlunos")]
        public ActionResult Post(Aluno aluno)
        {
            listaalunos.Add(aluno);
            return Ok(Resultado.Sucess);
        }

        [HttpGet]
        [Route("FiltrarAlunos")]
        public ActionResult Filtro(string nome)
        {
            var resultado = listaalunos.Where(q => q.Nome.Contains(nome)).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NoSucess);
            }
            return Ok(listaalunos);
        }

        [HttpPut]
        [Route("AtualizarAluno")]
        public ActionResult Atualizar(int id, string novonome)
        {

            var resultado = listaalunos.Where(q => q.IdAluno == id).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            resultado.Nome = novonome;
            return Ok(Resultado.Sucess);

        }

        [HttpDelete]
        [Route("DeletarAluno")]
        public ActionResult Deletar(int id)
        {

            var resultado = listaalunos.Where(q => q.IdAluno == id).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            listaalunos.Remove(resultado);
            return Ok(Resultado.Sucess);

        }


    }
}
