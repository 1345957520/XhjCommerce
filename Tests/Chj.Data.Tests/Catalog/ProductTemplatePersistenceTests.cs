﻿using Chj.Core.Domain.Catalog;
using Chj.Tests;
using NUnit.Framework;

namespace Chj.Data.Tests.Catalog
{
    [TestFixture]
    public class ProductTemplatePersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_productTemplate()
        {
            var productTemplate = new ProductTemplate
            {
                Name = "Name 1",
                ViewPath = "ViewPath 1",
                DisplayOrder = 1,
            };

            var fromDb = SaveAndLoadEntity(productTemplate);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("Name 1");
            fromDb.ViewPath.ShouldEqual("ViewPath 1");
            fromDb.DisplayOrder.ShouldEqual(1);
        }
    }
}
