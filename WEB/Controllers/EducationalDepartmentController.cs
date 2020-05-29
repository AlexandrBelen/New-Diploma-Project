using System;
using System.Collections.Generic;
using System.Linq;
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
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using WEB.Models.EducationalDepartment;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB.Controllers
{
    public class EducationalDepartmentController : Controller
    {
        private readonly ICathedraService cathedra;
        private readonly IFacultyService faculty;
        private readonly IKnowledgeAreaService area;
        private readonly ISpecializationService specialization;
        private readonly ISpecialityService speciality;

        public EducationalDepartmentController(ICathedraService servC, IFacultyService servF, IKnowledgeAreaService servA, ISpecializationService servS, ISpecialityService serv)
        {
            cathedra = servC;
            area = servA;
            faculty = servF;
            specialization = servS;
            speciality = serv;
        }

        public IActionResult VHome()
        {
            return View("~/Views/EducationalDepartment/Home.cshtml");
        }

        #region Faculty

        public IActionResult GetFaculty()
        {
            FacultyModel newModel = new FacultyModel();
            newModel.newList = faculty.GetAll().ToList();
            return View("~/Views/EducationalDepartment/Faculty/Faculty.cshtml", newModel);
        }

        public async Task<IActionResult> AddNewFaculty(AddFacultyModel model)
        {
            FacultyDTO newItem = new FacultyDTO()
            {
                facultyName = model.Name,
                facultyAddress = model.Address
            };

            await faculty.Create(newItem);
            return RedirectToAction("GetFaculty", "EducationalDepartment");
        }

        public IActionResult GetAddFaculty()
        {
            return View("~/Views/EducationalDepartment/Faculty/AddFaculty.cshtml");
        }
        #endregion


        #region Cathedra
        public IActionResult GetCathedra()
        {
            CathedraModel newModel = new CathedraModel();
            newModel.newList = cathedra.GetAll().ToList();
            return View("~/Views/EducationalDepartment/Cathedra/Cathedra.cshtml", newModel);
        }

        public async Task<IActionResult> AddNewCathedra(AddCathedraModel model)
        {
            CathedraDTO newItem = new CathedraDTO()
            {
                cathedraName = model.nameCathedra,
                facultyName = model.nameFaculty,
            };

            await cathedra.Create(newItem);
            return RedirectToAction("GetCathedra", "EducationalDepartment");
        }

        public IActionResult GetAddCathedra()
        {
            AddCathedraModel newModel = new AddCathedraModel();
            newModel.newList = faculty.GetAll().Select(a => new SelectListItem { Value = a.facultyName, Text = a.facultyName }).ToList();

            return View("~/Views/EducationalDepartment/Cathedra/AddCathedra.cshtml", newModel);
        }
        #endregion


        #region Speciality
        public IActionResult GetSpeciality()
        {
            SpecialityModel newModel = new SpecialityModel();
            newModel.newList = speciality.GetAll().ToList();
            return View("~/Views/EducationalDepartment/Speciality/Speciality.cshtml", newModel);
        }

        public async Task<IActionResult> AddNewSpeciality(AddSpecialityModel model)
        {
            SpecialityDTO newItem = new SpecialityDTO()
            {
                Name_Speciality = model.Name_Speciality,
                Code_Speciality = model.Code_Speciality,
                KnowledgeAreaName = model.Name_area
            };

            await speciality.Create(newItem);
            return RedirectToAction("GetSpeciality", "EducationalDepartment");
        }

        public IActionResult GetAddSpeciality()
        {
            AddSpecialityModel newModel = new AddSpecialityModel();
            newModel.newList = area.GetAll().Select(a => new SelectListItem { Value = a.areaName, Text = a.areaName }).ToList();

            return View("~/Views/EducationalDepartment/Speciality/AddSpeciality.cshtml", newModel);
        }
        #endregion

        #region Specialization
        public IActionResult GetSpecialization()
        {
            SpecializationModel newModel = new SpecializationModel();
            newModel.newList = specialization.GetAll().ToList();
            return View("~/Views/EducationalDepartment/Specialization/Specialization.cshtml", newModel);
        }

        public async Task<IActionResult> AddNewSpecialization(AddSpecializationModel model)
        {
            SpecializationDTO newItem = new SpecializationDTO()
            {
                nameSpecialization = model.nameSpecialization,
                Speciality = model.nameSpeciality,
                nameCathedra = model.nameCathedra
            };

            await specialization.Create(newItem);
            return RedirectToAction("GetSpecialization", "EducationalDepartment");
        }

        public IActionResult GetAddSpecialization()
        {
            AddSpecializationModel newModel = new AddSpecializationModel();
            newModel.newListFaculty = faculty.GetAll().Select(x => new SelectListItem() { Text = x.facultyName, Value = x.facultyName }).ToList();
            //newModel.newListCathedra = _ServiceCathedra.GetAll().Select(x => new SelectListItem() { Text = x.cathedraName, Value = x.cathedraName }).ToList();
            //newModel.newListSpeciality = _ServiceSpeciality.GetAll().Select(x => new SelectListItem() { Text = x.Name_Speciality, Value = x.Name_Speciality }).ToList();

            return View("~/Views/EducationalDepartment/Specialization/AddSpecialization.cshtml", newModel);
        }

        [HttpGet]
        public ActionResult GetItems(string id)
        {
            List<CathedraDTO> asd = cathedra.GetAll().Where(c => c.facultyName == id).ToList();
            AddSpecializationModel newModel = new AddSpecializationModel();
            newModel.newListCathedra = asd.Select(x => new SelectListItem() { Text = x.cathedraName, Value = x.cathedraName }).ToList();
            return PartialView("~/Views/EducationalDepartment/Specialization/GetItems.cshtml", newModel);
        }
        #endregion
    }
}