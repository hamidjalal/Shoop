using System;
namespace Core.Domain
{
    public class MCategore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public string Status { get; set; } 
    }
}