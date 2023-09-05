using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LasPollasHermanas.Client.Models
{
    public class Dildo
    {
        // Annotations 
        public int Id { get; set; }
        [Required][StringLength(50)]
        public string? Name { get; set; }
        [Required][Range (1,100)]
        public decimal Price { get; set; }
        [Required]
        public decimal Size { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        public string? Material { get; set; }
        public string? Color { get; set; }
        public int Stock { get; set; }
    }
}