﻿using System;
using Chj.Core.Domain.Messages;
using Chj.Tests;
using NUnit.Framework;

namespace Chj.Data.Tests.Messages
{
    [TestFixture]
    public class NewsLetterSubscriptionPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_nls()
        {
            var newGuid = Guid.NewGuid();
            var now = new DateTime(2010, 01, 01);

            var nls = new NewsLetterSubscription
            {
                Email = "me@yourstore.com",
                NewsLetterSubscriptionGuid = newGuid,
                CreatedOnUtc = now,
                StoreId = 1,
                Active = true
            };

            var fromDb = SaveAndLoadEntity(nls);
            fromDb.ShouldNotBeNull();
            fromDb.Email.ShouldEqual("me@yourstore.com");
            fromDb.NewsLetterSubscriptionGuid.ShouldEqual(newGuid);
            fromDb.StoreId.ShouldEqual(1);
            fromDb.CreatedOnUtc.ShouldEqual(now);
            fromDb.Active.ShouldBeTrue();
        }
    }
}

