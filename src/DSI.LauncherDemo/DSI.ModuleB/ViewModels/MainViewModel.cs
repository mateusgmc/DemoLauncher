using DSI.Core.ViewModels;
using DSI.Domain.Services;
using Prism.Regions;

namespace DSI.ModuleB.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(IRegionManager regionManager, IDataService dataService)
            : base(regionManager, dataService)
        {
            var helloWorld = DataService.GetHelloWorld();
            Text = helloWorld.Text;
        }

        public string Text { get; set; }
    }
}
