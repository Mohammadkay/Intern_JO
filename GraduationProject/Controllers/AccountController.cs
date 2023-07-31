using Domain.Entities;
using Domain.Interfaces;
using GraduationProject.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GraduationProject.Controllers
{
    public class AccountController : Controller
    {
        private IUnitOfWork unitOfWork;
        private UserManager<Account> userManager;
        private SignInManager<Account> signInManager;
        private RoleManager<IdentityRole> roleManager;
        public AccountController(IUnitOfWork _unitOfWork, UserManager<Account> _userManager, SignInManager<Account> _signInManager, RoleManager<IdentityRole> _roleManager)
        {
            unitOfWork = _unitOfWork;
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }

        /* Student account creation */
        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAccount(RegisterStudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (unitOfWork.StudentEmails.isExists(model.Email))
                {
                    Account account = new Account
                    {
                        Email = model.Email,
                        FullName = model.Name,
                        UserName = model.Email,
                        AccountImage = "/uploads/user.jpg"
                    };
                    var checkCreation = await userManager.CreateAsync(account, model.Password);
                    if (checkCreation.Succeeded)
                    {
                        unitOfWork.StudentEmails.CreateTick(model.Email);
                        var Acc = await userManager.FindByEmailAsync(model.Email);
                        var roleResult = await userManager.AddToRoleAsync(Acc, "student");
                        StudentEmail email = unitOfWork.StudentEmails.GetStudentEmail(model.Email);
                        if (roleResult.Succeeded)
                        {
                            DateTime now = DateTime.Now;
                            Student student = new Student
                            {
                                StudentName = model.Name,
                                StudentEmail = model.Email,
                                UniversityId = email.UniversityId,
                                AccountId = Acc.Id,
                                isActive = true,
                                CreationDate = now,
                                ExpierationDate = now.AddMonths(4),
                                Image = "/uploads/user.jpg"
                            };
                            StudentEmail se = unitOfWork.StudentEmails.GetStudentEmail(model.Email);
                            se.isCreated = true;
                            unitOfWork.StudentEmails.Update(se);
                            unitOfWork.Student.Add(student);
                            unitOfWork.Complete();
                            await signInManager.PasswordSignInAsync(model.Email, model.Password, true, false);
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            foreach (var err in roleResult.Errors)
                            {
                                ModelState.AddModelError("", err.Description);
                            }
                            return View(model);
                        }

                    }
                    else
                    {
                        foreach (var error in checkCreation.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(model);
                    }
                }
                ViewBag.emailNotFound = "Your Email is not found! Call your supervisor to add you.";
                return View(model);
            }
            return View(model);
        }

        /* Company registeration */
        [HttpGet]
        public IActionResult CompanyRegister()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CompanyRegister(CoRegisterViewModel model, IFormFile image, [FromServices] IWebHostEnvironment env)
        {
            if (ModelState.IsValid)
            {
                if (image != null && image.Length > 0)
                {
                    var imagePath = Path.Combine(env.WebRootPath, "uploads", image.FileName); //img
                    using (var stream = new FileStream(imagePath, FileMode.Create)) //img
                    {
                        await image.CopyToAsync(stream); //img
                    }
                    Account account = new Account
                    {
                        Email = model.Email,
                        FullName = model.CompanyName,
                        UserName = model.Email,
                        AccountImage = "/uploads/" + image.FileName
                    };
                    var checkRegister = await userManager.CreateAsync(account, model.Password);
                    if (checkRegister.Succeeded)
                    {
                        var acc = await userManager.FindByEmailAsync(model.Email);
                        var roleResult = await userManager.AddToRoleAsync(acc, "company");
                        if (roleResult.Succeeded)
                        {
                            Company co = new Company
                            {
                                CompanyName = model.CompanyName,
                                CompanyInfo = model.CompanyInfo,
                                CompanyLocation = model.CompanyLocation,
                                CompanyEmail = model.Email,
                                AccountId = acc.Id,
                                Image = "/uploads/" + image.FileName
                            };
                            unitOfWork.Company.Add(co);
                            unitOfWork.Complete();
                            await signInManager.PasswordSignInAsync(model.Email, model.Password, true, false);
                            return RedirectToAction("Index", "Home");

                        }
                        else
                        {
                            foreach (var err in roleResult.Errors)
                            {
                                ModelState.AddModelError("", err.Description);
                            }
                            return View(model);
                        }
                    }
                    else
                    {
                        foreach (var error in checkRegister.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(model);
                    }
                }
                return View(model);
            }
            return View(model);
        }

        /* Login */
        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.SessionTimeOut = TempData["SessionTimeOut"] as string;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, true, false);
                if (result.Succeeded)
                {
                    var user = await userManager.FindByNameAsync(model.UserName);
                    if (await userManager.IsInRoleAsync(user, "student"))
                    {
                        var student = unitOfWork.Student.getStudentByAccountId(user.Id);
                        HttpContext.Session.SetInt32("StudentId", student.StudentId);
                        return RedirectToAction("Main", "Main");
                    }
                    else if (await userManager.IsInRoleAsync(user, "company"))
                    {
                        Company c = unitOfWork.Company.getByAccId(user.Id);
                        HttpContext.Session.SetInt32("CompanyId", c.CompanyId);
                        return RedirectToAction("Default", "Main", new { area = "company" });
                    }
                    else if (await userManager.IsInRoleAsync(user, "uniSupervisor"))
                    {
                        UniSupervisor S = unitOfWork.UniSupervisor.GetByAccId(user.Id);
                        HttpContext.Session.SetInt32("SupervisorId", S.UniSupervisorId);
                        HttpContext.Session.SetInt32("UniversityId", S.UniversityId);
                        return RedirectToAction("Default", "Main", new { area = "university" });
                    }
                    ModelState.AddModelError("", "Something went wrong, Please try again!");
                    return View(model);
                }
                ModelState.AddModelError("", "Invalid Username/Password");
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
