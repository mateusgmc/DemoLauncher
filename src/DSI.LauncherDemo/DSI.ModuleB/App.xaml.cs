using DryIoc;
using DSI.Domain.Models;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace DSI.ModuleB
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        private static Mutex _mutex;

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var args = e.Args;
            if (!args.Any() || !string.Equals(args.First(), AppToken.AccessKey))
            {
                MessageBox.Show("Acesso negado!", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                Application.Current.Shutdown();
                return;
            }

            _mutex = new Mutex(false, AppToken.ModuleB);
            bool acquired = _mutex.WaitOne(1000);
            if (!acquired)
            {
                MessageBox.Show("Já existe uma instância dessa aplicação aberta.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                Application.Current.Shutdown();
                return;
            }

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            if(_mutex != null)
            {
                _mutex.ReleaseMutex();
                _mutex.Dispose();
            }
            base.OnExit(e);
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
