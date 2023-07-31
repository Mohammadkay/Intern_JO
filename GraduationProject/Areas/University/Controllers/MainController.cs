using Domain.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Linq;
using GraduationProject.Areas.University.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace GraduationProject.Areas.University.Controllers
{
    [Area("university")]
    [Authorize(Roles = "uniSupervisor")]
    public class MainController : Controller
    {
        private IUnitOfWork unitOfWork;
        private UserManager<Account> userManager;
        public MainController(IUnitOfWork _unitOfWork, UserManager<Account> _userManager)
        {
            unitOfWork = _unitOfWork;
            userManager = _userManager;
        }
        public IActionResult Default()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                ViewData["Trainee"] = unitOfWork.Student.TraineeCount((int)HttpContext.Session.GetInt32("UniversityId"));
                ViewData["NotTrainee"] = unitOfWork.Student.NotTraineeCount((int)HttpContext.Session.GetInt32("UniversityId"));
                ViewData["Companies"] = unitOfWork.Company.Count();
                ViewData["UniversityName"] = unitOfWork.University.GetById((int)HttpContext.Session.GetInt32("UniversityId")).UniversityName;
                ViewBag.changed = TempData["Changed"] as string;
                return View(unitOfWork.Student.GetTraineeStudents((int)HttpContext.Session.GetInt32("UniversityId")));
            }
        }

        public IActionResult Companies()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                return View(unitOfWork.Company.GetWithAcc());
            }
        }

        public IActionResult Messages()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePassViewModel model)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                if (ModelState.IsValid)
                {
                    Account acc = await userManager.GetUserAsync(User);
                    var result = await userManager.ChangePasswordAsync(acc, model.Current, model.New);
                    if (result.Succeeded)
                    {
                        TempData["Changed"] = "Password Changed Successfully";
                        return RedirectToAction("Default");
                    }
                    ViewBag.err = "Something went wrong, Please try again!";
                    return View(model);
                }
                return View(model);
            }
        }

        public IActionResult About()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                return View();
            }

        }
    }
}

