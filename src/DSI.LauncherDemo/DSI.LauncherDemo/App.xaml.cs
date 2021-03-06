﻿using DryIoc;
using DSI.LauncherDemo.Services;
using DSI.LauncherDemo.ViewModels;
using DSI.LauncherDemo.Views;
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

namespace DSI.LauncherDemo
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
            containerRegistry.Register<IModuleServices, ModuleServices>();
            containerRegistry.RegisterForNavigation<MainWindow, MainViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            // TODO: Registro de módulos aqui
        }
    }
}
