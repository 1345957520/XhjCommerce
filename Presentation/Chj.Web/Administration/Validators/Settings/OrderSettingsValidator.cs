using FluentValidation;
using Chj.Admin.Models.Settings;
using Chj.Core.Domain.Orders;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;

namespace Chj.Admin.Validators.Settings
{
    public class OrderSettingsValidator : BaseNopValidator<OrderSettingsModel>
    {
        public OrderSettingsValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.GiftCards_Activated_OrderStatusId).NotEqual((int)OrderStatus.Pending)
                .WithMessage(localizationService.GetResource("Admin.Configuration.Settings.RewardPoints.PointsForPurchases_Awarded.Pending"));
            RuleFor(x => x.GiftCards_Deactivated_OrderStatusId).NotEqual((int)OrderStatus.Pending)
                .WithMessage(localizationService.GetResource("Admin.Configuration.Settings.RewardPoints.PointsForPurchases_Canceled.Pending"));
        }
    }
}