﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework.Interfaces
{
    public interface IUnitOfWork<T> where T : class
    {
        int Save(T model);
        int Update(T model);
        void Delete(T model);
        IEnumerable<T> GetAll();
        T GetById(object id);
        IEnumerable<T> Where(Expression<Func<T, bool>> expression);
        IEnumerable<T> OrderBy(Expression<Func<T, bool>> expression);
    }
}
