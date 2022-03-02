using System;
using System.ComponentModel.DataAnnotations;

namespace infrastructure.Data.Entites
{
    public class Tbl_Color
    {
        [Key]
        public int IdColor { get; set; }
        public string NameColor { get; set; }
    }
}