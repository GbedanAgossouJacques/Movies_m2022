using Microsoft.AspNetCore.Mvc;

namespace Movies_m2022.Controllers
{
    public class MoviesController1 : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }


        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
