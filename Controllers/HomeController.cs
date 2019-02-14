using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;
using NetMVCApp.Models;

namespace NetMVCApp.Controllers {
    public class HomeController : Controller {
        public IActionResult Index () {
            return View ();
        }

        public async Task<IActionResult> NodeReport ([FromServices] INodeServices nodeServices) {
            var result = await nodeServices.InvokeAsync<Stream> ("report.js");
            return File (result, "application/pdf");

        }
        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}