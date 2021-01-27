using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UnityAPI.Models;

namespace UnityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionAgeGroupsController : ControllerBase
    {
        // GET api/QuestionAgeGroups/{id}
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
                var ageGroups = DbConnection.Instance.Connection.Table<QuestionAgeGroups>()
                    .Where(x => x.QuestionId == id);
                var ageGroupList = new List<string>();
                if (ageGroups != null && ageGroups.Any())
                {
                    ageGroupList.AddRange(
                        ageGroups.Select(ageGroup => DbConnection.Instance.Connection.Table<AgeGroups>()
                                .FirstOrDefault(x => x.AgeGroupId == ageGroup.AgeGroupId))
                            .Select(ageGroup => ageGroup.AgeGroupName));
                }

                rModel.Result = ageGroupList.Distinct();
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