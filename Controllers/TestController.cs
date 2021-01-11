using Microsoft.AspNetCore.Mvc;
using webProject.Model;
using System.Collections.Generic;
namespace webProject.Controllers
{
    public class TestController:Controller{
        public IActionResult Index(){
            IList<string> items=new List<string>();
            items.Add("Imad");
            items.Add("Mohamed");
            items.Add("Hamza");
            items.Add("Hajar");
            ViewData["email"]="imad@taoufiq.ma";
            ViewBag.contact="imad taoufiq";
            return View(items);
        }
        public IActionResult List(){
            IList<Student> students=new List<Student>();
            students.Add(new Student{Id=1,Name="Imad",Score=60});
            students.Add(new Student{Id=2,Name="Mohamed",Score=39});
            students.Add(new Student{Id=3,Name="Hamza",Score=100});
            return View(students);
        }
        public IActionResult A(){
            return View();
        }
        public IActionResult B(){
            return View("BB");
        }
    }
}