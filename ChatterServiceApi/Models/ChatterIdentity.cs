using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class ChatterIdentity
{
    [Key]
    public int Id {get; set;}
    public ChatterCredentials Credentials {get; set;}
    public List<ContactInformation> ContactInformation {get; set;}
    public List<PersonalName> GivenNames {get; set;}
    public List<PersonalName> Surnames {get; set;}
    public ChatterDate DateOfBirth { get; set; }
}