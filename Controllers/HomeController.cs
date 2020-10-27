using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserOwnsData.Models;
using UserOwnsData.Services;

namespace UserOwnsData.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {

        private PowerBiServiceApi powerBiServiceApi;

        public HomeController(PowerBiServiceApi powerBiServiceApi)
        {
            this.powerBiServiceApi = powerBiServiceApi;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Embed()
        {

            // Guid workspaceId = new Guid("d0f37274-fdc6-4a3b-a10c-e10ea41b07ea");
            // Guid reportId = new Guid("77309bbf-d545-4faf-928f-a5b2037ac436");

            // var viewModel = await powerBiServiceApi.GetReport(workspaceId, reportId);
            return View();

        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}