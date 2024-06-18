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
    public class BuyerController : ApiController
    {
        IBuyer obj = new BuyerRepository();


        [HttpGet]
        [Route("GetBuyerList")]

        public HttpResponseMessage GetBuyerList()
        {
            var result = obj.GetBuyerList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }



        [HttpPost]
        [Route("AddupdateBuyer")]

        public HttpResponseMessage AddupdateBuyer(Buyer buyer)
        {
            var result = obj.AddupdateBuyer(buyer);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPut]
        [Route("updateBuyer")]

        public HttpResponseMessage updateBuyer(Buyer buyer)
        {
            var result = obj.AddupdateBuyer(buyer);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
        [HttpDelete]
        [Route("DeleteBuyer")]

        public HttpResponseMessage DeleteBuyer(int id)
        {
            var result = obj.DeleteBuyer(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
