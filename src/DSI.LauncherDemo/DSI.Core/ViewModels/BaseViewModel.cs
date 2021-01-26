using DSI.Domain.Services;
using Prism.Mvvm;
using Prism.Regions;

namespace DSI.Core.ViewModels
{
    public abstract class BaseViewModel : BindableBase
    {
        public IRegionManager RegionManager { get; }
        public IDataService DataService { get; }

        public BaseViewModel(IRegionManager regionManager, IDataService dataService)
        {
            RegionManager = regionManager;
            DataService = dataService;
        }
    }
}
