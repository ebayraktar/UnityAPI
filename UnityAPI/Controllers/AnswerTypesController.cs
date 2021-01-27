using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UnityAPI.Models;

namespace UnityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerTypesController : ControllerBase
    {
        // GET api/AnswerTypes/{id}
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
                var types = DbConnection.Instance.Connection.Table<AnswerTypes>()
                    .Where(x => x.AnswerId == id);
                var typeList= new List<string>();
                if (types != null && types.Any())
                {
                    typeList.AddRange(
                        types.Select(type => DbConnection.Instance.Connection.Table<Types>()
                                .FirstOrDefault(x => x.TypeId == type.TypeId))
                            .Select(tag => tag.TypeName));
                }
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