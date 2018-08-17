using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPagination.Models
{
    public class Curso
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string URL { get; set; }

        public Canal Canal { get; set; }

        public DateTime DataPublicacao { get; set; }

        public int CargaHoraria { get; set; }
    }
}