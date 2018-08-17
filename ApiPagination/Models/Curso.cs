﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiPagination.Models
{
    [Table("Cursos")]
    public class Curso
    {
        public int Id { get; set; }

        [Required(ErrorMessage="O título do curso deve ser preenchido.")]
        [MaxLength(100, ErrorMessage ="O título do curso só pode conter até 100 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage ="A URL do curso deve ser preenchida.")]
        [Url(ErrorMessage ="A URL do curso deve conter um endereço válido.")]
        public string URL { get; set; }

        [Required(ErrorMessage ="O canal do curso deve ser preenchido.")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Canal Canal { get; set; }

        [Required(ErrorMessage ="A data de publicacao do curso deve ser preenchida.")]
        public DateTime DataPublicacao { get; set; }

        [Required(ErrorMessage ="A carga horaria do curso deve ser preenchida.")]
        [Range(1, Int32.MaxValue, ErrorMessage="A carga horaria deve ser de pelo menos 1h .")]
        public int CargaHoraria { get; set; }
    }
}