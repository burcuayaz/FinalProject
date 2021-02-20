using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic constraintşu ifadedir (where T:class)
    //class referans tiptir.
    public interface IEntityRepository<T> where T:class,IEntity,new() // yani T yerine yazılan şey class olmalı ve IEntityden referans almış olmalı, newlenebilir olmalı
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//kategoriye göre getir, ürüne göre getir vs vs
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
