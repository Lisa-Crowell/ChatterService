namespace ChatterServiceApi.Models;

public class ChatterIdentity
{
    int ChatterId {get; set;}
    string ChatterCredientials {get; set;}
    List<ContactInformation> ContactInformation {get; set;}
    string GivenName {get; set;}
    string Surname {get; set;}
    public DateTime DateOfBirth { get; set; }
}