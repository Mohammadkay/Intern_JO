using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace GraduationProject.Controllers
{
    [Authorize(Roles = "student")]
    public class ApplicationsController : Controller
    {
        private IUnitOfWork unitOfWork;
        public ApplicationsController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        /*************************************** Apply action ***************************************/
        public IActionResult Apply(int TrainingId)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                int studentId = (int)HttpContext.Session.GetInt32("StudentId");
                Application application = new Application
                {
                    StudentId = studentId,
                    TrainingId = TrainingId,
                    Status = 0
                };
                if (!unitOfWork.Application.isExists(application))
                {
                    unitOfWork.Application.Add(application);
                    unitOfWork.Complete();
                    int categoryId = unitOfWork.Training.GetCategoryIdByTraining(TrainingId);
                    TempData["ApplyingStatus"] = "Thank you, you have made the application succesfully";
                    return RedirectToAction("YourApplications", "Applications");
                }
                TempData["ApplyingError"] = "You Already Sent A Request To This Application";
                return RedirectToAction("Main", "Main");
            }
        }

        /*************************************** Student Applications ***************************************/
        public IActionResult YourApplications()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                ViewBag.ApplyingStatus = TempData["ApplyingStatus"] as string;
                int studentId = (int)HttpContext.Session.GetInt32("StudentId");
                IEnumerable<Application> applications = unitOfWork.Application.GetByStudentId(studentId);
                ViewBag.Error = TempData["ErrorInApplication"] as string;
                if (!applications.Any())
                {
                    ViewBag.NoResultsFound = "You did not make any applications";
                }
                return View(applications);
            }
        }

        /*************************************** Make this application your training ***************************************/
        public IActionResult ChooseApplication(int trainingId)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                int studentId = (int)HttpContext.Session.GetInt32("StudentId");
                List<Application> applicationList = unitOfWork.Application.GetByStudentId(studentId).ToList();
                Student student = unitOfWork.Student.GetById(studentId);
                student.isTrainee = true;
                student.TrainingId = trainingId;
                foreach (var application in applicationList)
                {
                    unitOfWork.Application.Delete(application);
                }
                unitOfWork.Complete();
                if (unitOfWork.Complete() == 1)
                {
                    TempData["ErrorInApplication"] = "Something went wrong! please try again.";
                    return RedirectToAction("YourApplications");
                }
                return RedirectToAction("TraineeMain", "Main");
            }
        }
        /*************************************** Delete Application ***************************************/
        public IActionResult DeleteApplication(int trainingId)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("StudentId") || HttpContext.Session.GetInt32("StudentId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                int studentId = (int)HttpContext.Session.GetInt32("StudentId");
                Application application = unitOfWork.Application.GetApplicationById(trainingId, studentId);
                unitOfWork.Application.Delete(application);
                unitOfWork.Complete();
                if (unitOfWork.Complete() == 1)
                {
                    TempData["ErrorInApplication"] = "Something went wrong! please try again.";
                    return RedirectToAction("YourApplications");
                }
                return RedirectToAction("YourApplications");
            }
        }
    }
}
