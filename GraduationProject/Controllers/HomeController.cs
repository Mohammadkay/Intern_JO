using DataAccess.EFCore;
using Domain.Entities;
using Domain.Interfaces;
using GraduationProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GraduationProject.Controllers
{

    public class HomeController : Controller
    {
        private IUnitOfWork unitOfWork;
        private SignInManager<Account> signInManager;
        private UserManager<Account> userManager;
        RoleManager<IdentityRole> roleManager;
        public HomeController(IUnitOfWork _unitOfWork, SignInManager<Account> _signInManager, UserManager<Account> _userManager, RoleManager<IdentityRole> roleManager)
        {
            unitOfWork = _unitOfWork;
            signInManager = _signInManager;
            userManager = _userManager;
            this.roleManager = roleManager;

        }
        public async Task<IActionResult> Index()
        {

            //IdentityRole role1 = new IdentityRole
            //{
            //    Name = "student",
            //};
            //IdentityRole role2 = new IdentityRole
            //{
            //    Name = "company",
            //};
            //IdentityRole role3 = new IdentityRole
            //{
            //    Name = "uniSupervisor",
            //};
            //await roleManager.CreateAsync(role1);
            //await roleManager.CreateAsync(role2);
            //await roleManager.CreateAsync(role3);
            //Account acc = new Account
            //{
            //    Email = "admin@ju.edu.jo",
            //    FullName = "Jordanian University",
            //    UserName = "admin@ju.edu.jo"

            //};
            //await userManager.CreateAsync(acc, "JuAdmin_123");
            //Account acc1 = await userManager.FindByEmailAsync(acc.Email);
            //await userManager.AddToRoleAsync(acc1, "uniSupervisor");



            if (signInManager.IsSignedIn(User))
            {
                var user = await userManager.GetUserAsync(User);
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
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
