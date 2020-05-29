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
using WEB.Models.AdminDepartment;


namespace WEB.Controllers
{
    public class AdminDepartmentController : Controller
    {
        private readonly IEducationalDegreeService educationalDegree;
        private readonly IKnowledgeAreaService knowledgeArea;
        private readonly IFormDeliveryService formDelivery;
        private readonly IFormEducationService formEducation;

        public AdminDepartmentController(IEducationalDegreeService servE, IKnowledgeAreaService servK, IFormDeliveryService servFD, IFormEducationService servFE)
        {
            educationalDegree = servE;
            knowledgeArea = servK;
            formEducation = servFE;
            formDelivery = servFD;
        }

        public IActionResult VHome()
        {
            return View("~/Views/AdminDepartment/Home.cshtml");
        }


        #region EducationalDegree
        public IActionResult GetEducationalDegree()
        {
            EducationalDegreeModel newModel = new EducationalDegreeModel();
            newModel.newList = educationalDegree.GetAll().ToList();
            return View("~/Views/AdminDepartment/EducationalDegree/EducationalDegree.cshtml", newModel);
        }

        public async Task<IActionResult> AddNewEducationalDegree(AddEducationalDegreeModel model)
        {
            EducationalDegreeDTO newItem = new EducationalDegreeDTO()
            {
                EducationalDegreeName = model.nameEducationalDegree
            };

            await educationalDegree.Create(newItem);
            return RedirectToAction("GetEducationalDegree", "AdminDepartment");
        }

        public IActionResult GetAddEducationalDegree()
        {
            return View("~/Views/AdminDepartment/EducationalDegree/AddEducationalDegree.cshtml");
        }
        #endregion


        #region KnowledgeArea
        public IActionResult GetKnowledgeArea()
        {
            KnowledgeAreaModel newModel = new KnowledgeAreaModel();
            newModel.newList = knowledgeArea.GetAll().ToList();
            return View("~/Views/AdminDepartment/KnowledgeArea/KnowledgeArea.cshtml", newModel);
        }

        public async Task<IActionResult> AddNewKnowledgeArea(AddKnowledgeAreaModel model)
        {
            KnowledgeAreaDTO newItem = new KnowledgeAreaDTO()
            {
                areaName = model.Name_area,
                areaCode = model.Code_area
            };

            await knowledgeArea.Create(newItem);
            return RedirectToAction("GetKnowledgeArea", "AdminDepartment");
        }

        public IActionResult GetAddKnowledgeArea()
        {
            return View("~/Views/AdminDepartment/KnowledgeArea/AddKnowledgeArea.cshtml");
        }
        #endregion


        #region FormDelivery
        public IActionResult GetFormDelivery()
        {
            FormDeliveryModel newModel = new FormDeliveryModel();
            newModel.newList = formDelivery.GetAll().ToList();
            return View("~/Views/AdminDepartment/FormDelivery/FormDelivery.cshtml", newModel);
        }

        public async Task<IActionResult> AddNewFormDelivery(AddFormDeliveryModel model)
        {
            FormDeliveryDTO newItem = new FormDeliveryDTO()
            {
                FormDeliveryName = model.nameFormDelivery
            };

            await formDelivery.Create(newItem);
            return RedirectToAction("GetFormDelivery", "AdminDepartment");
        }

        public IActionResult GetAddFormDelivery()
        {
            return View("~/Views/AdminDepartment/FormDelivery/AddFormDelivery.cshtml");
        }
        #endregion


        #region FormEducation
        public IActionResult GetFormEducation()
        {
            FormEducationModel newModel = new FormEducationModel();
            newModel.newList = formEducation.GetAll().ToList();
            return View("~/Views/AdminDepartment/FormEducation/FormEducation.cshtml", newModel);
        }

        public async Task<IActionResult> AddNewFormEducation(AddFormEducationModel model)
        {
            FormEducationDTO newItem = new FormEducationDTO()
            {
                FormEducationName = model.Form_of_educationName
            };

            await formEducation.Create(newItem);
            return RedirectToAction("GetFormEducation", "AdminDepartment");
        }

        public IActionResult GetAddFormEducation()
        {
            AddFormEducationModel newModel = new AddFormEducationModel();

            return View("~/Views/AdminDepartment/FormEducation/AddFormEducation.cshtml");
        }
        #endregion
    }
}