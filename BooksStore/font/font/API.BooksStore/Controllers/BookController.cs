using API.BooksStore.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.BooksStore.Controllers
{

    /***************************************************
     * @Project:      BooksStore
     * @Structure:    API
     * @Title:        BookController
     * @Description:  Controle de requisição de 
     *                Livros.
     * @Author:       Rnaldo Torre
     * ------------------------------------------------
     ***************************************************/

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/book")]
    public class BookController : ApiController
    {
        protected BookManager bookManager = new BookManager();

        //Get all books 
        public ICollection<Book> GetByAll()
        {
            return bookManager.GetAll();
        }

        //Get book by id
        [Route("id/{id}")]
        public Book GetByCode(int id)
        {
            return bookManager.GetById(id);
        }

        //Get book by name
        [Route("name/{name}")]
        public Book GetByName(string name)
        {
            return bookManager.GetByName(name);
        }

        // Get book by parameter (name)
        [Route("param/{name}")]
        public ICollection<Book> GetByParameter(string name)
        {
            return bookManager.GetByParameter(name);
        }

        //Post new book
        [HttpPost]
        public HttpResponseMessage PostBook(Book book)
        {
            if (bookManager.Insert(book) == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Insert OK");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error in Insert");
            }
        }

        //Put in existing book
        [HttpPut]
        public HttpResponseMessage PutBook(Book book)
        {
            if (bookManager.Update(book) == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Update OK");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error in Update");
            }
        }

        //Delete existing book
        [HttpDelete]
        public HttpResponseMessage DeleteBook(Book book)
        {
            if (bookManager.Delete(book) == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Delete OK");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error in Delete");
            }
        }

    }
}