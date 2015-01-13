using Autofac;
using Autofac.Core;
using Chj.Core.Data;
using Chj.Core.Infrastructure;
using Chj.Core.Infrastructure.DependencyManagement;
using Chj.Data;
using Chj.Plugin.Shipping.ByWeight.Data;
using Chj.Plugin.Shipping.ByWeight.Domain;
using Chj.Plugin.Shipping.ByWeight.Services;
using Chj.Web.Framework.Mvc;

namespace Chj.Plugin.Shipping.ByWeight
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<ShippingByWeightService>().As<IShippingByWeightService>().InstancePerLifetimeScope();

            //data context
            this.RegisterPluginDataContext<ShippingByWeightObjectContext>(builder, "nop_object_context_shipping_weight_zip");

            //override required repository with our custom context
            builder.RegisterType<EfRepository<ShippingByWeightRecord>>()
                .As<IRepository<ShippingByWeightRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("nop_object_context_shipping_weight_zip"))
                .InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
