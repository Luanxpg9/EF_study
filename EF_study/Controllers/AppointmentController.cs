using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_study.Controllers
{
    public class AppointmentController : Controller
    {
        /// <summary>
        /// This method is used to return appointments scheduled
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return new JsonResult("Hi");
        }

        public IActionResult Details(int id)
        {
            return Ok("You have entered = {id} " + id);
        }
    }
}
