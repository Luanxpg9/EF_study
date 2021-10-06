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
        /// Returns 401 status code.
        /// </summary>
        /// <returns></returns>
        public IActionResult UnauthorizedResult()
        {
            return Unauthorized();
        }
        /// <summary>
        /// Returns an not found status code, error 404.
        /// </summary>
        /// <returns></returns>
        public IActionResult NotFoundResult()
        {
            return NotFound();
        }
        /// <summary>
        /// This action result returns 415 status code, wich means server cannot
        /// continue to precess the request with the given payload.
        /// </summary>
        /// <returns></returns>
        public IActionResult UnsupportedMediaTypeResultResult()
        {
            return new UnsupportedMediaTypeResult();
        }
        #endregion

        #region :: Status Code with Object Results ::
        /// <summary>
        /// An ObjectResult, when executed, performs content negotiation,
        /// formats the entity body, and will produce a Status 200 OK response.
        /// </summary>
        /// <returns></returns>
        public IActionResult OkObjectResult()
        {
            var result =  new OkObjectResult(
            new { message = "200 OK", currentDate = DateTime.Now }
            );
            return result;
        }
        /// <summary>
        /// Return an ObjectResult with a message with code 201 and a Location Header.
        /// </summary>
        /// <returns></returns>
        public IActionResult CreatedObjectResult()
        {
            var result = new CreatedAtActionResult(
                "createdobjectresult",
                "statuscodeobjects", 
                "",
                new { 
                    message = "201 created", 
                    currentDate = DateTime.Now 
                });
            return result;
        }
        /// <summary>
        /// Return an ObjectResult with message 400 and object containing the error
        /// </summary>
        /// <returns></returns>
        public IActionResult BadRequestObjectResult()
        {
            var result = new BadRequestObjectResult(new
            {
                message = "400 Bad Request",
                currentDate = DateTime.Now
            });
            return result;
        }
        /// <summary>
        /// Similar to NotFound(), with the aditional object in the return method.
        /// </summary>
        /// <returns></returns>
        public IActionResult NotFoundObjectResult()
        {
            var result = new NotFoundObjectResult(new
            { 
                message = "404 Not Found",
                currentDate = DateTime.Now 
            });
            return result;
        }
        #endregion
    }
}
 