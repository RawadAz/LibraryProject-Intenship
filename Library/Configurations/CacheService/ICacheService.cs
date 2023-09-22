﻿namespace Library.Configurations.CacheService
{
    public interface ICacheService
    {
        T GetData<T>(string key);

        bool SetData<T>(string key, T value, DateTimeOffset expirationtime);

        object RemoveData(string key);
    }
}
