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
    public class SalesService : ICRUDIslemleri<Sales>
    {
        SalesDAL dal = new SalesDAL();
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(Sales entity)
        {
            throw new NotImplementedException();
        }

        public Sales Find(int id)
        {
            throw new NotImplementedException();
        }

        public Sales Find(Sales entity)
        {
            throw new NotImplementedException();
        }

        public List<Sales> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Sales> ListAll(Sales entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable(Sales entity)
        {
            throw new NotImplementedException();
        }

        public int Save(Sales entity)
        {
            throw new NotImplementedException();
        }

        public int Save(List<Sales> entity)
        {
            return dal.Save(entity);
        }

        public int Update(Sales entity)
        {
            throw new NotImplementedException();
        }

        public int Update(List<Sales> entity)
        {
            throw new NotImplementedException();
        }
    }
}
