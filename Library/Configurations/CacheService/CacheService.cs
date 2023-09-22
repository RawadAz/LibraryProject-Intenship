using Google.Protobuf.WellKnownTypes;
using System.Runtime.Caching;

namespace Library.Configurations.CacheService
{
    public class CacheService : ICacheService
    {
        
        private ObjectCache _memoryCache = MemoryCache.Default;

        public T GetData<T>(string key)
        {
            try
            {
                T item = (T) _memoryCache.Get(key);
                return item;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public object RemoveData(string key)
        {
            var res = true;
            try
            {
                if (!string.IsNullOrEmpty(key) && _memoryCache.Get(key) != null)
                {
                    _memoryCache.Remove(key);
                }
                else
                {
                    res = false;
                }
                return res;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool SetData<T>(string key, T value, DateTimeOffset expirationtime)
        {
            var res = true;

            try
            {
                if(!string.IsNullOrEmpty(key) && value != null)
                {
                    _memoryCache.Set(key, value, expirationtime);
                }
                else
                {
                    res = false;
                }
                return res;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
