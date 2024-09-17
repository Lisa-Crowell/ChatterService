using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class PhoneNumber
{
    [Key]
    public int Id {get; set;}
    public int CountryCode {get; set;}
    public int AreaCode {get; set;}
    public int RegionCode {get; set;}
    public int LineNumber {get; set;}
    public int Extension {get; set;}
}