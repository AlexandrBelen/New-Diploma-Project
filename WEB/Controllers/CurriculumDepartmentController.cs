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
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB.Models.CurriculumDepartment;

namespace WEB.Controllers
{
    public class CurriculumDepartmentController : Controller
    {

        public IActionResult VHome()
        {
            return View("~/Views/CurriculumDepartment/Home.cshtml");
        }

        private readonly ICycleService cycle;
        private readonly ISpecializationService specialization;
        private readonly IFormEducationService formEducation;
        private readonly IEducationalDegreeService educationalDegree;
        private readonly IPlanEducationalProcessService planEducationalProcess;
        private readonly IFormDeliveryService formDelivery;
        private readonly ICurriculumService curriculum;
        private readonly IUnderCycleService underCycle;
        private readonly IKnowledgeAreaService knowledgeArea;
        private readonly IFacultyService faculty;
        private readonly ICathedraService cathedra;

        public CurriculumDepartmentController(ICycleService servCy, ISpecializationService servS, IFormEducationService servFE, 
            IEducationalDegreeService servED, IPlanEducationalProcessService servPE, IFormDeliveryService servFD, ICurriculumService servCu, 
                IUnderCycleService servUC, IKnowledgeAreaService servK, IFacultyService servF, ICathedraService servCa)
        {
            cycle = servCy;
            specialization = servS;
            formEducation = servFE;
            educationalDegree = servED;
            planEducationalProcess = servPE;
            formDelivery = servFD;
            curriculum = servCu;
            underCycle = servUC;
            knowledgeArea = servK;
            faculty = servF;
            cathedra = servCa;
        }

        //public IActionResult GetCurriculum()
        //{
        //    CurriculumsModel newModel = new CurriculumsModel();
        //    newModel.newList = _Service.GetAll().ToList();
        //    return View("~/Views/Curriculum/Curriculums.cshtml", newModel);
        //}

        //public async Task<IActionResult> AddNewCurriculum(AddCurriculumModel model)
        //{
        //    CurriculumDTO newItem = new CurriculumDTO()
        //    {
        //        Qualification = model.Qualification,
        //        NameSpecialization = model.nameSpecialization,
        //        NameEducationalDegree = model.nameEducationalDegree,
        //        NameForm_of_education = model.nameForm_of_education,
        //        TrainingPeriod = model.TrainingPeriod,
        //        BasedOn = model.BasedOn
        //    };

        //    await curriculum.Create(newItem);
        //    return RedirectToAction("VHome", "CurriculumDepartment");
        //}

        public IActionResult GetAddCurriculum()
        {
            AddCurriculumModel newModel = new AddCurriculumModel();
            newModel.newListSpecialization = specialization.GetAll().ToList().Select(x => new SelectListItem { Text = x.nameSpecialization, Value = x.nameSpecialization }).ToList();
            newModel.newListForm_of_education = formEducation.GetAll().ToList().Select(x => new SelectListItem { Text = x.FormEducationName, Value = x.FormEducationName }).ToList();
            newModel.newListEducationalDegree = educationalDegree.GetAll().ToList().Select(x => new SelectListItem { Text = x.EducationalDegreeName, Value = x.EducationalDegreeName }).ToList();
            newModel.newKnowledgeArea = knowledgeArea.GetAll().ToList().Select(x => new SelectListItem { Text = x.areaCode + "  " + x.areaName, Value = x.areaName }).ToList();
            newModel.newFaculty = faculty.GetAll().ToList().Select(x => new SelectListItem { Text = x.facultyName, Value = x.facultyName }).ToList();



            return View("~/Views/CurriculumDepartment/Curriculum/AddCurriculum.cshtml", newModel);
        }

        [HttpGet]
        public ActionResult GetItemsFaculty(string id)
        {
            List<CathedraDTO> asd = cathedra.GetAll().Where(c => c.facultyName == id).ToList();
            AddCurriculumModel newModel = new AddCurriculumModel();
            newModel.newListCathedra = asd.Select(x => new SelectListItem() { Text = x.cathedraName, Value = x.cathedraName }).ToList();
            return PartialView("~/Views/CurriculumDepartment/Curriculum/GetItemsFaculty.cshtml", newModel);
        }


        //public IActionResult GetCycle()
        //{
        //    CyclesModel newModel = new CyclesModel();
        //    newModel.newList = _Service.GetAll().ToList();
        //    return View("~/Views/Cycle/Cycles.cshtml", newModel);
        //}

        //public async Task<IActionResult> CreateNewCycle(Add_CycleModel model)
        //{
        //    CycleDTO newItem = new CycleDTO()
        //    {
        //        CycleName = model.nameCycle
        //    };

        //    await _Service.Create(newItem);
        //    return RedirectToAction("GetCycle", "Cycle");
        //}

        //public IActionResult Add_Cycle()
        //{
        //    return View("~/Views/Cycle/Add_Cycle.cshtml");
        //}





        //public IActionResult GetUnderCycle()
        //{
        //    UnderCyclesModel newModel = new UnderCyclesModel();
        //    newModel.newList = _Service.GetAll().ToList();
        //    return View("~/Views/UnderCycle/UnderCycles.cshtml", newModel);
        //}

        //public async Task<IActionResult> CreateNewUnderCycle(Add_UnderCycleModel model)
        //{
        //    UnderCycleDTO newItem = new UnderCycleDTO()
        //    {
        //        UnderCycleName = model.nameUnderCycle,
        //        CycleName = model.nameCycle,
        //        Code = model.Code

        //    };

        //    await _Service.Create(newItem);
        //    return RedirectToAction("GetUnderCycle", "UnderCycle");
        //}

        //public IActionResult Add_UnderCycle()
        //{
        //    Add_UnderCycleModel newModel = new Add_UnderCycleModel();
        //    newModel.newList = _ServiceCycle.GetAll().Select(a => new SelectListItem { Value = a.CycleName, Text = a.CycleName }).ToList();

        //    return View("~/Views/UnderCycle/Add_UnderCycle.cshtml", newModel);
        //}





        //public IActionResult GetPlanEducationalProcess()
        //{
        //    PlanEducationalProcesssModel newModel = new PlanEducationalProcesssModel();
        //    newModel.curriculum = _ServiceC.GetAll().ToList();
        //    return View("~/Views/PlanEducationalProcess/PlanEducationalProcesss.cshtml", newModel);
        //}

        //public async Task<IActionResult> CreateNewPlanEducationalProcess(Add_PlanEducationalProcessModel model)
        //{
        //    PlanEducationalProcessDTO newItem = new PlanEducationalProcessDTO()
        //    {
        //        NameDiscipline = model.NameDiscipline,
        //        ID_Curriculm = model.ID_Curriculm,
        //        Course = model.Course,
        //        Projects = model.Projects,
        //        LaboratoryHours = model.LaboratoryHours,
        //        PracticesHours = model.PracticesHours,
        //        IndependentWorkHours = model.IndependentWorkHours,
        //        LectureHours = model.LectureHours,
        //        Semester = model.Semester,
        //        nameFormDelivery = model.nameFormDelivery,
        //        nameUnderCycle = model.nameUnderCycle,
        //    };

        //    await _Service.Create(newItem);
        //    return RedirectToAction("Add_PlanEducationalProcess", "PlanEducationalProcess");
        //}

        //public IActionResult Add_PlanEducationalProcess()
        //{
        //    Add_PlanEducationalProcessModel newModel = new Add_PlanEducationalProcessModel();
        //    newModel.newListFormDelivery = _ServiceF.GetAll().ToList().Select(x => new SelectListItem { Text = x.FormDeliveryName, Value = x.FormDeliveryName }).ToList();
        //    newModel.newListIdCurriculm = _ServiceC.GetAll().ToList().Select(x => new SelectListItem { Text = x.Id_Curriculum.ToString(), Value = x.Id_Curriculum.ToString() }).ToList();
        //    newModel.newListUnderCycle = _ServiceU.GetAll().ToList().Select(x => new SelectListItem { Text = x.UnderCycleName, Value = x.UnderCycleName }).ToList();

        //    return View("~/Views/PlanEducationalProcess/Add_PlanEducationalProcess.cshtml", newModel);
        //}
    }
}