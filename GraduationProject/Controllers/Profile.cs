using DataAccess.EFCore.UnitOfWorks;
using Domain.Entities;
using Domain.Interfaces;
using GraduationProject.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GraduationProject.Controllers
{

    [Authorize(Roles = "student")]
    public class Profile : Controller
    {
        private IUnitOfWork unitOfWork;
        private UserManager<Account> userManager;
        public Profile(IUnitOfWork _unitOfWork, UserManager<Account> _userManager)
        {
            unitOfWork = _unitOfWork;
            userManager = _userManager;
        }

        /*************************************** Student Profile ***************************************/
        public IActionResult YourProfile()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                int studentId = (int)HttpContext.Session.GetInt32("StudentId");
                Student student = unitOfWork.Student.getWithUni(studentId);
                return View(student);
            }
        }

        /*************************************** Student Profile EDIT get and post ***************************************/
        [HttpGet]
        public IActionResult EditProfile()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                int studentId = (int)HttpContext.Session.GetInt32("StudentId");
                Student student = unitOfWork.Student.GetById(studentId);
                EditProfileViewModel model = new EditProfileViewModel
                {
                    StudentId = student.StudentId,
                    StudentName = student.StudentName,
                    StudentEmail = student.StudentEmail,
                    Address = student.Address,
                    Experience = student.Experience,
                    Projects = student.Projects,
                    Skills = student.Skills,
                    GPA = student.GPA,
                    Image = student.Image
                };
                return View(model);
            }
        }
        [HttpPost]
        public async Task<IActionResult> EditProfile(EditProfileViewModel model, IFormFile image, [FromServices] IWebHostEnvironment env)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    Student student = unitOfWork.Student.GetById(model.StudentId);
                    student.StudentEmail = model.StudentEmail;
                    student.Address = model.Address;
                    student.StudentName = model.StudentName;
                    student.Projects = model.Projects;
                    student.Skills = model.Skills;
                    student.Experience = model.Experience;
                    student.GPA = model.GPA;


                    if (image != null && image.Length > 0)
                    {
                        var imagePath = Path.Combine(env.WebRootPath, "uploads", image.FileName);
                        using (var stream = new FileStream(imagePath, FileMode.Create))
                        {
                            await image.CopyToAsync(stream);
                        }
                        student.Image = "/uploads/" + image.FileName;
                        Account acc = await userManager.FindByIdAsync(student.AccountId);
                        acc.AccountImage = "/uploads/" + image.FileName;
                        await userManager.UpdateAsync(acc);
                    }


                    unitOfWork.Student.Update(student);
                    unitOfWork.Complete();
                    return RedirectToAction("YourProfile");
                }
                return View(model);
            }
        }
        /*************************************** Display Company Profile ***************************************/
        public IActionResult CompanyProfile(int id)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                if (id == 0)
                {
                    return NotFound();
                }
                CompanyProfileViewModel model = new CompanyProfileViewModel
                {
                    company = unitOfWork.Company.GetById(id),
                    trainings = unitOfWork.Training.GetTrainingsByCompanyId(id)
                };
                return View(model);
            }
        }


    }
}
