using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;
using Constructora.Infrastructure;
using Constructora.Modules.Proyectos.ViewModels;

namespace Constructora.Modules.Proyectos.Views
{
    [ViewExport(RegionName = "MainContentRegion", IsActiveByDefault = true)]
    public partial class ProyectosMainUserControl : UserControl
    {
        [Import]
        public IRegionManager RegionManager { get; set; }

        [Import]
        public ProyectosViewModel ViewModel
        {
            get
            {
                return this.DataContext as ProyectosViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }
        
        public ProyectosMainUserControl()
        {
            InitializeComponent();
        }
    }
}
