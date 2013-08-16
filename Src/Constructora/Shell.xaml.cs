using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Constructora
{
    [Export]
    public partial class Shell : UserControl
    {
        [Import("ShellViewModel")]
        public object ViewModel
        {
            get { return this.DataContext; }
            set
            {
                DataContext = value;
            }
        }
        
        public Shell()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            HtmlPage.Plugin.Focus();
        }
    }
}
