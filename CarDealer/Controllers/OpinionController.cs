using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{
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
    }
}