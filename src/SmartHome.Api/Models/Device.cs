namespace SmartHome.Api.Models;

public sealed class Device
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid SmartHomeId { get; set; }
    public SmartHome? SmartHome { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Status { get; set; } = "offline";
}
