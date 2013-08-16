
namespace Constructora.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // El MetadataTypeAttribute identifica a ApplicationMetadata como la clase
    // que contiene metadatos adicionales para la class Application.
    [MetadataTypeAttribute(typeof(Application.ApplicationMetadata))]
    public partial class Application
    {

        // Esta clase permite adjuntar atributos personalizados a properties
        // de la clase Application.
        //
        // Por ejemplo, lo siguiente marca la propiedad Xyz como una
        // propiedad requerida y especifica el formato de los valores válidos:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ApplicationMetadata
        {

            // No se van a crear instancias de las clases de metadatos.
            private ApplicationMetadata()
            {
            }

            public Guid ApplicationId { get; set; }

            public string ApplicationName { get; set; }

            public string Description { get; set; }

            public ICollection<Membership> Memberships { get; set; }

            public ICollection<Role> Roles { get; set; }

            public ICollection<User> Users { get; set; }
        }
    }

    // El MetadataTypeAttribute identifica a EmpleadoMetadata como la clase
    // que contiene metadatos adicionales para la class Empleado.
    [MetadataTypeAttribute(typeof(Empleado.EmpleadoMetadata))]
    public partial class Empleado
    {

        // Esta clase permite adjuntar atributos personalizados a properties
        // de la clase Empleado.
        //
        // Por ejemplo, lo siguiente marca la propiedad Xyz como una
        // propiedad requerida y especifica el formato de los valores válidos:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class EmpleadoMetadata
        {

            // No se van a crear instancias de las clases de metadatos.
            private EmpleadoMetadata()
            {
            }

            public string ApPaterno { get; set; }

            public int EmpleadoId { get; set; }

            public string Nombre { get; set; }
        }
    }

    // El MetadataTypeAttribute identifica a MembershipMetadata como la clase
    // que contiene metadatos adicionales para la class Membership.
    [MetadataTypeAttribute(typeof(Membership.MembershipMetadata))]
    public partial class Membership
    {

        // Esta clase permite adjuntar atributos personalizados a properties
        // de la clase Membership.
        //
        // Por ejemplo, lo siguiente marca la propiedad Xyz como una
        // propiedad requerida y especifica el formato de los valores válidos:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class MembershipMetadata
        {

            // No se van a crear instancias de las clases de metadatos.
            private MembershipMetadata()
            {
            }

            public Application Application { get; set; }

            public Guid ApplicationId { get; set; }

            public string Comment { get; set; }

            public DateTime CreateDate { get; set; }

            public string Email { get; set; }

            public int FailedPasswordAnswerAttemptCount { get; set; }

            public DateTime FailedPasswordAnswerAttemptWindowsStart { get; set; }

            public int FailedPasswordAttemptCount { get; set; }

            public DateTime FailedPasswordAttemptWindowStart { get; set; }

            public bool IsApproved { get; set; }

            public bool IsLockedOut { get; set; }

            public DateTime LastLockoutDate { get; set; }

            public DateTime LastLoginDate { get; set; }

            public DateTime LastPasswordChangedDate { get; set; }

            public string Password { get; set; }

            public string PasswordAnswer { get; set; }

            public int PasswordFormat { get; set; }

            public string PasswordQuestion { get; set; }

            public string PasswordSalt { get; set; }

            public User User { get; set; }

            public Guid UserId { get; set; }
        }
    }

    // El MetadataTypeAttribute identifica a ProfileMetadata como la clase
    // que contiene metadatos adicionales para la class Profile.
    [MetadataTypeAttribute(typeof(Profile.ProfileMetadata))]
    public partial class Profile
    {

        // Esta clase permite adjuntar atributos personalizados a properties
        // de la clase Profile.
        //
        // Por ejemplo, lo siguiente marca la propiedad Xyz como una
        // propiedad requerida y especifica el formato de los valores válidos:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ProfileMetadata
        {

            // No se van a crear instancias de las clases de metadatos.
            private ProfileMetadata()
            {
            }

            public DateTime LastUpdatedDate { get; set; }

            public string PropertyNames { get; set; }

            public byte[] PropertyValueBinary { get; set; }

            public string PropertyValueStrings { get; set; }

            public User User { get; set; }

            public Guid UserId { get; set; }
        }
    }

    // El MetadataTypeAttribute identifica a RoleMetadata como la clase
    // que contiene metadatos adicionales para la class Role.
    [MetadataTypeAttribute(typeof(Role.RoleMetadata))]
    public partial class Role
    {

        // Esta clase permite adjuntar atributos personalizados a properties
        // de la clase Role.
        //
        // Por ejemplo, lo siguiente marca la propiedad Xyz como una
        // propiedad requerida y especifica el formato de los valores válidos:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class RoleMetadata
        {

            // No se van a crear instancias de las clases de metadatos.
            private RoleMetadata()
            {
            }

            public Application Application { get; set; }

            public Guid ApplicationId { get; set; }

            public string Description { get; set; }

            public Guid RoleId { get; set; }

            public string RoleName { get; set; }

            public ICollection<User> Users { get; set; }
        }
    }

    // El MetadataTypeAttribute identifica a UserMetadata como la clase
    // que contiene metadatos adicionales para la class User.
    [MetadataTypeAttribute(typeof(User.UserMetadata))]
    public partial class User
    {

        // Esta clase permite adjuntar atributos personalizados a properties
        // de la clase User.
        //
        // Por ejemplo, lo siguiente marca la propiedad Xyz como una
        // propiedad requerida y especifica el formato de los valores válidos:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class UserMetadata
        {

            // No se van a crear instancias de las clases de metadatos.
            private UserMetadata()
            {
            }

            public Application Application { get; set; }

            public Guid ApplicationId { get; set; }

            public bool IsAnonymous { get; set; }

            public DateTime LastActivityDate { get; set; }

            public Membership Membership { get; set; }

            public Profile Profile { get; set; }

            public ICollection<Role> Roles { get; set; }

            public Guid UserId { get; set; }

            public UserInfo UserInfo { get; set; }

            public string UserName { get; set; }
        }
    }

    // El MetadataTypeAttribute identifica a UserInfoMetadata como la clase
    // que contiene metadatos adicionales para la class UserInfo.
    [MetadataTypeAttribute(typeof(UserInfo.UserInfoMetadata))]
    public partial class UserInfo
    {

        // Esta clase permite adjuntar atributos personalizados a properties
        // de la clase UserInfo.
        //
        // Por ejemplo, lo siguiente marca la propiedad Xyz como una
        // propiedad requerida y especifica el formato de los valores válidos:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class UserInfoMetadata
        {

            // No se van a crear instancias de las clases de metadatos.
            private UserInfoMetadata()
            {
            }

            public string ApMaterno { get; set; }

            public string ApPaterno { get; set; }

            public Nullable<int> Ficha { get; set; }

            public string Nombre { get; set; }

            public User User { get; set; }

            public Guid UserId { get; set; }
        }
    }
}
