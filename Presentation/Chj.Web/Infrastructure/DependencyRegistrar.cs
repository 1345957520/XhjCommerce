using Autofac;
using Autofac.Core;
using Chj.Core.Caching;
using Chj.Core.Infrastructure;
using Chj.Core.Infrastructure.DependencyManagement;
using Chj.Web.Controllers;
using Chj.Web.Infrastructure.Installation;

namespace Chj.Web.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //we cache presentation models between requests
            builder.RegisterType<BlogController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
            builder.RegisterType<CatalogController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
            builder.RegisterType<CountryController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
            builder.RegisterType<CommonController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
            builder.RegisterType<NewsController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
            builder.RegisterType<PollController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
            builder.RegisterType<ProductController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
            builder.RegisterType<ShoppingCartController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
            builder.RegisterType<TopicController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
            builder.RegisterType<WidgetController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
            
            //installation localization service
            builder.RegisterType<InstallationLocalizationService>().As<IInstallationLocalizationService>().InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 2; }
        }
    }
}
