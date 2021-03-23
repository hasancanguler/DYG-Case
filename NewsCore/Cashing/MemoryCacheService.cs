
using Microsoft.Extensions.Caching.Memory;
using System;

namespace NewsCore
{
    public class MemoryCacheService : ICacheService
    {
        private readonly IMemoryCache _cacheService;
        public DateTime expires;
        public MemoryCacheService(IMemoryCache cacheService)
        {
            _cacheService = cacheService;            
        }

        public object Get(string key)
        {
            return _cacheService.Get(key);
        }

        public void Put(string key, object value, int duration)
        {
            expires = DateTime.Now.AddMinutes(duration);
            _cacheService.Set(key, value, expires);
        }
    }
}
