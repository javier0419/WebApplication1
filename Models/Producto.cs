using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="el nombre es obligatorio")]
        [Display(Name ="nombre del prducto")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="la descripsion es obligatoria")]
        public string Descripsion { get; set; }
    }
}
