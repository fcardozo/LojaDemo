using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LojaDemo.RestApi.Controllers
{
    public class ProductController : ApiController
    {
        /// <summary>
        /// Get the project by ID.
        /// </summary>
        /// <param name="id">ID of the product need to consult.</param>
        /// <returns>Return product wthi ID found.</returns>
        [HttpGet()]
        public string GetById(string id)
        {
            return "Teste retorno produto";
        }
    }
}
