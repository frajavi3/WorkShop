﻿using System.ComponentModel.DataAnnotations;

namespace WorkShop.API.Data.Entities
{
    public class Procedure
    {
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe ser mayor a {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal Price { get; set; }
    }
}