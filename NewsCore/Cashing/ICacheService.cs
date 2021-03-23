using System;
using System.Collections.Generic;
using System.Text;

namespace NewsCore
{
    public interface ICacheService
    {
        object Get(string key);
        void Put(string key, object value, int duration);
    }
}
