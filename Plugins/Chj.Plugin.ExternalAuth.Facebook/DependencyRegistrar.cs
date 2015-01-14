using Autofac;
using Chj.Core.Infrastructure;
using Chj.Core.Infrastructure.DependencyManagement;
using Chj.Plugin.ExternalAuth.Facebook.Core;

namespace Chj.Plugin.ExternalAuth.Facebook
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<FacebookProviderAuthorizer>().As<IOAuthProviderFacebookAuthorizer>().InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
