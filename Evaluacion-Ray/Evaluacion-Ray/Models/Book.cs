
namespace Evaluacion_Ray.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public enum TypeName
    {
        Rivera,
        Rodriguez,
        Rondon,
        Robles,
        Roldan,
    }

    public class Book
    {
       
        [key]
        public int contactID { get; set; }
        [Required]
       [Range(5,50)]
        public string name { get; set; }
        public TypeName list { get; set; }
        [Required]
        public string email { get; set; }
        public DateTime date { get; set; }
    }
}