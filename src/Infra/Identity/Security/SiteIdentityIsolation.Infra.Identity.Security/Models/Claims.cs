using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteIdentityIsolation.Infra.Identity.Security.Models
{
    [Table("AspNetClaims")]
    public class Claims
    {
        public Claims()
        {
            ClaimsId = Guid.NewGuid();
        }

        [Key]
        public Guid ClaimsId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Fornceça um nome para a Claim")]
        [MaxLength(128, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Nome da Claim")]
        public string ClaimsName { get; set; }
    }
}