using Autofac;
using Autofac.Core;
using Chj.Core.Data;
using Chj.Core.Infrastructure;
using Chj.Core.Infrastructure.DependencyManagement;
using Chj.Data;
using Chj.Plugin.Feed.Froogle.Data;
using Chj.Plugin.Feed.Froogle.Domain;
using Chj.Plugin.Feed.Froogle.Services;
using Chj.Web.Framework.Mvc;

namespace Chj.Plugin.Feed.Froogle
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<GoogleService>().As<IGoogleService>().InstancePerLifetimeScope();

            //data context
            this.RegisterPluginDataContext<GoogleProductObjectContext>(builder, "nop_object_context_google_product");

            //override required repository with our custom context
            builder.RegisterType<EfRepository<GoogleProductRecord>>()
                .As<IRepository<GoogleProductRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("nop_object_context_google_product"))
                .InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
