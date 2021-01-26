using DryIoc;
using DSI.Domain.Services;
using DSI.ModuleB.ViewModels;
using DSI.ModuleB.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DSI.ModuleB
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // TODO: Registro de serviços e navegação aqui
            containerRegistry.Register<IDataService, DataService>();
            containerRegistry.RegisterForNavigation<MainWindow, MainViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            // TODO: Registro de módulos aqui
        }
    }
}
