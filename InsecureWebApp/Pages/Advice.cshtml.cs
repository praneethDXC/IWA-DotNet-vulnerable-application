using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MicroFocus.InsecureWebApp.Pages
{
    public class AdviceModel : PageModel
    {
        private readonly ILogger<AdviceModel> _logger;

        public AdviceModel(ILogger<AdviceModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
