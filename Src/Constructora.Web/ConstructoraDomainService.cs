
namespace Constructora.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // Implementa la lógica de la aplicación mediante el contexto dbAlmacenEntities.
    // TODO: agregue la lógica de su aplicación a estos métodos o en métodos adicionales.
    // TODO: aplique la autenticación (Windows/ASP.NET Forms) y quite las marcas de comentario de lo siguiente para deshabilitar el acceso anónimo
    // Considere además la posibilidad de agregar roles para restringir el acceso según necesidad.
    [RequiresAuthentication]
    [EnableClientAccess()]
    public partial class ConstructoraDomainService : DbDomainService<dbAlmacenEntities>
    {

        // TODO:
        // Considere la posibilidad de restringir los resultados de su método de consulta. Si necesita entradas adicionales, puede
        // agregar parámetros a este método o crear métodos de consulta adicionales con distintos nombres.
        // Para admitir la paginación tendrá que agregar ordenación a la consulta 'Applications'.
        public IQueryable<Application> GetApplications()
        {
            return this.DbContext.Applications;
        }

        public void InsertApplication(Application application)
        {
            DbEntityEntry<Application> entityEntry = this.DbContext.Entry(application);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.Applications.Add(application);
            }
        }

        public void UpdateApplication(Application currentApplication)
        {
            this.DbContext.Applications.AttachAsModified(currentApplication, this.ChangeSet.GetOriginal(currentApplication), this.DbContext);
        }

        public void DeleteApplication(Application application)
        {
            DbEntityEntry<Application> entityEntry = this.DbContext.Entry(application);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.Applications.Attach(application);
                this.DbContext.Applications.Remove(application);
            }
        }

        // TODO:
        // Considere la posibilidad de restringir los resultados de su método de consulta. Si necesita entradas adicionales, puede
        // agregar parámetros a este método o crear métodos de consulta adicionales con distintos nombres.
        // Para admitir la paginación tendrá que agregar ordenación a la consulta 'Empleados'.
        public IQueryable<Empleado> GetEmpleados()
        {
            return this.DbContext.Empleados;
        }

        public void InsertEmpleado(Empleado empleado)
        {
            DbEntityEntry<Empleado> entityEntry = this.DbContext.Entry(empleado);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.Empleados.Add(empleado);
            }
        }

        public void UpdateEmpleado(Empleado currentEmpleado)
        {
            this.DbContext.Empleados.AttachAsModified(currentEmpleado, this.ChangeSet.GetOriginal(currentEmpleado), this.DbContext);
        }

        public void DeleteEmpleado(Empleado empleado)
        {
            DbEntityEntry<Empleado> entityEntry = this.DbContext.Entry(empleado);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.Empleados.Attach(empleado);
                this.DbContext.Empleados.Remove(empleado);
            }
        }

        // TODO:
        // Considere la posibilidad de restringir los resultados de su método de consulta. Si necesita entradas adicionales, puede
        // agregar parámetros a este método o crear métodos de consulta adicionales con distintos nombres.
        // Para admitir la paginación tendrá que agregar ordenación a la consulta 'Memberships'.
        public IQueryable<Membership> GetMemberships()
        {
            return this.DbContext.Memberships;
        }

        public void InsertMembership(Membership membership)
        {
            DbEntityEntry<Membership> entityEntry = this.DbContext.Entry(membership);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.Memberships.Add(membership);
            }
        }

        public void UpdateMembership(Membership currentMembership)
        {
            this.DbContext.Memberships.AttachAsModified(currentMembership, this.ChangeSet.GetOriginal(currentMembership), this.DbContext);
        }

        public void DeleteMembership(Membership membership)
        {
            DbEntityEntry<Membership> entityEntry = this.DbContext.Entry(membership);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.Memberships.Attach(membership);
                this.DbContext.Memberships.Remove(membership);
            }
        }

        // TODO:
        // Considere la posibilidad de restringir los resultados de su método de consulta. Si necesita entradas adicionales, puede
        // agregar parámetros a este método o crear métodos de consulta adicionales con distintos nombres.
        // Para admitir la paginación tendrá que agregar ordenación a la consulta 'Profiles'.
        public IQueryable<Profile> GetProfiles()
        {
            return this.DbContext.Profiles;
        }

        public void InsertProfile(Profile profile)
        {
            DbEntityEntry<Profile> entityEntry = this.DbContext.Entry(profile);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.Profiles.Add(profile);
            }
        }

        public void UpdateProfile(Profile currentProfile)
        {
            this.DbContext.Profiles.AttachAsModified(currentProfile, this.ChangeSet.GetOriginal(currentProfile), this.DbContext);
        }

        public void DeleteProfile(Profile profile)
        {
            DbEntityEntry<Profile> entityEntry = this.DbContext.Entry(profile);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.Profiles.Attach(profile);
                this.DbContext.Profiles.Remove(profile);
            }
        }

        // TODO:
        // Considere la posibilidad de restringir los resultados de su método de consulta. Si necesita entradas adicionales, puede
        // agregar parámetros a este método o crear métodos de consulta adicionales con distintos nombres.
        // Para admitir la paginación tendrá que agregar ordenación a la consulta 'Roles'.
        public IQueryable<Role> GetRoles()
        {
            return this.DbContext.Roles;
        }

        public void InsertRole(Role role)
        {
            DbEntityEntry<Role> entityEntry = this.DbContext.Entry(role);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.Roles.Add(role);
            }
        }

        public void UpdateRole(Role currentRole)
        {
            this.DbContext.Roles.AttachAsModified(currentRole, this.ChangeSet.GetOriginal(currentRole), this.DbContext);
        }

        public void DeleteRole(Role role)
        {
            DbEntityEntry<Role> entityEntry = this.DbContext.Entry(role);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.Roles.Attach(role);
                this.DbContext.Roles.Remove(role);
            }
        }

        // TODO:
        // Considere la posibilidad de restringir los resultados de su método de consulta. Si necesita entradas adicionales, puede
        // agregar parámetros a este método o crear métodos de consulta adicionales con distintos nombres.
        // Para admitir la paginación tendrá que agregar ordenación a la consulta 'Users'.
        public IQueryable<User> GetUsers()
        {
            return this.DbContext.Users;
        }

        public void InsertUser(User user)
        {
            DbEntityEntry<User> entityEntry = this.DbContext.Entry(user);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.Users.Add(user);
            }
        }

        public void UpdateUser(User currentUser)
        {
            this.DbContext.Users.AttachAsModified(currentUser, this.ChangeSet.GetOriginal(currentUser), this.DbContext);
        }

        public void DeleteUser(User user)
        {
            DbEntityEntry<User> entityEntry = this.DbContext.Entry(user);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.Users.Attach(user);
                this.DbContext.Users.Remove(user);
            }
        }

        // TODO:
        // Considere la posibilidad de restringir los resultados de su método de consulta. Si necesita entradas adicionales, puede
        // agregar parámetros a este método o crear métodos de consulta adicionales con distintos nombres.
        // Para admitir la paginación tendrá que agregar ordenación a la consulta 'UserInfoes'.
        public IQueryable<UserInfo> GetUserInfoes()
        {
            return this.DbContext.UserInfoes;
        }

        public void InsertUserInfo(UserInfo userInfo)
        {
            DbEntityEntry<UserInfo> entityEntry = this.DbContext.Entry(userInfo);
            if ((entityEntry.State != EntityState.Detached))
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbContext.UserInfoes.Add(userInfo);
            }
        }

        public void UpdateUserInfo(UserInfo currentUserInfo)
        {
            this.DbContext.UserInfoes.AttachAsModified(currentUserInfo, this.ChangeSet.GetOriginal(currentUserInfo), this.DbContext);
        }

        public void DeleteUserInfo(UserInfo userInfo)
        {
            DbEntityEntry<UserInfo> entityEntry = this.DbContext.Entry(userInfo);
            if ((entityEntry.State != EntityState.Deleted))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbContext.UserInfoes.Attach(userInfo);
                this.DbContext.UserInfoes.Remove(userInfo);
            }
        }
    }
}


