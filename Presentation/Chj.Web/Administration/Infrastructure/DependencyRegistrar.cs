using Autofac;
using Autofac.Core;
using Chj.Admin.Controllers;
using Chj.Core.Caching;
using Chj.Core.Infrastructure;
using Chj.Core.Infrastructure.DependencyManagement;

namespace Chj.Admin.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //we cache presentation models between requests
            builder.RegisterType<HomeController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
        }

        public int Order
        {
            get { return 2; }
        }
    }
}
