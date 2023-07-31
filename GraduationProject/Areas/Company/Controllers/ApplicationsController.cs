using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GraduationProject.Areas.Company.Controllers
{
    [Area("company")]
    [Authorize(Roles = "company")]
    public class ApplicationsController : Controller
    {
        private IUnitOfWork unitOfWork;
        public ApplicationsController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Applications()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                IEnumerable<Application> model = unitOfWork.Application.GetApplicationsByCompanyId((int)HttpContext.Session.GetInt32("CompanyId"));
                return View(model);
            }
        }
        public IActionResult Approve(int TrainingId, int StudentId)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                Application application = unitOfWork.Application.GetApplicationById(TrainingId, StudentId);
                if ((int)HttpContext.Session.GetInt32("CompanyId") != application.Training.CompanyId)
                {
                    return NotFound();
                }
                application.Status = Application.status.Accepted;
                unitOfWork.Application.Update(application);
                unitOfWork.Complete();
                return RedirectToAction("Applications");
            }
        }
        public IActionResult Reject(int TrainingId, int StudentId)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                Application application = unitOfWork.Application.GetApplicationById(TrainingId, StudentId);
                if ((int)HttpContext.Session.GetInt32("CompanyId") != application.Training.CompanyId)
                {
                    return NotFound();
                }
                application.Status = Application.status.Rejected;
                unitOfWork.Application.Update(application);
                unitOfWork.Complete();
                return RedirectToAction("Applications");
            }
        }
        public IActionResult StudentProfile(int id)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                Student student = unitOfWork.Student.getWithUni(id);
                return View(student);
            }
        }
        public IActionResult Trainees()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                IEnumerable<Student> model = unitOfWork.Student.GetTraineeByCo((int)HttpContext.Session.GetInt32("CompanyId"));
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult FillReport(int id)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                CReport model = unitOfWork.Report.getByStudentId(id);
                if (model == null)
                {
                    Student student = unitOfWork.Student.GetById(id);
                    ViewData["name"] = student.StudentName;
                    ViewBag.id = id;
                    return View();
                }
                else { return View(model); }
            }
        }
        [HttpPost]
        public IActionResult FillReport(CReport model)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                if (ModelState.IsValid)
                {
                    if (model.CReportId != 0)
                    {
                        unitOfWork.Report.Update(model);
                        unitOfWork.Complete();
                    }
                    else
                    {
                        unitOfWork.Report.Add(model);
                        unitOfWork.Complete();
                    }
                    return RedirectToAction("Trainees");
                }
                return View(model);
            }
        }
    }
}
