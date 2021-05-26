using System;
using Microsoft.AspNetCore.Mvc;
using UnityAPI.Models;

namespace UnityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        // GET api/Answers/{id}
        [HttpGet("{id}")]
        public ResponseModel Get(int id)
        {
            var rModel = new ResponseModel
            {
                Message = "Başarılı",
                OpCode = 1
            };

            try
            {
                rModel.Result = DbConnection.Instance.Connection.Table<Answers>()
                    .Where(x => x.QuestionId == id);
            }
            catch (Exception e)
            {
                rModel.Message = e.Message;
                rModel.OpCode = -1;
            }

            return rModel;
        }

        [HttpPost]
        public ResponseModel Post([FromBody] object data)
        {
            var rModel = new ResponseModel
            {
                Message = "Başarılı",
                OpCode = 1
            };
            if (data is Answers)
            {
                rModel.Result = Constants.Connection.Insert(data) > 0 ? 1 : 0;
            }
            else
            {
                rModel.Message = "Hatalı model";
                rModel.OpCode = -1;
            }

            return rModel;

            /*
                if (_manager.Post(data, out object resultData))
                {
                    _responseModel.OpCode = 0;
                    _responseModel.Message = "Başarılı";
                }

                _responseModel.Result = resultData;
                return _responseModel;
                //Constants.Connection.InsertOrReplace(data);
                */
        }
    }
}