using Castle.Core.Internal;
using Castle.DynamicProxy;
using NewsCore.Interceptors;
using Newtonsoft.Json;

namespace NewsCore.Interceptors
{
    public class CachingInterceptor : IInterceptor
    {
        private readonly ICacheService _cacheService;

        public CachingInterceptor(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        public void Intercept(IInvocation invocation)
        {
            var cacheAttribute = invocation.Method.GetAttribute<CachingAttribute>();
            if (cacheAttribute == null)
            {
                invocation.Proceed();
                return;
            }

            string cacheKey = invocation.Method.Name + JsonConvert.SerializeObject(invocation.Arguments);
            var cacheItem = _cacheService.Get(cacheKey);
            if (cacheItem != null)
                invocation.ReturnValue = cacheItem;
            else
            {
                invocation.Proceed();
                _cacheService.Put(cacheKey, invocation.ReturnValue, cacheAttribute.Duration);
            }
        }
    }
}
