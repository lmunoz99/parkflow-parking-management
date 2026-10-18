namespace ParkFlow.Api.Models;

public class ParkingSpace
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}