namespace SmartHome.Api.Models;

public sealed class SmartHome
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public Guid AccountId { get; set; }
    public SubscriptionPlan Plan { get; set; } = SubscriptionPlan.Freemium;
    public List<Device> Devices { get; set; } = new();
}
