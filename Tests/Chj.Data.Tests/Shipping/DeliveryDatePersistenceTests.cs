﻿using Chj.Core.Domain.Shipping;
using Chj.Tests;
using NUnit.Framework;

namespace Chj.Data.Tests.Shipping
{
    [TestFixture]
    public class DeliveryDatePersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_deliveryDate()
        {
            var deliveryDate = new DeliveryDate
                               {
                                   Name = "Name 1",
                                   DisplayOrder = 1
                               };

            var fromDb = SaveAndLoadEntity(deliveryDate);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("Name 1");
            fromDb.DisplayOrder.ShouldEqual(1);
        }
    }
}