﻿using Chj.Core.Domain.Orders;

namespace Chj.Services.Payments
{
    /// <summary>
    /// Represents a CancelRecurringPaymentResult
    /// </summary>
    public partial class CancelRecurringPaymentRequest
    {
        /// <summary>
        /// Gets or sets an order
        /// </summary>
        public Order Order { get; set; }
    }
}
