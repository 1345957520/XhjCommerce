using Autofac;
using Autofac.Core;
using Chj.Core.Data;
using Chj.Core.Infrastructure;
using Chj.Core.Infrastructure.DependencyManagement;
using Chj.Data;
using Chj.Plugin.Tax.CountryStateZip.Data;
using Chj.Plugin.Tax.CountryStateZip.Domain;
using Chj.Plugin.Tax.CountryStateZip.Services;
using Chj.Web.Framework.Mvc;

namespace Chj.Plugin.Tax.CountryStateZip
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<TaxRateService>().As<ITaxRateService>().InstancePerLifetimeScope();

            //data context
            this.RegisterPluginDataContext<TaxRateObjectContext>(builder, "nop_object_context_tax_country_state_zip");

            //override required repository with our custom context
            builder.RegisterType<EfRepository<TaxRate>>()
                .As<IRepository<TaxRate>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("nop_object_context_tax_country_state_zip"))
                .InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
