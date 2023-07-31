using Domain.Entities;
using Domain.Interfaces;
using GraduationProject.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GraduationProject.Controllers
{
    [Authorize(Roles = "student")]
    public class MainController : Controller
    {
        private IUnitOfWork unitOfWork;
        public MainController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        /*************************************** Main Page For Student ***************************************/
        public IActionResult Main()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                ViewBag.ApplyingError = TempData["ApplyingError"] as string;
                int studentId = (int)HttpContext.Session.GetInt32("StudentId");
                Student student = unitOfWork.Student.GetById(studentId);
                if (student.isTrainee == true)
                {
                    return RedirectToAction("TraineeMain", "Main");
                }
                ViewBag.CvPercent = unitOfWork.Student.getCvPercent(studentId);
                var categories = unitOfWork.Category.GetAll();
                if (!categories.Any())
                {
                    ViewBag.Error = "Something went wrong, Refresh please!";
                }
                return View(categories);
            }
        }

        /*************************************** Displaying Posts depending on category id ***************************************/
        public IActionResult Posts(int id)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                ViewBag.Category = unitOfWork.Category.GetById(id).CategoryName;
                var result = unitOfWork.Training.getByCategory(id);
                if (!result.Any())
                {
                    ViewBag.NotFound = "No posts found! We're sorry...";
                }
                return View(result);
            }
        }

        /*************************************** Search action (Posts & Companies) ***************************************/
        [HttpPost]
        public IActionResult Search(string term)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                SearchResultViewModel model = new SearchResultViewModel
                {
                    companies = unitOfWork.Company.Search(term),
                    Trainings = unitOfWork.Training.Search(term)
                };
                if (!model.companies.Any() && !model.Trainings.Any())
                {
                    ViewBag.EmptySearch = "Sorry , we couldn't find what you're looking for. Try search something else";
                }
                return View(model);
            }
        }

        /*************************************** Displaying list of companies ***************************************/
        public IActionResult OurCompanies()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                var model = unitOfWork.Company.GetAll();
                    ViewBag.NoResultFound = "Sorry! no companies have registered to our system yet!";
                return View(model);
            }
        }

        /*************************************** Trainee main view ***************************************/

        public IActionResult TraineeMain()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                int studentId = (int)HttpContext.Session.GetInt32("StudentId");
                Student student = unitOfWork.Student.getStudentWithTraining(studentId);
                return View(student);
            }
        }
    }
}
