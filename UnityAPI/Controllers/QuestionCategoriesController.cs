using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UnityAPI.Models;

namespace UnityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionCategoriesController : ControllerBase
    {
        // GET api/QuestionCategories/{id}
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
                var tags = DbConnection.Instance.Connection.Table<QuestionCategories>()
                    .Where(x => x.QuestionId == id);
                var tagList = new List<string>();
                if (tags != null && tags.Any())
                {
                    tagList.AddRange(
                        tags.Select(tag => DbConnection.Instance.Connection.Table<Categories>()
                                .FirstOrDefault(x => x.CategoryId == tag.CategoryId))
                            .Select(tag => tag.CategoryName));
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