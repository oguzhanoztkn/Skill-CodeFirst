using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skill_CodeFirst.Models.Siniflar
{
    public class Yetenekler
    {
        [Key]
        public int Id { get; set; }
        public string YetenekAciklama { get; set; }
        public byte Deger { get; set; }

    }
}