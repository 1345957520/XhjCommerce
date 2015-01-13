using Chj.Core.Domain.Catalog;
using Chj.Tests;
using NUnit.Framework;

namespace Chj.Data.Tests.Catalog
{
    [TestFixture]
    public class ProductAttributePersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_productAttribute()
        {
            var pa = new ProductAttribute
            {
                Name = "Name 1",
                Description = "Description 1",
            };

            var fromDb = SaveAndLoadEntity(pa);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("Name 1");
            fromDb.Description.ShouldEqual("Description 1");
        }
    }
}