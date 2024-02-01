using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NSPS.WebUI.Pages
{
    public class CRUD_DB_View : PageModel
    {
        private readonly ILogger<CRUD_DB_View> _logger;

        public CRUD_DB_View(ILogger<CRUD_DB_View> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //string connectionString = "";
        }
    }
}