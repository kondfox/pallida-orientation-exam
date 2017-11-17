using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using title.Models;
using title.Repositories;


namespace title.Controllers
{
    public class LicensePlatesController : Controller
    {
        LicensePlatesRepository LicensePlatesRepository;

        public LicensePlatesController(LicensePlatesRepository licensePlatesRepository)
        {
            LicensePlatesRepository = licensePlatesRepository;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult List() 
        {
            return View(LicensePlatesRepository.GetList());
        }

        [Route("/search/policecars")]
        [HttpPost]
        public IActionResult PoliceCars(string title)
        {
            LicensePlatesRepository.PoliceCars(title);
            return RedirectToAction("List");
        }

        [Route("/search/diplomatcars")]
        [HttpPost]
        public IActionResult DiplomatCars(string title)
        {
            LicensePlatesRepository.DiplomatCars(title);
            return RedirectToAction("List");
        }
    }

        //[HttpGet]
        //[Route("/search")]

        //[HttpGet]
        //[Route("/search/{brand}")]

        //[HttpGet]
        //[Route("/api/search/{brand}")]
        //public IActionResult BrandSearch([FromBody] BrandSearch brandSearch, string brand)
        //{

        //}

    
}
