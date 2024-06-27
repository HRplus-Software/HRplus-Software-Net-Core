using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly WebAppDBContext _context;

        public IndexModel(ILogger<IndexModel> logger, WebAppDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

        }

        public JsonResult? OnGetSiteObjects(string filterValue)
        {
            IList<SiteObject> siteObjects;
            if (filterValue == null)
            {
                siteObjects = (from siteobjects in _context.SiteObjects select siteobjects).ToList();
            }
            else
            {
                siteObjects = (from siteobjects in _context.SiteObjects.Where(filter => EF.Functions.Like(filter.SiteObjectName, "%" + filterValue + "%")) select siteobjects).ToList();
            }
            return new JsonResult(siteObjects);

        }
    }
}
