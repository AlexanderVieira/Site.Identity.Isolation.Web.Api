using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteIdentityIsolation.Infra.Identity.Security.Models
{
    [Table("AspNetClients")]
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string ClientKey { get; set; }
    }
}
