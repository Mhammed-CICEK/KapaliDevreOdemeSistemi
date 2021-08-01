using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Interfaces;
using DataLayer;
using System.Data;

namespace ServicesLayer
{
    public class PermissionsGroupService : ICRUDIslemleri<PermissionsGroup>
    {
        PermissionsGroupDAL dal = new PermissionsGroupDAL();
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(PermissionsGroup entity)
        {
            throw new NotImplementedException();
        }

        public PermissionsGroup Find(int id)
        {
            return dal.Find(id);
        }

        public PermissionsGroup Find(PermissionsGroup entity)
        {
            return dal.Find(entity);
        }

        public List<PermissionsGroup> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<PermissionsGroup> ListAll(PermissionsGroup entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable(PermissionsGroup entity)
        {
            throw new NotImplementedException();
        }

        public int Save(PermissionsGroup entity)
        {
            return dal.Save(entity);
        }

        public int Save(List<PermissionsGroup> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(PermissionsGroup entity)
        {
            throw new NotImplementedException();
        }

        public int Update(List<PermissionsGroup> entity)
        {
            throw new NotImplementedException();
        }
    }
}
