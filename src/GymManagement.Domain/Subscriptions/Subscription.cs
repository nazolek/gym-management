namespace GymManagement.Domain.Subscriptions;

public class Subscription
{
    private readonly Guid _adminId;

    public Guid Id { get; private set; }

    public SubscriptionType Type { get; private set; }

    public Subscription(SubscriptionType subscriptionType, Guid adminId, Guid? subscriptionId = null)
    {
        Id = subscriptionId ?? Guid.NewGuid();
        Type = subscriptionType;
        _adminId = adminId;
    }

    private Subscription()
    {
    }
}