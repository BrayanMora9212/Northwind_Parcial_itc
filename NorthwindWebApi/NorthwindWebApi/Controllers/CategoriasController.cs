using NorthwindWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NorthwindWebApi.Controllers
{
    public class CategoriasController : ApiController
    {
        [HttpGet]
        [Route("api/categorias/consultar")]
        public List<Categories> consultarCategorias()
        {
            using (var cnn = new NorthwindEntities())
            {
                return cnn.Categories.ToList();
            }
        }
           

    }
}
