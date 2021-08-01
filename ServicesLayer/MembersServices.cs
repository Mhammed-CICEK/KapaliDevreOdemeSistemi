using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Interfaces;
using Models;
namespace ServicesLayer
{
    public class MembersServices : ICRUDIslemleri<Members>
    {
        MembersDAL dal;
        public MembersServices()
        {
            dal = new MembersDAL();
        }
        public int Delete(int id)
        {
            return dal.Delete(id);
        }

        public int Delete(Members entity)
        {
            throw new NotImplementedException();
        }

        public DataTable FindTcNo(long tcKimlikNo)
        {
            return dal.FindTcNo(tcKimlikNo);
        }

        public Members Find(Members entity)
        {
            return dal.Find(entity);
        }
        public Members FindTcNo(Members entity)
        {
            return dal.FindTcNo(entity);
        }
        
        public List<Members> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Members> ListAll(Members entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            return dal.ListAllDataTable();
        }

        public DataTable ListAllDataTable(Members entity)
        {
            throw new NotImplementedException();
        }

        public int Save(Members entity)
        {
            return dal.Save(entity);
        }

        public int Save(List<Members> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Members entity)
        {
            return dal.Update(entity);
        }

        public int Update(List<Members> entity)
        {
            throw new NotImplementedException();
        }

        public Members Find(int id)
        {
            return dal.Find(id);
        }
    }
}
