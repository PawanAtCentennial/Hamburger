using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgerExample.Data
{
    interface Repository<T>
    {
        IEnumerable<T> All();
        IEnumerable<T> Where(Predicate<T> query);
        bool Add(T item);
        bool Remove(T item);
        bool Update(T item);
    }
}
