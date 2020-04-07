using System.Collections.Generic;
using System.Linq;
using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cubes.Core.Base
{
    /// <summary>
    /// Application class, with basic implementation
    /// </summary>
    public abstract class Application : IApplication
    {
        public virtual IConfigurationBuilder ConfigureAppConfiguration(IConfigurationBuilder configuration)
            => configuration;

        public virtual IServiceCollection ConfigureServices(IServiceCollection services)
            => services;

        public virtual ContainerBuilder RegisterServices(ContainerBuilder builder)
            => builder;

        public virtual IEnumerable<string> GetSwaggerXmlFiles()
            => Enumerable.Empty<string>();
    }
}
