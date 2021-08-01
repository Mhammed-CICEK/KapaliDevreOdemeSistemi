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
    public class StockGroupService : ICRUDIslemleri<StockGroup>
    {
        StockGroupDAL dal = new StockGroupDAL();
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(StockGroup entity)
        {
            return dal.Delete(entity);
        }

        public StockGroup Find(int id)
        {
            throw new NotImplementedException();
        }

        public StockGroup Find(StockGroup entity)
        {
            throw new NotImplementedException();
        }

        public List<StockGroup> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<StockGroup> ListAll(StockGroup entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            return dal.ListAllDataTable();
        }

        public DataTable ListAllDataTable(StockGroup entity)
        {
            throw new NotImplementedException();
        }

        public int Save(StockGroup entity)
        {
            return dal.Save(entity);
        }

        public int Save(List<StockGroup> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(StockGroup entity)
        {
            return dal.Update(entity);
        }

        public int Update(List<StockGroup> entity)
        {
            throw new NotImplementedException();
        }
    }
}
