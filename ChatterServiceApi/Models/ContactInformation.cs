using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class ContactInformation
{
    [Required]
    int PhoneNumber {get; set;}
    [EmailAddress, Required]
    string EmailAddress {get; set;}
}