using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class Default : ControllerBase
    {
        public string Index()
        {
            return "Reading Identity . . .";
        }
    }
}
