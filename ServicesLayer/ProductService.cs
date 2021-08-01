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
    public class ProductService : ICRUDIslemleri<Product>
    {
        ProductDAL dal = new ProductDAL();
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(Product entity)
        {
            return dal.Delete(entity);
        }

        public Product Find(int id)
        {
            throw new NotImplementedException();
        }

        public Product Find(Product entity)
        {
            return dal.Find(entity);
        }

        public List<Product> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> ListAll(Product entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            return dal.ListAllDataTable();
        }

        public DataTable ListAllDataTable(Product entity)
        {
            return dal.ListAllDataTable(entity);
        }

        public int Save(Product entity)
        {
            return dal.Save(entity);
        }

        public int Save(List<Product> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Product entity)
        {
            return dal.Update(entity);
        }

        public int Update(List<Product> entity)
        {
            return dal.Update(entity);
        }
    }
}
