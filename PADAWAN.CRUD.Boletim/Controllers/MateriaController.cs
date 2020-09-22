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
    [Route("CadastroMateria")]
    public class MateriaController : ControllerBase
    {
        BoletimContext Meubanquinho = new BoletimContext();
        [HttpGet]
        [Route("MostraMaterias")]
        public ActionResult Get()
        {
            return Ok(Meubanquinho.Materias.ToList());
        }

        [HttpPost]
        [Route("AddMaterias")]
        public ActionResult Post(Materia materia)
        {
            Meubanquinho.Materias.Add(materia);
            Meubanquinho.SaveChanges();
            return Ok(Resultado.Sucess);
        }

        [HttpGet]
        [Route("FiltrarMaterias")]
        public ActionResult Filtro(string nome)
        {
            var resultado = Meubanquinho.Materias.Where(q => q.NomeMateria.Contains(nome)).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NoSucess);
            }
            return Ok(Meubanquinho.Materias.ToList());
        }

        [HttpPut]
        [Route("AtualizarMaterias")]
        public ActionResult Atualizar(int id, string novonome)
        {

            var resultado = Meubanquinho.Materias.Where(q => q.IdMateria == id).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            resultado.NomeMateria = novonome;
            return Ok(Resultado.Sucess);

        }

        [HttpDelete]
        [Route("DeletarMaterias")]
        public ActionResult Deletar(string nome)
        {

            var resultado = Meubanquinho.Materias.Where(q => q.NomeMateria == nome).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            Meubanquinho.Materias.Remove(resultado);
            Meubanquinho.SaveChanges();
            return Ok(Resultado.Sucess);

        }


    }
}
