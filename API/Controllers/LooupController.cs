using DAL.FabricDesign.edmx;
using DAL.Repository.Interface;
using DAL.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class LooupController : ApiController
    {
        ILookUP obj = new LookupRepository();

        [HttpPost]
        [Route("AddUpdateLookup")]

        public HttpResponseMessage AddUpdateLookup(LookUp lookup)
        {
            var result = obj.AddUpdateLookup(lookup);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPut]
        [Route("UpdateLookup")]

        public HttpResponseMessage UpdateLookup(LookUp lookup)
        {
            var result = obj.AddUpdateLookup(lookup);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("GetLookup")]

        public HttpResponseMessage GetLookup()
        {
            var result = obj.GetLookup();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpDelete]
        [Route("Deletelookup")]

        public HttpResponseMessage Deletelookup(int id)
        {
            var result = obj.Deletelookup(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }


        


        [HttpGet]
        [Route("GetCountry")]

        public HttpResponseMessage GetCountry()
        {
            var result = obj.GetCountry();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }


        [HttpPost]
        [Route("AddUpdateCountry")]

        public HttpResponseMessage AddUpdateCountry(CountryCurrency country)
        {
            var result = obj.AddUpdateCountry(country);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPut]
        [Route("UpdateCountry")]

        public HttpResponseMessage UpdateCountry(CountryCurrency country)
        {
            var result = obj.AddUpdateCountry(country);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }



        [HttpDelete]
        [Route("DeleteCountry")]

        public HttpResponseMessage DeleteCountry(int id)
        {
            var result = obj.DeleteCountry(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        //for staes

        [HttpGet]
        [Route("GetState")]

        public HttpResponseMessage GetState()
        {
            var result = obj.GetState();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }



        [HttpPost]
        [Route("AddUpdateState")]

        public HttpResponseMessage AddUpdateState(StateMaster state)
        {
            var result = obj.AddUpdateState(state);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }


        [HttpPut]
        [Route("UpdateStatedata")]

        public HttpResponseMessage UpdateStatedata(StateMaster state)
        {
            var result = obj.AddUpdateState(state);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }



        [HttpDelete]
        [Route("DeleteState")]

        public HttpResponseMessage DeleteState(int id)
        {
            var result = obj.DeleteState(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
