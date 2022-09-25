using Microsoft.AspNetCore.Mvc;

namespace MVCApp_Basic.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Welcome to home controller";
        }
    }
}
