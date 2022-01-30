using Microsoft.AspNetCore.Mvc;

namespace TicketSystemDemo.Controllers
{
    public class IssueController : Controller
    {
        public IssueController()
        {

        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}