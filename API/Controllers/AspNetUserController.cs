using DAL.FabricDesign.edmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.Repository.Interface;
using DAL.Repository.Service;
using DAL.Responses;

namespace API.Controllers
{
    [RoutePrefix("api/FabricDesign")]
    public class AspNetUserController : ApiController
    {
       IAspNetUsersRepository obj = new UserRepository();

        [HttpPost]
        [Route("CreateUser")]

        public HttpResponseMessage CreateUser(AspNetUser user)
        {
            var result = obj.CreateUser(user);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("GetUsersThroughSP")]
        //public HttpResponseMessage GetAspNetUser()
        //{
        //    var result = obj.GetAspNetUser();
        //    return Request.CreateResponse(HttpStatusCode.OK, result);
        //}
        public HttpResponseMessage GetUsersThroughSP()
        {
            var result = obj.GetUsersThroughSP();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        //[HttpPost]
        //[Route("AddUpdateUsers")]

        [HttpGet]
        [Route("GetLookkupSP")]

        public HttpResponseMessage GetLookkupSP()
        {
            var result = obj.GetLookkupSP();
            return Request.CreateResponse(HttpStatusCode.OK,result);
        }

        [HttpPost]
        [Route("AddUpdateLookup")]
        public HttpResponseMessage AddUpdateLookup(LookUp lookup)
        {
            var result = obj.AddUpdateLookup(lookup);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("GetFactoryList")]

        public HttpResponseMessage GetFactoryLists()
        {
            var result = obj.GetFactoryLists();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("GetTypeCdDmt")]
        public HttpResponseMessage GetTypeCdDmt()
        {
            var result = obj.GetTypeCdDmt();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpDelete]
        [Route("Deleteuser")]

        public HttpResponseMessage Deleteuser(string id)
        {
            var result = obj.Deleteuser( id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }


    }
}
