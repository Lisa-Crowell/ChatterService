namespace ChatterServiceApi.Models.Dto;

public class ResponseDto
{
    public bool IsSuccessful { get; set; } = true;
    public object? Result { get; set; }
    public string? DisplayMessage { get; set; } = "";
    public List<string>? ErrorMessage { get; set; }
    
}