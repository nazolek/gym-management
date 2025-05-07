namespace GymManagement.Application.Services;

public class SubscriptionService : ISubscriptionService
{
    public Guid CreateSubscription(Guid adminId, string subscriptionType)
    {
        return Guid.NewGuid();
    }
}