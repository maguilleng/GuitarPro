using Microsoft.Practices.Prism.MefExtensions;
using System.ComponentModel.Composition.Hosting;
using Microsoft.Practices.Prism.Modularity;
using System;
using System.Net;
using System.Windows;
using Constructora.Infrastructure;


namespace Constructora
{
    public class Bootstrapper : MefBootstrapper
    {
        private const string ModuleCatalogUri = "/Constructora;component/ModulesCatalog.xaml";

        protected override DependencyObject CreateShell()
        {
            return Container.GetExportedValue<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.RootVisual = (UIElement)this.Shell;
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }

        protected override CompositionContainer CreateContainer()
        {
            return base.CreateContainer();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(AutoPopulateExportedViewsBehavior).Assembly));
        }


        protected override Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
        {
            var factory = base.ConfigureDefaultRegionBehaviors();
            factory.AddIfMissing(typeof(AutoPopulateExportedViewsBehavior).Name, typeof(AutoPopulateExportedViewsBehavior));
            return factory;
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            try
            {
                return Microsoft.Practices.Prism.Modularity.ModuleCatalog.CreateFromXaml(new Uri(ModuleCatalogUri, UriKind.Relative));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
