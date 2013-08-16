using System;
using System.Windows;
using System.Linq;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.ViewModel;
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.Collections;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using Constructora.Web;

namespace Constructora.Modules.Proyectos.ViewModels
{
    [Export]
    public class ProyectosViewModel : NotificationObject
    {
        [Import]
        public IRegionManager RegionManager { get; set; }

        public ConstructoraDomainContext context { get; set; }

        ObservableCollection<Empleado> users;
        public ObservableCollection<Empleado> Users
        {
            get { return users; }
            set
            {
                users = value;
                RaisePropertyChanged("Users");
            }
        }

        public ProyectosViewModel()
        {
            context = new ConstructoraDomainContext();
            getUsers();
        }

        public void getUsers()
        {
            context.Load(context.GetEmpleadosQuery(), (result) =>
                                                    {
                                                        Users = new ObservableCollection<Empleado>(result.Entities);
                                                    }, null);
        }
    }
}
