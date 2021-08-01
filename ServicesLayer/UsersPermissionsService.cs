using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataLayer;
using Interfaces;
using System.Data;

namespace ServicesLayer
{
    public class UsersPermissionsService : ICRUDIslemleri<UserPermissions>
    {
        UsersPermissionsDAL dal = new UsersPermissionsDAL();
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(UserPermissions entity)
        {
            throw new NotImplementedException();
        }

        public UserPermissions Find(int id)
        {
            return dal.Find(id);
        }

        public UserPermissions Find(UserPermissions entity)
        {
            throw new NotImplementedException();
        }

        public List<UserPermissions> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<UserPermissions> ListAll(UserPermissions entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable(UserPermissions entity)
        {
            throw new NotImplementedException();
        }

        public int Save(UserPermissions entity)
        {
            return dal.Save(entity);
        }

        public int Save(List<UserPermissions> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(UserPermissions entity)
        {
            return dal.Update(entity);
        }

        public int Update(List<UserPermissions> entity)
        {
            throw new NotImplementedException();
        }
    }
}
