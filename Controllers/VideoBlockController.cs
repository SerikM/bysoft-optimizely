using Bysoft.Optimizely.Models.Blocks;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bysoft.Optimizely.Controllers
{
    public class VideoBlockController : BlockController<VideoBlock>
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}