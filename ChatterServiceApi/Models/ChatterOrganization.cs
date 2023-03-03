using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChatterServiceApi.Models;

public class ChatterOrganization: AbstractChatter
{
    [Key]
    public int Id {get; set;}
    public List<OrganizationName> Names {get; set;}
    public List<ChatterIdentity> Identities {get; set;}

    public string Name()
    {
        StringBuilder sb = new StringBuilder();
        
        Names.ForEach(name => sb.Append(name.Value + " "));
        sb.Remove(sb.Length - 1, 1);
        
        return sb.ToString();
    }
}