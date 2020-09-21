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
    [Route("CadastroMateria")]
    public class MateriaController : ControllerBase
    {
        public static List<Materia> listamaterias = new List<Materia>();
        [HttpGet]
        [Route("MostraMaterias")]
        public ActionResult Get()
        {
            List<string> lista = new List<string>();
            listamaterias.ForEach(s => lista.Add(s.NomeMateria));
            return Ok(lista);
        }

        [HttpPost]
        [Route("Materias")]
        public ActionResult Post(Materia materia)
        {
            listamaterias.Add(materia);
            return Ok(Resultado.Sucess);
        }

        [HttpGet]
        [Route("FiltrarMaterias")]
        public ActionResult Filtro(string nome)
        {
            var resultado = listamaterias.Where(q => q.NomeMateria.Contains(nome)).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NoSucess);
            }
            return Ok(listamaterias);
        }

        [HttpPut]
        [Route("AtualizarMaterias")]
        public ActionResult Atualizar(int id, string novonome)
        {

            var resultado = listamaterias.Where(q => q.IdMateria == id).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            resultado.NomeMateria = novonome;
            return Ok(Resultado.Sucess);

        }

        [HttpDelete]
        [Route("DeletarMaterias")]
        public ActionResult Deletar(int id)
        {

            var resultado = listamaterias.Where(q => q.IdMateria == id).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NoSucess);
            }
            listamaterias.Remove(resultado);
            return Ok(Resultado.Sucess);

        }


    }
}
