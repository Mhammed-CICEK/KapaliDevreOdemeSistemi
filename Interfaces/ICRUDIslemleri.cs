using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Interfaces
{
    public interface ICRUDIslemleri<T>
    {
        int Save(T entity);
        int Update(T entity);
        T Find(int id);//
        List<T> ListAll();
        DataTable ListAllDataTable();//
        int Delete(int id);//
        //Ekler
        //---------------------- Projede Kullanımı kesinlikle zorunlu değil
        int Delete(T entity);
        T Find(T entity);
        int Save(List<T> entity);
        int Update(List<T> entity);
        List<T> ListAll(T entity);
        DataTable ListAllDataTable(T entity);

    }
}
