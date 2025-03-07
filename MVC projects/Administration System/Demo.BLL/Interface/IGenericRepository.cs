﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int? id);
        IEnumerable<T> GetAll();
        int Add(T item);
        int Update(T item);
        int Delete(T item);
    }
}
