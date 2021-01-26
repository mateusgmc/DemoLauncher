using DSI.LauncherDemo.Models;
using DSI.LauncherDemo.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows;

namespace DSI.LauncherDemo.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public IModuleServices ModuleServices { get; }

        public MainViewModel(IModuleServices moduleServices)
        {
            ModuleServices = moduleServices;

            OpenModuleACommand = new DelegateCommand(OpenModuleAExecute);
            OpenModuleBCommand = new DelegateCommand(OpenModuleBExecute);
        }

        public DelegateCommand OpenModuleACommand { get; }
        public DelegateCommand OpenModuleBCommand { get; }

        private void OpenModule(string path)
        {
            try
            {
                var module = new Module(path);
                ModuleServices.OpenModule(module);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OpenModuleAExecute() { OpenModule(ModulePath.ModuleA); }
        private void OpenModuleBExecute() { OpenModule(ModulePath.ModuleB); }
    }
}
