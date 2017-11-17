using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LicensePlates.Models;
using LicensePlates.Repositories;


namespace LicensePlates.Controllers
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
