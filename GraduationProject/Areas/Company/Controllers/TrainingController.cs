using DataAccess.EFCore.UnitOfWorks;
using Domain.Entities;
using Domain.Interfaces;
using GraduationProject.Areas.Company.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GraduationProject.Areas.Company.Controllers
{
    [Area("company")]
    [Authorize(Roles = "company")]
    public class TrainingController : Controller
    {
        private IUnitOfWork unitOfWork;
        public TrainingController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Posts()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                List<Training> model = unitOfWork.Training.GetAllByCo((int)HttpContext.Session.GetInt32("CompanyId"));
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult AddPost()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                ViewBag.Categories = new SelectList(unitOfWork.Category.GetAll(), "CategoryId", "CategoryName");
                return View();
            }
        }
        [HttpPost]
        public IActionResult AddPost(AddPostViewModel model)
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
                    Training training = new Training
                    {
                        CategoryId = model.CategoryId,
                        StartDate = model.StartDate,
                        EndDate = model.EndDate,
                        TrainingTitle = model.TrainingTitle,
                        TrainingDetails = model.TrainingDetails,
                        TrainingLocation = model.TrainingLocation,
                        CompanyId = (int)HttpContext.Session.GetInt32("CompanyId"),
                        isAvailable = true
                    };
                    unitOfWork.Training.Add(training);
                    unitOfWork.Complete();
                    return RedirectToAction("Posts");
                }
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult EditPost(int PostId)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                ViewBag.Categories = new SelectList(unitOfWork.Category.GetAll(), "CategoryId", "CategoryName");
                Training model = unitOfWork.Training.GetById(PostId);
                if ((int)HttpContext.Session.GetInt32("CompanyId") != model.CompanyId)
                {
                    return NotFound();
                }
                return View(model);
            }
        }
        [HttpPost]
        public IActionResult EditPost(Training model)
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
                    model.CompanyId = (int)HttpContext.Session.GetInt32("CompanyId");
                    model.isAvailable = true;
                    unitOfWork.Training.Update(model);
                    unitOfWork.Complete();
                    return RedirectToAction("Posts");
                }
                return View(model);
            }
        }
        public IActionResult HidePost(int PostId)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                Training model = unitOfWork.Training.GetById(PostId);
                if ((int)HttpContext.Session.GetInt32("CompanyId") != model.CompanyId)
                {
                    return NotFound();
                }
                model.isAvailable = false;
                unitOfWork.Training.Update(model);
                unitOfWork.Complete();
                return RedirectToAction("Posts");
            }
        }
        public IActionResult ShowPost(int PostId)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                Training model = unitOfWork.Training.GetById(PostId);
                if ((int)HttpContext.Session.GetInt32("CompanyId") != model.CompanyId)
                {
                    return NotFound();
                }
                model.isAvailable = true;
                unitOfWork.Training.Update(model);
                unitOfWork.Complete();
                return RedirectToAction("Posts");
            }
        }
    }
}
