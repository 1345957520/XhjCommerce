using Autofac;
using Autofac.Core;
using Chj.Core.Caching;
using Chj.Core.Infrastructure;
using Chj.Core.Infrastructure.DependencyManagement;
using Chj.Plugin.Misc.FacebookShop.Controllers;

namespace Chj.Plugin.Misc.FacebookShop.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //we cache presentation models between requests
            builder.RegisterType<MiscFacebookShopController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
        }

        public int Order
        {
            get { return 2; }
        }
    }
}
