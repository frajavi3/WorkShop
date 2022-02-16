using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkShop.API.Data.Entities
{
    public class VehiclePhoto
    {
        public int Id { get; set; }

        [JsonIgnore]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Vehicle Vehicle { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        //TODO : Corregir el enlace
        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44330/images/noimage.png"
            : $"https://vehicleszulu.blob.core.windows.net/users/{ImageId}";
    }
}
