using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ServiceModel.DomainServices.Hosting;
using System.ServiceModel.DomainServices.Server;
using System.ServiceModel.DomainServices.Server.ApplicationServices;

namespace Constructora.Web
{
    [EnableClientAccess]
    public class AuthenticationDomainService : AuthenticationBase<UserAuth>
    {
        // Para habilitar la autenticación de Forms o Windows para la aplicación web, edite la sección correspondiente del archivo web.config.
    }

    public class UserAuth : UserBase
    {
        // NOTA: las propiedades de perfil se pueden agregar aquí 
        // Para habilitar perfiles, edite la sección correspondiente del archivo web.config.

        // public string MyProfileProperty { get; set; }
    }
}