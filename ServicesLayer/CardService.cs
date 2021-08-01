using Common;
using DataLayer;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
namespace ServicesLayer
{
    public class CardService : ICRUDIslemleri<Card>
    {
        CardDAL dal;
        public CardService()
        {
            dal = new CardDAL();
        }
        public int Delete(int id)
        {
            return dal.Delete(id);
        }

        public int Delete(Card entity)
        {
            throw new NotImplementedException();
        }

        public Card Find(int id)
        {
            throw new NotImplementedException();
        }

        public Card Find(Card entity)
        {
            return dal.Find(entity);
        }

        public List<Card> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Card> ListAll(Card entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            return dal.ListAllDataTable();
        }

        public DataTable ListAllDataTable(Card entity)
        {
            throw new NotImplementedException();
        }
        public Card FindCardNo(Card entity)
        {
            return dal.FindCardNo(entity);
        }

        public int Save(Card entity)
        {
            return dal.Save(entity);
        }

        public int Save(List<Card> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Card entity)
        {
            return dal.Update(entity);
        }

        public int Update(List<Card> entity)
        {
            throw new NotImplementedException();
        }

    }
}
