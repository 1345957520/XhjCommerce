﻿using System;
using Chj.Core.Domain.Affiliates;
using Chj.Core.Domain.Common;
using Chj.Core.Domain.Directory;
using Chj.Tests;
using NUnit.Framework;

namespace Chj.Data.Tests.Affiliates
{
    [TestFixture]
    public class AffiliatePersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_affiliate()
        {
            var affiliate = new Affiliate
            {
                Deleted = true,
                Active = true,
                Address = GetTestAddress(),
            };

            var fromDb = SaveAndLoadEntity(affiliate);
            fromDb.ShouldNotBeNull();
            fromDb.Deleted.ShouldEqual(true);
            fromDb.Active.ShouldEqual(true);
            fromDb.Address.ShouldNotBeNull();
            fromDb.Address.FirstName.ShouldEqual("FirstName 1");
        }

        protected Address GetTestAddress()
        {
            return new Address
            {
                FirstName = "FirstName 1",
                LastName = "LastName 1",
                Email = "Email 1",
                Company = "Company 1",
                City = "City 1",
                Address1 = "Address1a",
                Address2 = "Address1a",
                ZipPostalCode = "ZipPostalCode 1",
                PhoneNumber = "PhoneNumber 1",
                FaxNumber = "FaxNumber 1",
                CreatedOnUtc = new DateTime(2010, 01, 01),
                Country = new Country
                {
                    Name = "United States",
                    TwoLetterIsoCode = "US",
                    ThreeLetterIsoCode = "USA",
                }
            };
        }
    }
}