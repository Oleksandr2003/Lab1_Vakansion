using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vacancy.Repository.Repositories;
using Vakansion.Models;

namespace Vakansion.Controllers
{
    public class EmployerController:Controller
    {
        private readonly ILogger<EmployerController> _logger;
        private readonly EmployerRepository _employerRepository;
        public EmployerController(ILogger<EmployerController> logger, EmployerRepository employerRepository)
        {
            _logger = logger;
            _employerRepository = employerRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _employerRepository.GetEmployerAsync());
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
