using GymManagement.Application.Services;
using GymManagement.Contracts.Subscriptions;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly ISubscriptionService _subscriptionService;

    public SubscriptionsController(ISubscriptionService subscriptionService)
    {
        _subscriptionService = subscriptionService;
    }

    [HttpPost]
    public IActionResult Create(CreateSubscriptionRequest request)
    {
        var subscriptionId =
            _subscriptionService.CreateSubscription(request.AdminId, request.SubscriptionType.ToString());

        var subscriptionResponse = new SubscriptionResponse(subscriptionId, request.SubscriptionType);

        return Ok(subscriptionResponse);
    }
}