using System;
using System.ComponentModel.DataAnnotations;

namespace OGameLikeBO
{
    public class Ressource : IDbEntity
    {
        private string nom;

        [StringLength(20, MinimumLength = 5)]
        public string Nom
        {
            get { return nom; }

            set { 
                if(value.Equals(TypeRessource.ACIER) || value.Equals(TypeRessource.ENERGIE) || value.Equals(TypeRessource.OXYGENE) || value.Equals(TypeRessource.URANIUM))
                {
                    nom = value;
                }
            }
        }


        [Range(0, Int32.MaxValue)]
        public int? DerniereQuantite { get; set; }

        [ValiditeDate]
        public DateTime DerniereMAJ { get; set; }
    }

    class ValiditeDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime _dateJoin = Convert.ToDateTime(value);

            if (_dateJoin >= DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(ErrorMessage);
            }
        }
    }
}