using DataLayer;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    public class CardAccountService : ICRUDIslemleri<CardAccount>
    {
        CardAccountDAL dal = new CardAccountDAL();
        public int Delete(int id)
        {
            return dal.Delete(id);
        }

        public int Delete(CardAccount entity)
        {
            return dal.Delete(entity);
        }
        public CardAccount FindCardNo(string cardNo)
        {
            return dal.FindCardNo(cardNo);
        }

        public CardAccount Find(int id)
        {
            return dal.Find(id);
        }

        public CardAccount Find(CardAccount entity)
        {
            return dal.Find(entity);
        }
        public CardAccount FindforUpdate(CardAccount entity)
        {
            return dal.FindforUpdate(entity);
        }

        public List<CardAccount> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<CardAccount> ListAll(CardAccount entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            return dal.ListAllDataTable();
        }

        public DataTable ListAllDataTable(CardAccount entity)
        {
            throw new NotImplementedException();
        }

        public int Save(CardAccount entity)
        {
            return dal.Save(entity);
        }

        public int Save(List<CardAccount> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CardAccount entity)
        {
            return dal.Update(entity);
        }

        public int Update(List<CardAccount> entity)
        {
            throw new NotImplementedException();
        }
    }
}
