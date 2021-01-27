using Microsoft.AspNetCore.Mvc;
using UnityAPI.Models;
using UnityAPI.REST.Managers;
using UnityAPI.REST.Services;

namespace UnityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : BaseController<Books>
    {
        //BookManager manager;
        public BooksController() : base(new BookManager(new BookService()))
        {
        }
    }
}