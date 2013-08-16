using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.DomainServices.EntityFramework;
using System.Web;

namespace Constructora.Web
{
    public partial class ConstructoraDomainService : DbDomainService<dbAlmacenEntities> 
    {
    }
}