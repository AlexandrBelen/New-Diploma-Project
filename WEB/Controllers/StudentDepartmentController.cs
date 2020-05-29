using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using BLL.DTO;
using BLL.Infrastructure;
using BLL.Interfaces;
using WEB.Models;
using Microsoft.Extensions.Logging;
using BLL.Services;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WEB.Views.StudentShtat;
using Microsoft.AspNetCore.Mvc.Rendering;
using DAL.Entities;

namespace WEB.Controllers
{
    public class StudentDepartmentController : Controller
    {
        private IEducationalDegreeService educDegree;
        private IStudentInfoService studentInfo;
        private IStudentService studen;
        private IGruppaService gruppaService;
        private readonly IFormEducationService educFormService;
        private ICathedraService cathedra;
        private IStudentService starosta;
        private ITeacherService curator;

        public StudentDepartmentController(IStudentInfoService inf, IStudentService st, IEducationalDegreeService educ, IGruppaService gr, IFormEducationService efs,
            ICathedraService cs, IStudentService ss, ITeacherService ts)
        {
            studentInfo = inf;
            studen = st;
            educDegree = educ;
            gruppaService = gr;
            educFormService = efs;
            cathedra = cs;
            starosta = ss;
            curator = ts;
        }
        [Route("AddStudentInfo")]
        public IActionResult StudentInfo()
        {
            return View("~/Views/StudentDepartment/StudentInfo/AddStudentInfo.cshtml");
        }
        #region Student
        [HttpPost]
        public async Task<IActionResult> AddStudentInfo(StudentInfoViewModel model)
        {
            if (model.StudentSecondParentName == "") model.StudentSecondParentName = null;
            if (model.StudentSecondParentPhone == "") model.StudentSecondParentPhone = null;
            if (ModelState.IsValid)
            {
                StudentInfoDTO studentInfoDTO = new StudentInfoDTO()
                {
                    studentName = model.studentName,
                    studentMiddleName = model.studentMiddleName,
                    studentLastName = model.studentLastName,
                    studentSex = model.studentSex,
                    bday = model.bday,
                    phone = model.phone,
                    homeAddress = model.homeAddress,
                    email = model.email,
                    StudentFirstParentName = model.StudentFirstParentName,
                    StudentFirstParentPhone = model.StudentFirstParentPhone,
                    StudentSecondParentName = model.StudentSecondParentName,
                    StudentSecondParentPhone = model.StudentSecondParentPhone
                };
                if(studentInfo.FindStudentInfo(model.studentName, model.studentLastName, model.bday, model.phone) == null)
                {
                    await studentInfo.CreateStudentInfo(studentInfoDTO);
                    return RedirectToAction("StudentDepartment", "Home");
                }
                else
                    ModelState.AddModelError("Name", "Даний студент вже існує");
            }

            return View(model);
        }

        public async Task<IActionResult> AddStudent(StudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                StudentDTO student = new StudentDTO()
                {
                    gruppa = model.gruppa,
                    speciality = model.speciality,
                    cathedra = model.cathedra,
                    year = model.year,
                    faculty = model.faculty,
                    educationProgram = model.educationProgram,
                    studentInfo = model.studentInfo
                };
                if (studen.FindStudent(Convert.ToString(model.studentInfo)) == null)
                {
                    await studen.CreateStudent(student);
                    return RedirectToAction("VHomeUser", "Home");
                }
                else
                    ModelState.AddModelError("Name", "Даний студент вже існує");
            }

            return View(model);
        }
        #endregion

        [Route("StudentDepartment")]
        public IActionResult VHome()
        {
            return View("~/Views/StudentDepartment/Home.cshtml");
        }

        #region Gruppa
        //public IActionResult GetGruppa()
        //{
        //    Gruppa gruppa = new Gruppa();
        //}

        public IActionResult AddGruppa()
        {
            AddGruppa model = new AddGruppa();
            model.newList = educDegree.GetAll().Select(p => new SelectListItem { Value = p.EducationalDegreeName, Text = p.EducationalDegreeName }).ToList();
            model.newListCathedra = cathedra.GetAll().Select(p => new SelectListItem { Value = p.cathedraName, Text = p.cathedraName }).ToList();
            //model.newListCurator = curator.GetAll().Select(p => new SelectListItem { Value, Text = p.cathedraNameDTO }).ToList();
            //model.newListStarosta = starosta.GetAll().Select(p => new SelectListItem { Value = p.cathedraNameDTO, Text = p.cathedraNameDTO }).ToList();
            model.newListEducation = educFormService.GetAll().Select(p => new SelectListItem { Value = p.FormEducationName, Text = p.FormEducationName }).ToList();
            return View("~/Views/StudentDepartment/Gruppa/AddGruppa.cshtml", model);
        }

        public async Task<IActionResult> CreateNewGruppa(AddGruppa model)
        {
            GruppaDTO gruppaDTO = new GruppaDTO()
            {
                name = model.Name,
                //id_starosta = model.Starosta,
                curator = model.Curator,
                cathedra = model.Cathedra,
                year = model.Year,
                education = model.Education,
                educDegreeDTO = model.EducLevel
            };
            await gruppaService.CreateGruppa(gruppaDTO);
            return RedirectToAction("GetGruppa", "StudentShtat");
        }
        #endregion
    }
}