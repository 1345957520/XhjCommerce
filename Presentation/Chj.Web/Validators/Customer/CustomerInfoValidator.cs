﻿using FluentValidation;
using FluentValidation.Results;
using Chj.Core.Domain.Customers;
using Chj.Services.Directory;
using Chj.Services.Localization;
using Chj.Web.Framework.Validators;
using Chj.Web.Models.Customer;

namespace Chj.Web.Validators.Customer
{
    public class CustomerInfoValidator : BaseNopValidator<CustomerInfoModel>
    {
        public CustomerInfoValidator(ILocalizationService localizationService,
            IStateProvinceService stateProvinceService, 
            CustomerSettings customerSettings)
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Account.Fields.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
            RuleFor(x => x.FirstName).NotEmpty().WithMessage(localizationService.GetResource("Account.Fields.FirstName.Required"));
            RuleFor(x => x.LastName).NotEmpty().WithMessage(localizationService.GetResource("Account.Fields.LastName.Required"));

            if (customerSettings.UsernamesEnabled && customerSettings.AllowUsersToChangeUsernames)
            {
                RuleFor(x => x.Username).NotEmpty().WithMessage(localizationService.GetResource("Account.Fields.Username.Required"));
            }

            //form fields
            if (customerSettings.CountryEnabled && customerSettings.CountryRequired)
            {
                RuleFor(x => x.CountryId)
                    .NotEqual(0)
                    .WithMessage(localizationService.GetResource("Account.Fields.Country.Required"));
            }
            if (customerSettings.CountryEnabled && 
                customerSettings.StateProvinceEnabled &&
                customerSettings.StateProvinceRequired)
            {
                Custom(x =>
                {
                    //does selected country have states?
                    var hasStates = stateProvinceService.GetStateProvincesByCountryId(x.CountryId).Count > 0;
                    if (hasStates)
                    {
                        //if yes, then ensure that a state is selected
                        if (x.StateProvinceId == 0)
                        {
                            return new ValidationFailure("StateProvinceId", localizationService.GetResource("Account.Fields.StateProvince.Required"));
                        }
                    }
                    return null;
                });
            }
            if (customerSettings.CompanyRequired && customerSettings.CompanyEnabled)
            {
                RuleFor(x => x.Company).NotEmpty().WithMessage(localizationService.GetResource("Account.Fields.Company.Required"));
            }
            if (customerSettings.StreetAddressRequired && customerSettings.StreetAddressEnabled)
            {
                RuleFor(x => x.StreetAddress).NotEmpty().WithMessage(localizationService.GetResource("Account.Fields.StreetAddress.Required"));
            }
            if (customerSettings.StreetAddress2Required && customerSettings.StreetAddress2Enabled)
            {
                RuleFor(x => x.StreetAddress2).NotEmpty().WithMessage(localizationService.GetResource("Account.Fields.StreetAddress2.Required"));
            }
            if (customerSettings.ZipPostalCodeRequired && customerSettings.ZipPostalCodeEnabled)
            {
                RuleFor(x => x.ZipPostalCode).NotEmpty().WithMessage(localizationService.GetResource("Account.Fields.ZipPostalCode.Required"));
            }
            if (customerSettings.CityRequired && customerSettings.CityEnabled)
            {
                RuleFor(x => x.City).NotEmpty().WithMessage(localizationService.GetResource("Account.Fields.City.Required"));
            }
            if (customerSettings.PhoneRequired && customerSettings.PhoneEnabled)
            {
                RuleFor(x => x.Phone).NotEmpty().WithMessage(localizationService.GetResource("Account.Fields.Phone.Required"));
            }
            if (customerSettings.FaxRequired && customerSettings.FaxEnabled)
            {
                RuleFor(x => x.Fax).NotEmpty().WithMessage(localizationService.GetResource("Account.Fields.Fax.Required"));
            }
        }
    }
}