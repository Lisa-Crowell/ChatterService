using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class Username
{
    [Key]
    public int Id {get; set;}
    [Required]
    public string Value {get; set;}
}