using System.ComponentModel.DataAnnotations;

namespace AuthorizationServer.Api.ViewModels
{
    public class AudienceViewModel
    {
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
    }
}