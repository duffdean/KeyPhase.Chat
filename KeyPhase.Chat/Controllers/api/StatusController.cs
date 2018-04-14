using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KeyPhase.Chat.Controllers.api
{
    public class StatusController : ApiController
    {
        [System.Web.Mvc.AcceptVerbs("GET")]
        [System.Web.Mvc.HttpGet]
        public bool IsAlive()
        {
            return true;
        }
    }
}
