using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.Repository.Interface;
using DAL.Repository.Service;
using DAL.FabricDesign.edmx;

namespace API.Controllers
{
    [RoutePrefix("api/FabricDesign")]
    public class StyleMasterController : ApiController
    {
        IStyleMasterRepository obj = new StyleMasterRepository();

        [HttpPost]
        [Route("Addupdatestylemaster")]

        public HttpResponseMessage Addupdatestylemaster(StyleMaster style)
        {
            var result = obj.Addupdatestylemaster( style);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }


        [HttpPut]
        [Route("updatestylemaster")]

        public HttpResponseMessage updatestylemaster(StyleMaster style)
        {
            var result = obj.Addupdatestylemaster(style);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }




        [HttpGet]
        [Route("GetStyleMaster")]

        public HttpResponseMessage GetStyleMaster()
        {
            var result = obj.GetStyleMaster();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("Getwithid")]

        public HttpResponseMessage Getwithid(int id)
        {
            var result = obj.Getwithid(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("GetwithidTypecddmt")]
        public HttpResponseMessage GetwithidTypecddmt(int id)
        {
            var result = obj.GetwithidTypecddmt(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }


        [HttpGet]
        [Route("Getseasonwithid")]
        public HttpResponseMessage Getseasonwithid(int id)
        {
            var result = obj.Getseasonwithid(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("Getgarmenttypewithid")]
        public HttpResponseMessage Getgarmenttypewithid(int id)
        {
            var result = obj.Getgarmenttypewithid(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    
        [HttpGet]
        [Route("Garmentprocesswithid")]
        public HttpResponseMessage Garmentprocesswithid(int id)
        {
            var result = obj.Garmentprocesswithid(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }


        [HttpGet]
        [Route("GetSampletypewithid")]
        public HttpResponseMessage GetSampletypewithid(int id)
        {
            var result = obj.GetSampletypewithid(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("GetOrdertypewithid")]
        public HttpResponseMessage GetOrdertypewithid(int id)
        {
            var result = obj.GetOrdertypewithid(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }


        [HttpDelete]
        [Route("DeletStyleMaster")]
        public HttpResponseMessage DeletStyleMaster(int id)
        {
            var result = obj.DeletStyleMaster(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}

