using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public abstract class AbstractChatter
{
    [Key]
    public int Id {get; set;}
}