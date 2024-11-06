using KiemTraLan2.Models;
using Microsoft.AspNetCore.Mvc;

namespace KiemTraLan2.ViewComponents
{
    public class NgonNguViewComponent : ViewComponent
    {
        QlthuVienContext db = new QlthuVienContext();
        public IViewComponentResult Invoke()
        {
            var tenNgonNgu = db.TNgonNgus.ToList();
            return View("Default", tenNgonNgu);
        }
    }
}
