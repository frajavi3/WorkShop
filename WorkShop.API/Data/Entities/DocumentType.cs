using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorkShop.API.Data.Entities
{
    public class DocumentType
    {
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe ser mayor a {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
