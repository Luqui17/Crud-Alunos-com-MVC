using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSiegProject.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
    }
}