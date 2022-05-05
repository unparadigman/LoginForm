using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginForm.Models
{
    public class ModelClient
    {
        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; }

        [Display(Name="Número de Documento")]
        [Required(ErrorMessage = "El número de documento es obligatorio")]
        [MaxLength(9,ErrorMessage = "No puede tener más de 9 dígitos")]
        public string DocumentoNumero { get; set; }

        [Display(Name ="Password")]
        [Required(ErrorMessage = "La password es obligatoria")]
        public string Password { get; set; }
    }
}