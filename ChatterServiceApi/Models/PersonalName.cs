using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatterServiceApi.Models;

public class PersonalName
{
    [Key]
    public int Id {get; set;}
    public string Value {get; set;}
    public IEnumerable<ChatterIdentity> AssociatedIdentities { get; set; }
}