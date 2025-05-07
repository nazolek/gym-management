namespace GymManagement.Application.Services;

public class SubscriptionWriteService : ISubscriptionWriteService
{
    public Guid CreateSubscription(Guid adminId, string subscriptionType)
    {
        return Guid.NewGuid();
    }
}