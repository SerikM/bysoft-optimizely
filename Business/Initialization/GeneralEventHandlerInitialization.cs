using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System;
using System.Linq;

namespace Bysoft.Optimizely.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class GeneralEventHandlerInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var contentEventsService = context.Locate.Advanced.GetInstance<IContentEvents>();
            // register for content events here
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}