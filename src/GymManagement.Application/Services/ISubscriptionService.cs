namespace GymManagement.Application.Services;

public interface ISubscriptionService
{
    Guid CreateSubscription(Guid adminId, string subscriptionType);
}