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
    public class UsersService : ICRUDIslemleri<Users>
    {
        UsersDAL dal = new UsersDAL();
        public int Delete(int id)
        {
            return dal.Delete(id);
        }

        public int Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public Users Find(int id)
        {
            throw new NotImplementedException();
        }

        public Users Find(Users entity)
        {
            return dal.Find(entity);
        }
        public Users FindforUpdate(Users entity)
        {
            return dal.FindforUpdate(entity);
        }

        public List<Users> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Users> ListAll(Users entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            return dal.ListAllDataTable();
        }

        public DataTable ListAllDataTable(Users entity)
        {
            throw new NotImplementedException();
        }
        public DataTable FindforLogin(string kullaniciAdi, string sifre)
        {
            return dal.FindforLogin(kullaniciAdi,sifre);
        }

        public int Save(Users entity)
        {
            return dal.Save(entity);
        }

        public int Save(List<Users> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Users entity)
        {
            return dal.Update(entity);
        }

        public int Update(List<Users> entity)
        {
            throw new NotImplementedException();
        }
    }
}
