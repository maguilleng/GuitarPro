using System;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Regions;
using System.ComponentModel.Composition;
using Constructora.Modules.Proyectos.Views;

namespace Constructora.Modules.Proyectos
{
    [ModuleExport(typeof(ProyectosModule), InitializationMode = InitializationMode.OnDemand)]
    public class ProyectosModule : IModule
    {
        [Import]
        public IRegionManager RegionManager { get; set; }
        
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public ProyectosModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            try
            {
                //RegionManager.RequestNavigate("MainContentRegion", "InventarioMainUserControl");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
