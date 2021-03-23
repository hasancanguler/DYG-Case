using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsDAL
{
    public interface IRepository<T>
    {
        List<T> Get();
    }
}
