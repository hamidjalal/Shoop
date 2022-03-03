using System;
using System.ComponentModel.DataAnnotations;
namespace core.Domain
{
    public class MProduct
    {
        public int Id { get; set; }
        [Display(Name = "نام محصول")]
        [Required(ErrorMessage = "نباید بدون مفدار باشد")]
        public string Name { get; set; }
        public double price { get; set; }
        public int Count { get; set; }
        public string discription { get; set; }
        public string MainImage { get; set; }
        public int IdMoreImage { get; set; }
        [Required(ErrorMessage = "نباید بدون مفدار باشد")]
        public int IdCategory { get; set; }
        public bool Status { get; set; }
        public int IdColor { get; set; }
        public int IdSize { get; set; }
        public int discount { get; set; }
        public string Type { get; set; }
    }
}