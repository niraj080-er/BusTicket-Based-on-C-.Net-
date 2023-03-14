using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Infrastructure
{
    public  interface IGenericReposetries<T> where T:class

    {
         IEnumerable<T> GetAll(String ? includeProperties = null);
        T GetFirstorDefault(Expression<Func<T, bool>> predicate, string? includeProperties=null);
        void Insert(T obj); 
        void Delet(T obj);
        void DeletRange(IEnumerable<T> obj); 
    }
}
