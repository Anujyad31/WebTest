using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Context;

namespace WebTest.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        db_testEntities dbObj = new db_testEntities();
        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(tbl_student model)
        {
            tbl_student obj = new tbl_student();
            obj.Name = model.Name;
            obj.Email = model.Email;
            obj.Address = model.Address;


            dbObj.tbl_student.Add(obj);
            dbObj.SaveChanges();


            return View("Student");

        }

    }
}