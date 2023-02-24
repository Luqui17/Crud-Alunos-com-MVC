using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolSiegProject.Models
{
    public class AlunoContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
    }
}
