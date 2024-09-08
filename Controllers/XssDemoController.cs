using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebscrapingFront.Controllers
{
    public class XssDemoController : Controller
    {
        // List to simulate a simple in-memory database for stored XSS
        private static List<string> comments = new List<string>();

        // GET: XssDemo/Reflected
        public IActionResult Reflected(string input)
        {
            // Intentionally vulnerable to Reflected XSS
            ViewBag.Input = input;
            return View();
        }

        // GET: XssDemo/Stored
        public IActionResult Stored()
        {
            // Display the list of comments
            ViewBag.Comments = comments;
            return View();
        }

        // POST: XssDemo/StoreComment
        [HttpPost]
        public IActionResult StoreComment(string comment)
        {
            // Store the comment (vulnerable to stored XSS)
            comments.Add(comment);
            return RedirectToAction("Stored");
        }

        // GET: XssDemo/DomBased
        public IActionResult DomBased()
        {
            return View();
        }
    }
}