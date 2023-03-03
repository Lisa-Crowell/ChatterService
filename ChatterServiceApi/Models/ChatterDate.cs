using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class ChatterDate
{
    [Key]
    public int Id {get; set;}
    public DateOnly Value {get; set;}
}