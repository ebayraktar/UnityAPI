using System;
using Microsoft.AspNetCore.Mvc;
using UnityAPI.Models;

namespace UnityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // // POST api/users/login
        // [HttpPost("login")]
        // public ResponseModel Post(Users user)
        // {
        //     if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
        //     {
        //         return new ResponseModel
        //         {
        //             Message = "Kullanıcı adı veya parola boş olamaz",
        //             OpCode = 0
        //         };
        //     }
        //
        //     var rModel = new ResponseModel
        //     {
        //         Message = "Başarılı",
        //         OpCode = 1
        //     };
        //
        //     try
        //     {
        //         var tempUser = DbConnection.Instance.Connection
        //             .Table<Users>().FirstOrDefault(x =>
        //                 x.Username.Equals(user.Username) && x.Password.Equals(user.Password));
        //         if (tempUser != null)
        //         {
        //             rModel.Result = "Token ...";
        //         }
        //         else
        //         {
        //             rModel.Message = "Kullanıcı adı veya parola hatalı";
        //             rModel.OpCode = 0;
        //         }
        //     }
        //     catch (Exception e)
        //     {
        //         rModel.Message = e.Message;
        //         rModel.OpCode = -1;
        //     }
        //
        //     return rModel;
        // }
        //
        // // POST api/user
        // [HttpPut("signup")]
        // public ResponseModel Put(Users user)
        // {
        //     if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
        //     {
        //         return new ResponseModel
        //         {
        //             Message = "Kullanıcı adı veya parola boş olamaz",
        //             OpCode = 0
        //         };
        //     }
        //
        //     var rModel = new ResponseModel
        //     {
        //         Message = "Başarılı",
        //         OpCode = 1
        //     };
        //
        //     try
        //     {
        //         var tempUser = DbConnection.Instance.Connection
        //             .Table<Users>().FirstOrDefault(x =>
        //                 x.Username.Equals(user.Username));
        //         if (tempUser == null)
        //         {
        //             rModel.Result = DbConnection.Instance.Connection.Insert(user);
        //         }
        //         else
        //         {
        //             rModel.OpCode = 0;
        //             rModel.Message = "Kullanıcı zaten var";
        //         }
        //     }
        //     catch (Exception e)
        //     {
        //         rModel.Message = e.Message;
        //         rModel.OpCode = -1;
        //     }
        //
        //     return rModel;
        // }
    }
}