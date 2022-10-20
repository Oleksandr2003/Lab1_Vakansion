using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vacancy.Repository.Repositories;
using Vakansion.Models;
using Vakansion.UI.Controllers;

namespace Vakansion.Controllers
{
    public class EducationController:Controller
    {
        private readonly ILogger<EducationController> _logger;
        private readonly EducationRepository _educationRepository;
        public EducationController(ILogger<EducationController> logger, EducationRepository educationRepository)
        {
            _logger = logger;
            _educationRepository = educationRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _educationRepository.GetEducationAsync());
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

