using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BL_Core.Controllers;
using BL_Core.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentDB objDB = new StudentDB();
            var students = objDB.GetDetail().OrderBy(i => i.Id);
            return View(students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            StudentDB objDB = new StudentDB();
            var student = objDB.GetDetail().Where(i => i.Id == id).FirstOrDefault();
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Student objstudent = new Student();
                objstudent.Id = int.Parse(collection["Id"]);
                objstudent.Name = collection["Name"];
                objstudent.RollNo = int.Parse(collection["RollNo"]);

                StudentDB objDB = new StudentDB();
                var students = objDB.InsertValues(objstudent.Id,objstudent.Name,objstudent.RollNo);

                // TODO: Add insert logic here

                    return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View(ex);
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}