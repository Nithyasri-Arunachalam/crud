using CRUD.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class UserController : Controller
    {
        private readonly DatabaseContext _ctx;
        public UserController(DatabaseContext ctx)
        {
            _ctx = ctx;   
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddStudents()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudents(Students students)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                _ctx.StudentDetails.Add(students);
                _ctx.SaveChanges();
                TempData["msg"] = "Added Successfully";
                return RedirectToAction("AddStudents");
            }
            catch (Exception)
            {
                TempData["msg"] = "Can not be added";
                return View();
            }
        }
        public IActionResult Students()
        {
            var a = _ctx.StudentDetails.ToList();
            return View(a);
        }
        public IActionResult DeleteStudents(int id)
        {
            try
            {
                var a = _ctx.StudentDetails.Find(id);
                if (a != null)
                {
                    _ctx.StudentDetails.Remove(a);
                    _ctx.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return RedirectToAction("Students");
        }
        public IActionResult EditStudents(int id)
        {
            var a= _ctx.StudentDetails.Find(id);
            return View(a);
        }
        [HttpPost]
        public IActionResult EditStudents(Students students)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            try
            {
                _ctx.StudentDetails.Update(students);
                _ctx.SaveChanges();
                return RedirectToAction("Students");
            }
            catch(Exception)
            {
                TempData["msg"] = "Could not Updated";
                return View();      
            }
        }




    }
}
