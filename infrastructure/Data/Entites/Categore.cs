using System;
namespace infrastructure.Data.Entites
{
    public class Categore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public string Status { get; set; } 
    }
}