﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF_CodeFirst_CRUD.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string SobreNome { get; set; }

    }
}