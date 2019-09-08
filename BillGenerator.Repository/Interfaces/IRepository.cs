using BillGenerator.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace BillGenerator.Repository.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        T Insert(T obj);
        bool Remove(T obj);
        List<T> GetAll();
        T GetById(int id);
        List<T> Query(string query, DynamicParameters parameters);
    }
}
