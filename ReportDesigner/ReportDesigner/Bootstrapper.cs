﻿using System;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
namespace ReportDesigner
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            return new Shell();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return base.CreateModuleCatalog();
        }
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(RibbonBarModule.RibbonBarModule));
            moduleCatalog.AddModule(typeof(ContentModule.ContentEditorModule));
            moduleCatalog.AddModule(typeof(ToolBoxModule.ToolBoxModule));
            moduleCatalog.AddModule(typeof(PropertiesModule.PropertiesModule));
        }
    }
}