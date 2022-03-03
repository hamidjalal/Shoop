using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Domain
{
    public class MCategore
    {
        public int Id { get; set; }
        [Display(Name = "نام دسته")]
        [Required(ErrorMessage = "نباید بدون مفدار باشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "نباید بدون مفدار باشد")]
        public int ParentId { get; set; }
        public string Status { get; set; }
    }
}