using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud
{
    public class HomeController : Controller
    {
        public string index()
        {
            return "Hello index";
        }
        
    }
}
