﻿using System;
using Chj.Core.Domain.Catalog;
using Chj.Core.Domain.Shipping;
using Chj.Tests;
using NUnit.Framework;

namespace Chj.Data.Tests.Catalog
{
    [TestFixture]
    public class ProductWarehouseInventoryPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_productWarehouseInventory()
        {
            var pwi = new ProductWarehouseInventory
            {
                Product = new Product
                {
                    Name = "Name 1",
                    Published = true,
                    Deleted = false,
                    CreatedOnUtc = new DateTime(2010, 01, 01),
                    UpdatedOnUtc = new DateTime(2010, 01, 02)
                },
                Warehouse = new Warehouse
                {
                    Name = "Name 2",
                    AddressId = 1,
                },
                StockQuantity = 3,
                ReservedQuantity = 4,
            };

            var fromDb = SaveAndLoadEntity(pwi);
            fromDb.ShouldNotBeNull();
            fromDb.Product.ShouldNotBeNull();
            fromDb.Product.Name.ShouldEqual("Name 1");
            fromDb.Warehouse.ShouldNotBeNull();
            fromDb.Warehouse.Name.ShouldEqual("Name 2");
            fromDb.StockQuantity.ShouldEqual(3);
            fromDb.ReservedQuantity.ShouldEqual(4);
        }
    }
}
