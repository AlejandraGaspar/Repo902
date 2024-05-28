using System.ComponentModel.DataAnnotations;

namespace cmsShoppingBooks.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, MinLength(2, ErrorMessage = "Mínimo 2 caracteres!!!")]
        [RegularExpression(@"^[a-zA-Z-ñ ]+$", ErrorMessage = "Solo se permiten letras!!!")]
        public string Name { get; set; }
        public string Slug { get; set; } //descripcion del nombre de la categoria
        public int Sorting { get; set; }
        public date Fecha { get; set; }
        public int Cuenta { get; set; }

    }
}
