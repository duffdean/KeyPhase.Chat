using KeyPhase.Chat.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeyPhase.Controllers
{
    public class ChatRoomController : Controller
    {
        //
        // GET: /ChatRoom/

        public ActionResult SignalRChat(int UserID)
        {           
            return View();
        }

    }
}
