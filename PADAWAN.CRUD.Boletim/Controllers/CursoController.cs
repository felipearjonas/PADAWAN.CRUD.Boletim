using Microsoft.AspNetCore.Mvc;
using PADAWAN.CRUD.Context;
using PADAWAN.CRUD.Models;
using PADAWAN.CRUD.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PADAWAN.CRUD.Boletim.Controllers
{
    [ApiController]
    [Route("CadastroCurso")]
    public class CursoController : ControllerBase
    {
        BoletimContext Meubanquinho = new BoletimContext();
        [HttpGet]
        [Route("MostrarCurso")]
        public ActionResult Get()
        {
            return Ok(Meubanquinho.Cursos.ToList());
        }

        [HttpPost]
        [Route("AddCursos")]
        public ActionResult Post(Curso curso)
        {
            Meubanquinho.Cursos.Add(curso);
            Meubanquinho.SaveChanges();
            return Ok(Resultado.Sucess);
        }

        [HttpGet]
        [Route("FiltrarCurso")]
        public ActionResult Filtro(string nome)
        {
            var resultado = Meubanquinho.Cursos.Where(q => q.NomeCurso.Contains(nome)).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NoSucess);
            }
            return Ok(Meubanquinho.Cursos.ToList());
        }

        [HttpPut]
        [Route("AtualizarCurso")]
        public ActionResult Atualizar(int id, string novonome)
        {

            var resultado = Meubanquinho.Cursos.Where(q => q.IdCurso == id).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            resultado.NomeCurso = novonome;
            return Ok(Resultado.Sucess);

        }

        [HttpDelete]
        [Route("DeletarCurso")]
        public ActionResult Deletar(string nome)
        {

            var resultado = Meubanquinho.Cursos.Where(q => q.NomeCurso == nome).FirstOrDefault();

            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            Meubanquinho.Cursos.Remove(resultado);
            Meubanquinho.SaveChanges();
            return Ok(Resultado.Sucess);

        }


    }
}
