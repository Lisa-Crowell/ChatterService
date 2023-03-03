using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class ChatterCredentials
{
    [Key]
    public int Id {get; set;}
    [Required]
    public string UserName {get; set;}
    [Required]
    public string Password {get; set;}
}