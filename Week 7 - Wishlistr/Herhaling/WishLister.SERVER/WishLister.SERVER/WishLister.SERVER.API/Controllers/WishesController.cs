using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wishlistr.API.Models;
using Wishlistr.API.Respositories;
using Wishlistr.API.Respositories.core;

namespace Wishlistr.API.Controllers
{
    public class WishesController : ApiController
    {
        private readonly IRepository<Wish> repo;

        public WishesController()
        {
            repo = new SqlRepository();
        }
     
        [HttpGet]
        public IEnumerable<Wish> Get() {
            return repo.GetAll();
        }

        [HttpPut]
        public void Put([FromBody]Wish w) {
            repo.Add(w);
        }

    }
}
