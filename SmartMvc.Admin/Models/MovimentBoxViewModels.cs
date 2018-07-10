using System;

namespace SmartMvc.Admin.Models
{
    public class MovimentBoxViewModels
    {
        public int Id { get; set; }
        public string TypeMoviment { get; set; }
        public int BoxId { get; set; }
        public DateTime DateMoviment { get; set; }
        public string KeyNF { get; set; }
    }
}