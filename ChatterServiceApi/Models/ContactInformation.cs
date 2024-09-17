using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class ContactInformation
{
    [Key]
    public int Id {get; set;}
    [Required]
    public PhoneNumber PhoneNumber {get; set;}
    [EmailAddress, Required]
    public EmailAddress EmailAddress {get; set;}
}