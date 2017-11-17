using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LicensePlates.Models;
using LicensePlates.Repositories;


namespace LicensePlates.Controllers
{
    public class LicensePlatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
