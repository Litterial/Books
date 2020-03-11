using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookApp.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class SouthDistrictController : Controller
    {
     
        public string Hello ()
        {
            return "Hello";
        }
    }
}
