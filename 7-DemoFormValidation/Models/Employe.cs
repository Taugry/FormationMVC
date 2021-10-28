using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _7_DemoFormValidation.Models
{
    public class Employe
    {
        [Required] //exige que l'utilisateur rentre une valeur sinon la validation du formaulaire ne se fera pas
        [Display(Name = "UserName: ")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Mot de passe obligatoire")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Date de naissance obligatoire")]
        [DataType(DataType.Date)]
        [Display(Name ="Date de naissace : ")]
        public DateTime DateNaissance { get; set; }

        [Required(ErrorMessage = "Email obligatoire")]
        [EmailAddress(ErrorMessage ="Format adresse email invalide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Evaluation obligatoire")]
        [Range(1,10)] //indique que le champ evaluation doit etre dans l'intervale 1 à 10
        public int Evaluation { get; set; }

        [Required(ErrorMessage ="Numero de telephone oblgatoire")]
        [Display(Name ="Numéro de téléphone : ")]
        public int NumeroTelephone { get; set; }

        [Required(ErrorMessage = "Commentaire obligatoire")]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; }

        
        [FileExtensions(Extensions ="png, jpg, jpeg")]
        public string Photo { get; set; }
    }
}