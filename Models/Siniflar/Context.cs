using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Skill_CodeFirst.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Yetenekler> Yeteneklers{ get; set; }
    }
}