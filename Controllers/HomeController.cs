using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CES2022_Telestar.Models;

namespace CES2022_Telestar.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public String Index(InputRequest input)
        {
            return input.startPoint;
        }
    }
}
