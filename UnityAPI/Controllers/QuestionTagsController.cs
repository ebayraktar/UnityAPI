using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UnityAPI.Models;

namespace UnityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionTagsController : ControllerBase
    {
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
                var tags = DbConnection.Instance.Connection.Table<QuestionTags>()
                    .Where(x => x.QuestionId == id);
                var tagList = new List<string>();
                if (tags != null && tags.Any())
                {
                    tagList.AddRange(
                        tags.Select(tag => DbConnection.Instance.Connection.Table<Tags>()
                            .FirstOrDefault(x => x.TagId == tag.TagId))
                        .Select(tag => tag.TagName));
                }

                rModel.Result = tagList.Distinct();
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