﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FluentValidation.Attributes;
using Chj.Web.Framework;
using Chj.Web.Framework.Mvc;
using Chj.Web.Validators.Customer;

namespace Chj.Web.Models.Customer
{
    [Validator(typeof(PasswordRecoveryConfirmValidator))]
    public partial class PasswordRecoveryConfirmModel : BaseNopModel
    {
        [AllowHtml]
        [DataType(DataType.Password)]
        [NopResourceDisplayName("Account.PasswordRecovery.NewPassword")]
        public string NewPassword { get; set; }

        [AllowHtml]
        [DataType(DataType.Password)]
        [NopResourceDisplayName("Account.PasswordRecovery.ConfirmNewPassword")]
        public string ConfirmNewPassword { get; set; }

        public bool SuccessfullyChanged { get; set; }
        public string Result { get; set; }
    }
}