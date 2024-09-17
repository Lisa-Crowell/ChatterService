using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class EmailAddress
{
    [Key]
    public int Id {get; set;}
    public AccountName AccountName {get; set;}
    public DomainName DomainName { get; set; }
    public EmailExtension DomainExtension { get; set; }
}