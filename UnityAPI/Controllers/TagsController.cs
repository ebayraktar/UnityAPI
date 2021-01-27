using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UnityAPI.Models;

namespace UnityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        // GET api/Tags
        [HttpGet]
        public ResponseModel Get()
        {
            var rModel = new ResponseModel
            {
                Message = "Başarılı",
                OpCode = 1
            };

            try
            {
                rModel.Result = DbConnection.Instance.Connection.Table<Tags>()
                    .Select(x => x.TagName);
            }
            catch (Exception e)
            {
                rModel.Message = e.Message;
                rModel.OpCode = -1;
            }

            return rModel;
        }

        // GET api/Tags/{id}
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
                rModel.Result = DbConnection.Instance.Connection.Table<Tags>()
                    .Where(x => x.TagId == id)
                    .Select(x => x.TagName);
            }
            catch (Exception e)
            {
                rModel.Message = e.Message;
                rModel.OpCode = -1;
            }

            return rModel;
        }
    }
}