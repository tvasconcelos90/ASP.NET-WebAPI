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
    }
}
