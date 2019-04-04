using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Models;
using CarDealer.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{   [Authorize]
    public class OpinionController : Controller
    {
        private readonly IOpinionRepository opinionRepository;

        public OpinionController(IOpinionRepository opinionRepository)
        {
            this.opinionRepository = opinionRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Opinion opinion)
        {
            if (ModelState.IsValid)
            {
                opinionRepository.AddOpinion(opinion);
                return RedirectToAction("OpinionSent");
            }

            return View(opinion);
        }

        public IActionResult OpinionSent()
        {
            return View();
        }
    }
}