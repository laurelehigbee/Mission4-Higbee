using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4_Higbee.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_Higbee.Controllers
{
    public class HomeController : Controller //controller creation
    {
        private readonly ILogger<HomeController> _logger;
        private Context _aVarName { get; set; } //connects to the context model

        public HomeController(ILogger<HomeController> logger, Context randomName) 
            //information to connect to the database, context model
        {
            _logger = logger;
            _aVarName = randomName;
        }

        public IActionResult Index() //return view for index page
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddMovies() //get response for add movies web page
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(MovieResponse mr) //post response for add movies
        {
            _aVarName.Add(mr); //adds the information into the response
            _aVarName.SaveChanges(); //saves the changes to the database
            return View("Confirmation",mr); //returns the confirmation view, movie response info saved
        }

        public IActionResult PodcastInfo() //return view for podcast info page
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() //return view for if there's an error
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
