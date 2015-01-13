﻿using System;
using System.Web.Mvc;
using Chj.Core;
using Chj.Core.Domain.Customers;
using Chj.Core.Domain.Messages;
using Chj.Services.Localization;
using Chj.Services.Messages;
using Chj.Web.Models.Newsletter;

namespace Chj.Web.Controllers
{
    public partial class NewsletterController : BasePublicController
    {
        private readonly ILocalizationService _localizationService;
        private readonly IWorkContext _workContext;
        private readonly INewsLetterSubscriptionService _newsLetterSubscriptionService;
        private readonly IWorkflowMessageService _workflowMessageService;
        private readonly IStoreContext _storeContext;

        private readonly CustomerSettings _customerSettings;

        public NewsletterController(ILocalizationService localizationService,
            IWorkContext workContext,
            INewsLetterSubscriptionService newsLetterSubscriptionService,
            IWorkflowMessageService workflowMessageService,
            IStoreContext storeContext,
            CustomerSettings customerSettings)
        {
            this._localizationService = localizationService;
            this._workContext = workContext;
            this._newsLetterSubscriptionService = newsLetterSubscriptionService;
            this._workflowMessageService = workflowMessageService;
            this._storeContext = storeContext;
            this._customerSettings = customerSettings;
        }

        [ChildActionOnly]
        public ActionResult NewsletterBox()
        {
            if (_customerSettings.HideNewsletterBlock)
                return Content("");

            return PartialView(new NewsletterBoxModel());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SubscribeNewsletter(string email)
        {
            string result;
            bool success = false;

            if (!CommonHelper.IsValidEmail(email))
                result = _localizationService.GetResource("Newsletter.Email.Wrong");
            else
            {
                //subscribe/unsubscribe
                email = email.Trim();

                var subscription = _newsLetterSubscriptionService.GetNewsLetterSubscriptionByEmailAndStoreId(email, _storeContext.CurrentStore.Id);
                if (subscription != null)
                {
                    if (!subscription.Active)
                    {
                        _workflowMessageService.SendNewsLetterSubscriptionActivationMessage(subscription, _workContext.WorkingLanguage.Id);
                    }
                    result = _localizationService.GetResource("Newsletter.SubscribeEmailSent");
                }
                else
                {
                    subscription = new NewsLetterSubscription
                    {
                        NewsLetterSubscriptionGuid = Guid.NewGuid(),
                        Email = email,
                        Active = false,
                        StoreId = _storeContext.CurrentStore.Id,
                        CreatedOnUtc = DateTime.UtcNow
                    };
                    _newsLetterSubscriptionService.InsertNewsLetterSubscription(subscription);
                    _workflowMessageService.SendNewsLetterSubscriptionActivationMessage(subscription, _workContext.WorkingLanguage.Id);

                    result = _localizationService.GetResource("Newsletter.SubscribeEmailSent");
                }
                success = true;
            }

            return Json(new
            {
                Success = success,
                Result = result,
            });
        }

        public ActionResult SubscriptionActivation(Guid token, bool active)
        {
            var subscription = _newsLetterSubscriptionService.GetNewsLetterSubscriptionByGuid(token);
            if (subscription == null)
                return RedirectToRoute("HomePage");

            var model = new SubscriptionActivationModel();

            if (active)
            {
                subscription.Active = true;
                _newsLetterSubscriptionService.UpdateNewsLetterSubscription(subscription);
            }
            else
                _newsLetterSubscriptionService.DeleteNewsLetterSubscription(subscription);

            model.Result = active 
                ?  _localizationService.GetResource("Newsletter.ResultActivated")
                : _localizationService.GetResource("Newsletter.ResultDeactivated");

            return View(model);
        }
    }
}
