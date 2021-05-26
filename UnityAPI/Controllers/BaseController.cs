using UnityAPI.Models;
using UnityAPI.REST.Managers;
using UnityAPI.REST.Services;
using Microsoft.AspNetCore.Mvc;

namespace UnityAPI.Controllers
{
    public class BaseController<T> : ControllerBase where T : new()
    {
        private readonly BaseManager _manager;
        private readonly ResponseModel _responseModel;

        public BaseController(BaseManager manager)
        {
            _manager = manager ?? new BaseManager(new BaseService());
            _responseModel = new ResponseModel
            {
                OpCode = -1,
                Message = "Başarısız"
            };
        }

        // GET api/books
        [HttpGet]
        public ResponseModel Get()
        {
            if (_manager.Get<T>(out var resultData))
            {
                _responseModel.OpCode = 0;
                _responseModel.Message = "Başarılı";
            }

            _responseModel.Result = resultData;
            return _responseModel;
            //Constants.Connection.Table<Book>();
        }

        // POST api/books
        [HttpPost]
        public ResponseModel Post([FromBody] object data)
        {
            if (_manager.Post(data, out object resultData))
            {
                _responseModel.OpCode = 0;
                _responseModel.Message = "Başarılı";
            }

            _responseModel.Result = resultData;
            return _responseModel;
            //Constants.Connection.InsertOrReplace(data);
        }

        // PUT api/books/5
        [HttpPut]
        public ResponseModel Put(string id, [FromBody] object data)
        {
            if (_manager.Put(id, data, out object resultData))
            {
                _responseModel.OpCode = 0;
                _responseModel.Message = "Başarılı";
            }

            _responseModel.Result = resultData;
            return _responseModel;
        }

        // DELETE api/books
        [HttpDelete]
        public ResponseModel Delete()
        {
            if (_manager.Delete<T>(out object resultData))
            {
                _responseModel.OpCode = 0;
                _responseModel.Message = "Başarılı";
            }

            _responseModel.Result = resultData;
            return _responseModel;
        }

        // DELETE api/books/5
        [HttpDelete]
        public ResponseModel Delete(string id)
        {
            if (_manager.Delete<T>(id, out object resultData))
            {
                _responseModel.OpCode = 0;
                _responseModel.Message = "Başarılı";
            }

            _responseModel.Result = resultData;
            return _responseModel;
        }
    }
}