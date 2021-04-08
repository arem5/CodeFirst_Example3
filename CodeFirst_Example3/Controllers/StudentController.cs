using CodeFirst_Example3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst_Example3.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController


        StudentDataAccessLayer dataAccessLayer;

        public StudentController()
        {
            dataAccessLayer = new StudentDataAccessLayer();
        }
        public ActionResult Index()
        {
              List<Student> students = dataAccessLayer.GetAll();
            return View(students);
        }


        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            Student student = dataAccessLayer.GetData(id);
            return View(student);
           
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                dataAccessLayer.CreateData(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            Student student = dataAccessLayer.GetData(id);
            return View(student);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            try
            {
                dataAccessLayer.UpdateData(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            Student student = dataAccessLayer.GetData(id);
            return View(student);
            
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Student student)
        {
            try
            {
                dataAccessLayer.DeleteData(student.Id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }
    }
}
