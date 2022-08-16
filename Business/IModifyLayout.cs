using Bysoft.Optimizely.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bysoft.Optimizely.Business
{
    interface IModifyLayout
    {
        void ModifyLayout(LayoutModel layoutModel);
    }
}