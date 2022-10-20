using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vacancy.Repository.Repositories;
using Vakansion.Models;

namespace Vakansion.Controllers
{
    public class UnemployedController:Controller
    {
        private readonly ILogger<UnemployedController> _logger;
        private readonly UnemployedRepository _unemployedRepository;
        public UnemployedController(ILogger<UnemployedController> logger, UnemployedRepository unemployedRepository)
        {
            _logger = logger;
            _unemployedRepository = unemployedRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _unemployedRepository.GetUnemployedAsync());
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }

}

