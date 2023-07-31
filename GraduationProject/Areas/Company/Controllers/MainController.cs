using Domain.Entities;
using Domain.Interfaces;
using GraduationProject.Areas.Company.ViewModels;
using GraduationProject.Areas.University.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.Areas.Company.Controllers
{
    [Area("company")]
    [Authorize(Roles = "company")]
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
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                ViewData["Posts"] = unitOfWork.Training.CountByCo((int)HttpContext.Session.GetInt32("CompanyId"));
                ViewData["Applications"] = unitOfWork.Application.CountByCo((int)HttpContext.Session.GetInt32("CompanyId"));
                ViewData["Trainees"] = unitOfWork.Student.TraineeCountByCo((int)HttpContext.Session.GetInt32("CompanyId"));
                var co = unitOfWork.Company.GetById((int)HttpContext.Session.GetInt32("CompanyId"));
                ViewData["CompanyName"] = co.CompanyName;
                IEnumerable<Application> model = unitOfWork.Application.GetApplicationsByCompanyId(co.CompanyId);
                return View(model);
            }
        }
        public IActionResult Messages()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
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
        public IActionResult Profile()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                var co = unitOfWork.Company.GetById((int)HttpContext.Session.GetInt32("CompanyId"));
                CompanyProfileEditViewModel model = new CompanyProfileEditViewModel
                {
                    CompanyInfo = co.CompanyInfo,
                    CompanyName = co.CompanyName,
                    CompanyEmail = co.CompanyEmail,
                    Image = co.Image,
                    CompanyLocation = co.CompanyLocation
                };
                return View(model);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Profile(CompanyProfileEditViewModel model, IFormFile image, [FromServices] IWebHostEnvironment env)
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
                    var co = unitOfWork.Company.GetById((int)HttpContext.Session.GetInt32("CompanyId"));
                    co.CompanyName = model.CompanyName;
                    co.CompanyEmail = model.CompanyEmail;
                    co.CompanyInfo = model.CompanyInfo;
                    if (image != null && image.Length > 0)
                    {
                      Account acc =  await userManager.GetUserAsync(User);
                        var imagePath = Path.Combine(env.WebRootPath, "uploads", image.FileName);
                        using (var stream = new FileStream(imagePath, FileMode.Create))
                        {
                            await image.CopyToAsync(stream);
                        }
                        co.Image = "/uploads/" + image.FileName;
                        model.Image = co.Image;
                        acc.AccountImage = co.Image;
                        await userManager.UpdateAsync(acc);
                    }
                    unitOfWork.Company.Update(co);
                    unitOfWork.Complete();
                }
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
			if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
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
		public async Task<IActionResult> ChangePassword(ViewModels.ChangePassViewModel model)
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
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("CompanyId") || HttpContext.Session.GetInt32("CompanyId") == null)
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
