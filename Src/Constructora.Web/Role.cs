//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Constructora.Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public Role()
        {
            this.Users = new HashSet<User>();
        }
    
        public System.Guid ApplicationId { get; set; }
        public System.Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
    
        public virtual Application Application { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
