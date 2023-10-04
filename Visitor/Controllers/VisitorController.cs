using Microsoft.AspNetCore.Mvc;
using Visitor.Model;
using Visitor.Service;

namespace Visitor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VisitorController : Controller
    {
       
       public IVisitService VisitService { get; set; }
        public VisitorController(IVisitService visitService) {
            visitService = visitService;
        }

        [HttpPost]
        public void AddVisitor(Visit visit)
        {
            VisitService.AddVisitor(visit);
        }
        
        [HttpGet]
        public List<Visit> GetVisitor()
      {
            return VisitService.visit();

        }



    }
}
