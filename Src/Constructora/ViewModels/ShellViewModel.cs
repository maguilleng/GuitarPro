using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Events;
using System.ComponentModel;
using Microsoft.Practices.Prism.Commands;
using System.ComponentModel.Composition;
using System.Windows.Input;
using System.ServiceModel.DomainServices.Client.ApplicationServices;
using Constructora.Web;
using System.Linq;
using Microsoft.Practices.Prism.Regions;
using System.ComponentModel.DataAnnotations;
using Constructora.Infrastructure;

namespace Constructora.ViewModels
{
    [Export("ShellViewModel")]
    public class ShellViewModel : NotificationObject
    {
        #region Propiedades y Atributos
        [Import(AllowRecomposition = false)]
        public IModuleManager ModuleManager;

        [Import]
        public IRegionManager RegionManager { get; set; }

        public ICommand LoginUserCommand { get; private set; }
        public ICommand CancelLoginCommand { get; set; }
        public ICommand CloseSessionCommand { get; set; }

        string strUser;
        [Required]
        public string StrUser
        {
            get { return strUser; }
            set
            {
                strUser = value;
                RaisePropertyChanged("StrUser");
            }
        }

        string strPassword;
        [Required]
        public string StrPassword
        {
            get { return strPassword; }
            set
            {
                strPassword = value;
                RaisePropertyChanged("StrPassword");
            }
        }

        string strNotifications;
        public string StrNotifications
        {
            get { return strNotifications; }
            set
            {
                strNotifications = value;
                RaisePropertyChanged("StrNotifications");
            }
        }

        bool enableLoginButton;
        public bool EnableLoginButton
        {
            get { return enableLoginButton; }
            set
            {
                enableLoginButton = value;
                RaisePropertyChanged("EnableLoginButton");
            }
        }

        UserAuth currentUser;
        public UserAuth CurrentUser
        {
            get { return currentUser; }
            set
            {
                currentUser = value;
                RaisePropertyChanged("CurrentUser");
            }
        }
        #endregion

        #region Funciones
        private void OnLoginUser(object obj)
        {
            if (StrUser == null || StrUser == String.Empty)
            {
                StrNotifications = "Debe escribir su Usuario.";
                return;
            }

            if (StrPassword == null || StrPassword == String.Empty)
            {
                StrNotifications = "Debe escribir su Contraseña.";
                return;
            }

            this.EnableLoginButton = false;
            LoginParameters lp = new LoginParameters(StrUser, StrPassword);
            try
            {
                WebContext.Current.Authentication.Login(lp, LoginOperationCompleted, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Autenticación: " + ex.Message);
            }

        }

        private void OnCancelLogin(object obj)
        {
            StrUser = String.Empty;
            StrPassword = String.Empty;
            StrNotifications = String.Empty;
        }

        private void LoginOperationCompleted(LoginOperation lo)
        {
            StrNotifications = String.Empty;
            this.EnableLoginButton = true;
            if (!lo.HasError)
            {
                if (lo.LoginSuccess)
                {
                    if (WebContext.Current.User.IsAuthenticated)
                    {
                        StrUser = String.Empty;
                        StrPassword = String.Empty;
                        CurrentUser = WebContext.Current.User;
                        //MessageBox.Show(CurrentUser.Roles.First());
                    }
                    this.RegionManager.RequestNavigate("HeaderRegion", "HeaderUserControl");

                    try
                    {
                        this.ModuleManager.LoadModule("ProyectosModule");
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show(ex.Message);
                    }
                    
                    this.ModuleManager.LoadModuleCompleted += ModuleManager_LoadModuleCompleted;
                    this.RegionManager.RequestNavigate("MainContentRegion", "ProyectosMainUserControl");
                    this.RegionManager.RequestNavigate("MainMenuRegion", "MainMenuUserControl");
                }
                else
                    if (!lo.LoginSuccess)
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrectos.");
                    }
            }
            else
            {
                MessageBox.Show("Error de Autenticación. Consulte al Soporte técnico del Sistema.");
            }
        }

        private void OnCloseSession(object obj)
        {
            WebContext.Current.Authentication.Logout(LogoutOperationCompleted, null);
        }
        private void LogoutOperationCompleted(LogoutOperation lo)
        {
            if (!lo.HasError)
            {
                CurrentUser = null;
                var region = this.RegionManager.Regions["MainContentRegion"];
                //region.ClearActiveViews();
                RegionManager.RequestNavigate("MainContentRegion", "LoginUserControl");

                var headerRegion = this.RegionManager.Regions["HeaderRegion"];
                headerRegion.ClearActiveViews();

                var menuRegion = this.RegionManager.Regions["MainMenuRegion"];
                menuRegion.ClearActiveViews();
            }
        }


        public void OnImportsSatisfied()
        {
            this.ModuleManager.ModuleDownloadProgressChanged += new EventHandler<ModuleDownloadProgressChangedEventArgs>(ModuleManager_ModuleDownloadProgressChanged);
            this.ModuleManager.LoadModuleCompleted += new EventHandler<LoadModuleCompletedEventArgs>(ModuleManager_LoadModuleCompleted);
        }

        private void ModuleManager_LoadModuleCompleted(object sender, LoadModuleCompletedEventArgs e)
        {
            try
            {
                this.RegionManager.RequestNavigate("MainContentRegion", "ProyectosMainUserControl");
            }
            catch (Exception ex)
            {
                //this.EventAggregator.GetEvent<ErrorEvent>().Publish(ex);
            }
        }

        private void ModuleManager_ModuleDownloadProgressChanged(object sender, ModuleDownloadProgressChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                //this.EventAggregator.GetEvent<ErrorEvent>().Publish(ex);
            }
        }

        [ImportingConstructor]
        public ShellViewModel(IEventAggregator eventAggregator)
        {
            this.LoginUserCommand = new DelegateCommand<object>(this.OnLoginUser);
            this.CloseSessionCommand = new DelegateCommand<object>(this.OnCloseSession);
            this.CancelLoginCommand = new DelegateCommand<object>(this.OnCancelLogin);
            this.EnableLoginButton = true;
        }
        #endregion
    }
}
