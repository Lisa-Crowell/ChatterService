using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class ChatterCredentials
{
    [Required]
    string UserName {get; set;}
    [Required]
    string Password {get; set;}
}