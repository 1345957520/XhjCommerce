﻿using Chj.Core.Domain.Directory;
using Chj.Tests;
using NUnit.Framework;

namespace Chj.Data.Tests.Directory
{
    [TestFixture]
    public class MeasureDimensionPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_measureDimension()
        {
            var measureDimension = new MeasureDimension
            {
                Name = "inch(es)",
                SystemKeyword = "inches",
                Ratio = 1.12345678M,
                DisplayOrder = 2,
            };

            var fromDb = SaveAndLoadEntity(measureDimension);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("inch(es)");
            fromDb.SystemKeyword.ShouldEqual("inches");
            fromDb.Ratio.ShouldEqual(1.12345678M);
            fromDb.DisplayOrder.ShouldEqual(2);
        }
    }
}
