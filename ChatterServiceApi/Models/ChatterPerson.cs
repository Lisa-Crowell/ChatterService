using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class ChatterPerson : AbstractChatter
{
    [Key] 
    public int Id { get; set; }
    public ChatterIdentity Identity {get; set;}
}