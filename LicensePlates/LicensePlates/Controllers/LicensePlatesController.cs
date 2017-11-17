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
        public IEnumerable<LicensePlate> ListPosts()
        {
            return LicensePlatesRepository.ListPosts();
        }
    }
}
