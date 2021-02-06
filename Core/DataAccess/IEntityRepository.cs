
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new() //generic constraint - generic kısıt / class: referans tip / T artık IEntity olabilir yada IEntity Implamente eden bir nesne olabilir / newlenebilir olmalı- IEntity newlenemeyeceği için artık IEntity koyamayız.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // filte vermediysek tüm listeyi istiyoruz demek / filtreler yazabilmemizi sağlıyor
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
               
    }
}
