namespace GymManagement.Application.Services;

public interface ISubscriptionWriteService
{
    Guid CreateSubscription(Guid adminId, string subscriptionType);
}