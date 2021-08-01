using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Interfaces;
using DataLayer;
using System.Data;
using DataLayer;
namespace ServicesLayer
{
    public class BalanceService : ICRUDIslemleri<Balance>
    {
        BalanceDAL dal = new BalanceDAL();
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(Balance entity)
        {
            throw new NotImplementedException();
        }

        public Balance Find(int id)
        {
            return dal.Find(id);
        }

        public Balance Find(Balance entity)
        {
            return dal.Find(entity);
        }

        public List<Balance> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Balance> ListAll(Balance entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable(Balance entity)
        {
            throw new NotImplementedException();
        }

        public int Save(Balance entity)
        {
            return dal.Save(entity);
        }

        public int Save(List<Balance> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Balance entity)
        {
            throw new NotImplementedException();
        }

        public int Update(List<Balance> entity)
        {
            throw new NotImplementedException();
        }
    }
}
