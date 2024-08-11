using B05ASPC02_w01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B05ASPC02_w01.Controllers
{
    public class StudentsController : Controller
    {
        //coupling(tightly coupled,loosly coupled),cohesion
        StudentContext db = new StudentContext();

        // GET: Students
        public ActionResult Index()
        {
            var students = db.Students.ToList();
            return View(students);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            db.Students.Add(student);
          if(  db.SaveChanges()>0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
           var student= db.Students.Find(id);

            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            
            db.Entry(student).State= System.Data.Entity.EntityState.Modified;
            if (db.SaveChanges() > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var student = db.Students.Find(id);
            db.Students.Remove(student);
            if (db.SaveChanges() > 0)
            {
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}