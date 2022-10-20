using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vacancy.Repository.Repositories;
using Vakansion.Models;

namespace Vakansion.Controllers
{
    public class PositionController:Controller
    {
        private readonly ILogger<PositionController> _logger;
        private readonly PositionRepository _positionRepository;
        public PositionController(ILogger<PositionController> logger, PositionRepository positionRepository)
        {
            _logger = logger;
            _positionRepository = positionRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _positionRepository.GetPositiinAsync());
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

