using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    //about
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "69-99205-5302";
        }
        public string Address()
        {
            return "Brasil";
        }
    }
}
