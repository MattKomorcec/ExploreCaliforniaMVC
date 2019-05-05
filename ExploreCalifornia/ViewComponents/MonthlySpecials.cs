using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.ViewComponents
{
    public class MonthlySpecials : ViewComponent
    {
        private readonly BlogDataContext _db;

        public MonthlySpecials(BlogDataContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var specials = _db.MonthlySpecials;
            return View(specials);
        }
    }
}
