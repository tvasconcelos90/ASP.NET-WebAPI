using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiPagination.Models
{
    public class ApiPaginationContext : DbContext 
    {
        public ApiPaginationContext() : base("ApiPaginationLocal")
        {

        }

        public DbSet<Curso> Cursos { get; set; }
    }
}