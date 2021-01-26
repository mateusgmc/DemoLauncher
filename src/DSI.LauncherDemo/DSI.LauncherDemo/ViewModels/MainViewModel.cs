using DSI.LauncherDemo.Models;
using DSI.LauncherDemo.Services;
using Prism.Commands;
using Prism.Mvvm;

namespace DSI.LauncherDemo.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public IModuleServices ModuleServices { get; }

        public MainViewModel(IModuleServices moduleServices)
        {
            ModuleServices = moduleServices;

            OpenModuleA = new DelegateCommand(OpenModuleAExecute);
            OpenModuleB = new DelegateCommand(OpenModuleBExecute);
        }

        public DelegateCommand OpenModuleA { get; }
        public DelegateCommand OpenModuleB { get; }

        private void OpenModule(string path)
        {
            var module = new Module(path);
            ModuleServices.OpenModule(module);
        }

        private void OpenModuleAExecute() { OpenModule(ModulePath.ModuleA); }
        private void OpenModuleBExecute() { OpenModule(ModulePath.ModuleB); }
    }
}
