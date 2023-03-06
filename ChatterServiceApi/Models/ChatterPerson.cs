using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class ChatterPerson : AbstractChatter
{
    public ChatterIdentity Identity {get; set;}
}