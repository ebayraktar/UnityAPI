namespace UnityAPI.REST.Interfaces
{
    public interface IBase
    {
        bool Get<T>(out object resultData) where T : new();
        bool Get<T>(string id, out object resultData) where T : new();
        bool Post(object data, out object resultData);
        bool Put(string id, object data, out object resultData);
        bool Delete<T>(out object resultData);
        bool Delete<T>(string id, out object resultData);
    }
}