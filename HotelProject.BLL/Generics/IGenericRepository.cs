﻿using Microsoft.EntityFrameworkCore.Query;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BLL.Generics
{
    public interface IGenericRepository
    {
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,

            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<Task, object>> include = null,
            bool disabledTracking = true);

        T GetById(object id);

        T GetByIdAsync(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            bool disabledTracking = true);

        void Add(T entity);
        Task<T> AddAsync(T entity);
        void Update(T entity);
        Task<T> UpdateAsync(T entity);
        void Delete(T entity);
        Task<T> DeleteAsync(T entity);
        void DeleteRange(List<T> entityList);





    }
}
