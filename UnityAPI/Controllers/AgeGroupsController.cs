using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UnityAPI.Models;

namespace UnityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgeGroupsController : ControllerBase
    {
        // GET api/AgeGroups
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
                rModel.Result = DbConnection.Instance.Connection.Table<AgeGroups>()
                    .Select(x => x.AgeGroupName);
            }
            catch (Exception e)
            {
                rModel.Message = e.Message;
                rModel.OpCode = -1;
            }

            return rModel;
        }

        // GET api/AgeGroups/{id}
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
                rModel.Result = DbConnection.Instance.Connection.Table<AgeGroups>()
                    .Where(x => x.AgeGroupId == id)
                    .Select(x => x.AgeGroupName);
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