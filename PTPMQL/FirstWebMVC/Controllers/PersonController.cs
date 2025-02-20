using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
        // GET: /Person/
        public IActionResult Index()
        {
            return View();
        } 
        // GET: /Person/Welcome/ 

        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string str0utput = "Xin Chào: " + ps.PersonId + "-" + ps.FullName + "-" + ps.Address;
            ViewBag.infoPerson = str0utput;
            return View();
        }
    }
}