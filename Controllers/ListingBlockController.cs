using Bysoft.Optimizely.Models.Blocks;
using Bysoft.Optimizely.Models.ViewModels;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bysoft.Optimizely.Controllers
{
    public class ListingBlockController : BlockController<ListingBlock>
    {
        public override ActionResult Index(ListingBlock block)
        {
            var viewmodel = new ListingBlockViewModel 
            {
               Heading = block.Heading
            };

            if (!PageReference.IsNullOrEmpty(block.Parent)) 
            {
             
            }


            return PartialView(block);
        }
    }
}