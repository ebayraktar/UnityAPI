using UnityAPI.REST.Interfaces;

namespace UnityAPI.REST.Managers
{
    public class BaseManager
    {
        private readonly IBase _service;

        public BaseManager(IBase service)
        {
            _service = service;
        }

        public virtual bool Get<T>(out object resultData) where T : new()
        {
            return _service.Get<T>(out resultData);
        }

        public virtual bool Get<T>(string id, out object resultData) where T : new()
        {
            {
                return _service.Get<T>(id, out resultData);
            }
        }

        public virtual bool Post(object data, out object resultData)
        {
            return _service.Post(data, out resultData);
        }

        public virtual bool Put(string id, object data, out object resultData)
        {
            return _service.Put(id, data, out resultData);
        }

        public virtual bool Delete<T>(out object resultData)
        {
            return _service.Delete<T>(out resultData);
        }

        public virtual bool Delete<T>(string id, out object resultData)
        {
            return _service.Delete<T>(id, out resultData);
        }
    }
}