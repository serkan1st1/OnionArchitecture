using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Presentatiton.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Presentatiton.Controller
{
    public class CompanyController : ApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return NoContent();
        }
    }
}
