using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using WEB.Models;

namespace WEB.Controllers
{
    public class TeacherDepartmentController : Controller
    {
        private readonly ITeacherInfoService info;
        private readonly ITeacherService service;

        public TeacherDepartmentController(ITeacherService teach, ITeacherInfoService inf)
        {
            info = inf;
            service = teach;
        }

        [Route("AddTeacherInfo")]
        public IActionResult Teacher()
        {
            return View("~/Views/TeacherDepartment/AddTeacherInfo.cshtml");
        }

        [Route("HomeKadry")]
        public IActionResult IndexT()
        {
            return View("~/Views/ShtatKadriv/Home.cshtml");
        }


        [HttpPost]
        public async Task<IActionResult> AddTeacherInfo(StudentInfoViewModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    StudentInfoDTO studentInfoDTO = new StudentInfoDTO()
            //    {
            //        studentName = model.studentName,
            //        studentMiddleName = model.studentMiddleName,
            //        studentLastName = model.studentLastName,
            //        studentSex = model.studentSex,
            //        bday = model.bday,
            //        phone = model.phone,
            //        homeAddress = model.homeAddress,
            //        email = model.email,
            //        StudentFirstParentName = model.StudentFirstParentName,
            //        StudentFirstParentPhone = model.StudentFirstParentPhone,
            //        StudentSecondParentName = model.StudentSecondParentName,
            //        StudentSecondParentPhone = model.StudentSecondParentPhone
            //    };
            //    if (studentInfo.FindStudentInfo(model.studentName, model.studentLastName, model.bday, model.phone) == null)
            //    {
            //        await studentInfo.CreateStudentInfo(studentInfoDTO);
            //        return RedirectToAction("VHomeUser", "Home");
            //    }
            //    else
                    ModelState.AddModelError("Name", "Даний студент вже існує");
            //}

            return View(model);
        }

        public async Task<IActionResult> AddTeacher(TeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                TeacherDTO student = new TeacherDTO()
                {
                    
                };
                //if (model.FindTeacher(Convert.ToString(model.studentInfo)) == null)
                //{
                //    await studen.CreateStudent(student);
                //    return RedirectToAction("VHomeUser", "Home");
                //}
                //else
                    ModelState.AddModelError("Name", "Даний студент вже існує");
            }

            return View(model);
        }
    }
}