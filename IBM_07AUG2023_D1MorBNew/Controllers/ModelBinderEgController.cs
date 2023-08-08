using Microsoft.AspNetCore.Mvc;

namespace IBM_07AUG2023_D1MorBNew.Controllers
{
    public class ModelBinderEgController : Controller
    {
        public IActionResult Default(int id, string EmpName)
        {
            return Content($"by-Default: {id}");
        }

        // Bind: query  
        public IActionResult UsingQuery([FromQuery] int id)
        {
            return Content($"by-Query: {id}");
        }

        // Bind: form  
        public IActionResult UsingForm([FromForm] int id)
        {
            return Content($"by-Form: {id}");
        }

        // Bind:  
        public IActionResult FromBodyWithoutModel([FromBody] int id)
        {
            return Content($"From-Body-Primitive: {id}");
        }

        // Bind: body  
        public IActionResult FromBodyWithModel([FromBody] Models.Employee model)
        {
            return Content($"From-Body-Model: {model.EmpID}");
        }


        // Bind: header  
        public IActionResult UsingFromHeader(
            [FromHeader] string host,
            [FromHeader(Name = "User-Agent")] string userAgent)
        {
            return Content($"From-Header: {host}, {userAgent}");
        }


    }
}
