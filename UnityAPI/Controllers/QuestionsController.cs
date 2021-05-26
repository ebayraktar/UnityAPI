using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using UnityAPI.Models;
using Enumerable = System.Linq.Enumerable;

namespace UnityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        // GET api/Questions
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
                rModel.Result = DbConnection.Instance.Connection.Table<Questions>().Count();
            }
            catch (Exception e)
            {
                rModel.Message = e.Message;
                rModel.OpCode = -1;
            }

            return rModel;
        }

        // GET api/Questions/{id}
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
                rModel.Result = DbConnection.Instance.Connection.Table<Questions>()
                    .Where(x => x.QuestionId == id);
            }
            catch (Exception e)
            {
                rModel.Message = e.Message;
                rModel.OpCode = -1;
            }

            return rModel;
        }

        // GET api/Questions/Params?ageGroupId=1&typeId=1&categoryId=3&tagId=0
        [HttpGet("Params/")]
        public ResponseModel Get(int ageGroupId, int typeId, int categoryId, int tagId)
        {
            var rModel = new ResponseModel
            {
                Message = "Başarılı",
                OpCode = 1
            };

            try
            {
                rModel.Result = from q in DbConnection.Instance.Connection.Table<Questions>()
                    join qag in DbConnection.Instance.Connection.Table<QuestionAgeGroups>()
                        on q.QuestionId equals qag.QuestionId
                    join qt in DbConnection.Instance.Connection.Table<QuestionTypes>()
                        on q.QuestionId equals qt.QuestionId
                    join qc in DbConnection.Instance.Connection.Table<QuestionCategories>()
                        on q.QuestionId equals qc.QuestionId
                    join qtg in DbConnection.Instance.Connection.Table<QuestionTags>()
                        on q.QuestionId equals qtg.QuestionId
                    where
                        (ageGroupId == 0 || qag.AgeGroupId == ageGroupId)
                        && (typeId == 0 || qt.TypeId == typeId)
                        && (categoryId == 0 || qc.CategoryId == categoryId)
                        && (tagId == 0 || qtg.TagId == tagId)
                    group q by (q.QuestionId, q.QuestionText, q.Point, q.IsDeleted)
                    into qs
                    select new {qs.Key.QuestionId, qs.Key.QuestionText, qs.Key.Point, qs.Key.IsDeleted};
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