using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_study.Controllers
{
    public class ReturnTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region :: Status Code Results ::

        /// <summary>
        /// This is a StatusCodeResult. When executed, it will produce an empty 'Status 200 OK' response.
        /// </summary>
        /// <returns></returns>
        public IActionResult OkResult()
        {
            return Ok();
        }

        public IActionResult CreatedResult()
        {
            return Created("example.org/myitem", new { name = "newItem" });
        }
        /// <summary>
        /// Returns a 204 status code, which is when there is no content.
        /// </summary>
        /// <returns></returns>
        public IActionResult NoContentResult()
        {
            return NoContent();
        }
        /// <summary>
        /// Returns a error 400. Indicates a bad request from the user.
        /// </summary>
        /// <returns></returns>
        public IActionResult BadRequestResult()
        {
            return BadRequest();
        }
        /// <summary>
        /// Returns a error 401.
        /// </summary>
        /// <returns></returns>
        public IActionResult UnauthorizedResult()
        {
            return Unauthorized();
        }
        #endregion
    }
}
 