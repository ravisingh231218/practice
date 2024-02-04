using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using practice.Data;
using practice.Models;
using System.ComponentModel.DataAnnotations;

namespace practice.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationContext context;

        public AccountController(ApplicationContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var result = context.users.ToList();

            return View(result);
        }
       public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                var emp = new User()
                {
                    Name = model.Name,
                    Gender = model.Gender,
                    Email = model.Email,
                    Password = model.Password

                };
                context.users.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Index");
               
            }
            else
            {
                TempData["error"] = "Empty field can't submit";
                return View(model);
            }    
               
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
