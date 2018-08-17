using ApiPagination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPagination.Controllers
{
    public class CursosController : ApiController
    {
        private ApiPaginationContext db = new ApiPaginationContext();

        public IHttpActionResult PostCurso(Curso curso)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Cursos.Add(curso);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = curso.Id }, curso);
        }

        public IHttpActionResult GetCurso(int id)
        {
            if (id <= 0)
                return BadRequest("O id deve ser um número maior que zero.");

            var curso = db.Cursos.Find(id);

            if (curso == null)
                return NotFound();

            return Ok(curso);
        }

    }
}
