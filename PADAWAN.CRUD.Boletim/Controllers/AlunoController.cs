using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PADAWAN.CRUD.Models;
using PADAWAN.CRUD.Models.Util;
using PADAWAN.CRUD.Context;

namespace PADAWAN.CRUD.Boletim.Controllers
{
    [ApiController]
    [Route("Cadastro")]
    public class AlunoController : ControllerBase
    {
        BoletimContext Meubanquinho = new BoletimContext();
        [HttpGet]
        [Route("MostraAlunos")]
        public ActionResult Get()
        {
            return Ok(Meubanquinho.Alunos.ToList());
        }

        [HttpPost]
        [Route("AddAlunos")]
        public ActionResult Post(Aluno aluno)
        {
            Meubanquinho.Alunos.Add(aluno);
            Meubanquinho.SaveChanges();
            return Ok(Resultado.Sucess);
        }

        [HttpGet]
        [Route("FiltrarAlunos")]
        public ActionResult Filtro(string nome)
        {
            var resultado = Meubanquinho.Alunos.Where(q => q.Nome.Contains(nome)).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NoSucess);
            }
            return Ok(Meubanquinho.Alunos.ToList());
        }

        [HttpPut]
        [Route("AtualizarAluno")]
        public ActionResult Atualizar(int id, string novonome)
        {

            var resultado = Meubanquinho.Alunos.Where(q => q.IdAluno == id).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            resultado.Nome = novonome;
            return Ok(Resultado.Sucess);

        }

        [HttpDelete]
        [Route("DeletarAluno")]
        public ActionResult Deletar(string cpf)
        {

            var resultado = Meubanquinho.Alunos.Where(q => q.Cpf == cpf).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            Meubanquinho.Alunos.Remove(resultado);
            Meubanquinho.SaveChanges();
            return Ok(Resultado.Sucess);

        }


    }
}
