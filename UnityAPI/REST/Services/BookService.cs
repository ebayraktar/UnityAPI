using System;
using System.Linq;
using UnityAPI.Models;

namespace UnityAPI.REST.Services
{
    public class BookService : BaseService
    {
        public override bool Post(object data, out object resultData)
        {
            try
            {
                var book = Newtonsoft.Json.JsonConvert.DeserializeObject<Books>(data.ToString());
                var lastId = Constants.Connection.Table<Books>().OrderByDescending(x => x.BookId)
                    .Select(y => y.BookId).FirstOrDefault();
                if (book != null)
                {
                    //INSERT INTO BOOK VALUES ('a', 'A','A','A')
                    lastId = int.TryParse(lastId, out var idCount) ? (++idCount).ToString() : "0";
                    resultData = book.BookId = lastId;
                    string query =
                        $"INSERT INTO books VALUES('{book.BookId}','{book.Name}','{book.PageCount}','{book.Point}','{book.AuthorId}','{book.TypeId}')";
                    Constants.Connection.CreateCommand(query);
                    return Constants.Connection.Execute(query) > 0;
                }

                resultData = "invalid argument: " + data;
                return false;
            }
            catch (Exception ex)
            {
                resultData = ex.Message;
                return false;
            }
        }

        public override bool Put(string id, object data, out object resultData)
        {
            try
            {
                var tempBook = Constants.Connection.Find<Books>(id);
                var book = Newtonsoft.Json.JsonConvert.DeserializeObject<Books>(data.ToString());
                if (book != null && tempBook != null)
                {
                    resultData = book;
                    return Constants.Connection.Update(book) > 0;
                }

                resultData = "invalid argument: " + data;
                return false;
            }
            catch (Exception ex)
            {
                resultData = ex.Message;
                return false;
            }
        }
    }
}