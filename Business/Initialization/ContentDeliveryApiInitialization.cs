using EPiServer.ContentApi.Cms;
using EPiServer.ContentApi.Core.Configuration;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using System;
using System.Linq;

namespace Bysoft.Optimizely.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(ContentApiCmsInitialization))]
    public class ContentDeliveryApiInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Services.Configure<ContentApiConfiguration>(config =>
            //config.Default().SetMinimumRoles("contentapiread")
            config.Default().SetMinimumRoles(String.Empty)
            .SetSiteDefinitionApiEnabled(false)
            );
        }

        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}