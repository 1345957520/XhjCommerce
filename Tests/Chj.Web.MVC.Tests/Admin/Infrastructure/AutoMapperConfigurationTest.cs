using AutoMapper;
using Chj.Admin.Infrastructure;
using NUnit.Framework;

namespace Chj.Web.MVC.Tests.Admin.Infrastructure
{
    [TestFixture]
    public class AutoMapperConfigurationTest
    {
        [Test]
        public void Configuration_is_valid()
        {
            var autoMapperStartupTask = new AutoMapperStartupTask();
            autoMapperStartupTask.Execute();
            Mapper.AssertConfigurationIsValid();
        }
    }
}
