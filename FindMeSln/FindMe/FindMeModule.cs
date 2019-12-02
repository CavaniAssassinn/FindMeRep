using Prism.Ioc;
using Prism.Modularity;
using FindMe.Views;
using FindMe.ViewModels;

namespace FindMe
{
    public class FindMeModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
