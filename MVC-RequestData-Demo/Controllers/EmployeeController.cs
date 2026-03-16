using System.Web.Mvc;
using MVC_RequestData_Demo.Models;

namespace MVC_RequestData_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // Home page for all examples
        public ActionResult Index()
        {
            return View();
        }

        // ----------------------------
        // 1. FORM DATA EXAMPLE
        // ----------------------------

        [HttpGet]
        public ActionResult FormExample()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormExample(Employee employee)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Form Data Received Successfully";
                return View(employee);
            }

            return View(employee);
        }

        // ----------------------------
        // 2. QUERY STRING EXAMPLE
        // URL: /Employee/QueryExample?id=10
        // ----------------------------

        public ActionResult QueryExample(int id)
        {
            return Content("Query String Example - Employee Id: " + id);
        }

        // ----------------------------
        // 3. ROUTE DATA EXAMPLE
        // URL: /Employee/RouteExample/5
        // ----------------------------

        public ActionResult RouteExample(int id)
        {
            return Content("Route Data Example - Employee Id: " + id);
        }

        // ----------------------------
        // 4. JSON BODY EXAMPLE
        // ----------------------------

        [HttpGet]
        public ActionResult JsonExample()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CreateJson(Employee employee)
        {
            return Json(new
            {
                message = "JSON Data Received Successfully",
                firstName = employee.FirstName,
                email = employee.Email,
                department = employee.Department
            });
        }
    }
}