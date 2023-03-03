using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class OrganizationName
{
    [Key]
    public int Id {get; set;}
    public string Value {get; set;}
}