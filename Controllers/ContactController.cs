using Microsoft.AspNetCore.Mvc;
using davetiyemiz.Models;

namespace davetiyemiz.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                // Burada veriyi işleyebiliriz.
                // Örneğin: Veritabanına kaydet, email gönder, vs.
                ViewBag.Message = "Mesajınız alındı, teşekkür ederiz!";
                ModelState.Clear();
                return View();
            }

            return View(contact);
        }
    }
}
