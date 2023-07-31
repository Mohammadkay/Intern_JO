using Domain.Entities;
using Domain.Interfaces;
using GraduationProject.Areas.University.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace GraduationProject.Areas.University.Controllers
{
    [Area("university")]
    [Authorize(Roles = "uniSupervisor")]
    public class StudentsController : Controller
    {
        private IUnitOfWork unitOfWork;
        private UserManager<Account> userManager;
        public StudentsController(IUnitOfWork _unitOfWork, UserManager<Account> _userManager)
        {
            unitOfWork = _unitOfWork;
            userManager = _userManager;
        }
        public IActionResult AllStudents()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                AllStudentsViewModel model = new AllStudentsViewModel
                {
                    Active = unitOfWork.Student.GetStudentsByUni((int)HttpContext.Session.GetInt32("UniversityId")),
                    NonActive = unitOfWork.Student.GetNotActiveStudents((int)HttpContext.Session.GetInt32("UniversityId"))
                };
                return View(model);
            }
        }
        public IActionResult TraineeStudents()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                IEnumerable<Student> model = unitOfWork.Student.GetTraineeStudents((int)HttpContext.Session.GetInt32("UniversityId"));
                return View(model);
            }
        }
        public IActionResult NotTraineeStudents()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                IEnumerable<Student> model = unitOfWork.Student.GetNotTrainee((int)HttpContext.Session.GetInt32("UniversityId"));
                return View(model);
            }
        }
        public IActionResult StudentEmails()
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                ViewBag.err = TempData["Error"] as string;
                ViewBag.oneErr = TempData["OneError"] as string;
                IEnumerable<StudentEmail> model = unitOfWork.StudentEmails.GetStudentEmails((int)HttpContext.Session.GetInt32("UniversityId"));
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult AddEmails(IFormFile file)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                var data = new List<string>();
                try
                {
                    using (var package = new ExcelPackage(file.OpenReadStream()))
                    {
                        var worksheet = package.Workbook.Worksheets[0];
                        var rowCount = worksheet.Dimension.Rows;

                        // Loop through each row and get the value of the first column
                        for (int row = 1; row <= rowCount; row++)
                        {
                            var cellValue = worksheet.Cells[row, 1].Value?.ToString();
                            if (!string.IsNullOrEmpty(cellValue))
                            {
                                if (unitOfWork.StudentEmails.isExists(cellValue))
                                {
                                    TempData["OneError"] = "Some data already exists";
                                    continue;
                                }
                                data.Add(cellValue);
                            }
                        }
                    }
                    unitOfWork.StudentEmails.AddStudentEmails(data, (int)HttpContext.Session.GetInt32("UniversityId"));
                    unitOfWork.Complete();
                }
                catch
                {
                    TempData["Error"] = "Something went wrong please check you excel sheet and try again!";
                }
                return RedirectToAction("StudentEmails");
            }
        }

        [HttpPost]
        public IActionResult AddEmail(string email)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                if (email == null)
                {
                    TempData["Error"] = "You didnt insert an email!";
                    return RedirectToAction("StudentEmails");
                }
                else
                {
                    if (unitOfWork.StudentEmails.isExists(email))
                    {
                        TempData["OneError"] = "Email Already exists";
                        return RedirectToAction("StudentEmails");
                    }
                    StudentEmail se = new StudentEmail
                    {
                        Email = email,
                        isCreated = false,
                        UniversityId = (int)HttpContext.Session.GetInt32("UniversityId")
                    };

                    unitOfWork.StudentEmails.Add(se);
                    unitOfWork.Complete();
                    return RedirectToAction("StudentEmails");
                }
            }
        }

        public IActionResult DeleteEmail(int id)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                StudentEmail email = unitOfWork.StudentEmails.GetById(id);
                unitOfWork.StudentEmails.RemoveStudentEmail(email);
                int result = unitOfWork.Complete();
                if (result == 0)
                {
                    TempData["Error"] = "Something went wrong please try again!";
                }
                return RedirectToAction("StudentEmails");
            }
        }

        public IActionResult StudentProfile(int id, bool isTrainee)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                Student student;
                if (isTrainee)
                {
                    student = unitOfWork.Student.getStudentWithTraining(id);
                    ViewBag.ReportExists = unitOfWork.Report.isExists(student.StudentId);
                }
                else
                {
                    student = unitOfWork.Student.GetById(id);
                }
                return View(student);
            }
        }
        public IActionResult Report(int id)
        {
            if (HttpContext.Session == null || !HttpContext.Session.Keys.Contains("SupervisorId") || HttpContext.Session.GetInt32("SupervisorId") == null)
            {
                TempData["SessionTimeOut"] = "Your Session has ended";
                return RedirectToAction("Logout", "Account", new { area = "" });
            }
            else
            {
                return View(unitOfWork.Report.getByStudentId(id));
            }
        }
    }
}
