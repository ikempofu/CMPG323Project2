using DimensionDataCollab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.EmployeeProcessor;


namespace DimensionDataCollab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Sign Up.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(LoginModel model)
        { 
            if(ModelState.IsValid)
            {
                int recordsCreated =CreateLogin(24, model.email, model.password);
                return RedirectToAction("employee");
            }

            return View();
        }

        public ActionResult ViewEmployee()
        {
            ViewBag.Message = "Employees List.";

            var data = loadEmployee();
            List<employeeModel> employees = new List<employeeModel>();
            foreach(var row in data)
            {
                employees.Add(new employeeModel
                {
                    age = row.age,
                    attrition = row.attrition,
                    business_travel = row.business_travel,
                    daily_rate = row.daily_rate,
                    department = row.department,
                    distanceFromHome = row.distanceFromHome,
                    education = row.education,
                    education_field = row.education_field,
                    employee_count = row.employee_count,
                    employee_number = row.employee_number,
                    environmental_satisfaction = row.environmental_satisfaction,
                    gender = row.gender,
                    hourly_rate = row.hourly_rate,
                    job_involvement = row.job_involvement,
                    job_level = row.job_level,
                    job_role = row.job_role,
                    job_satisfaction = row.job_satisfaction,
                    marital_status = row.marital_status,
                    monthly_income = row.monthly_income,
                    monthly_rate = row.monthly_rate,
                    num_companies_worked = row.num_companies_worked,
                    over_18 = row.over_18,
                    overtime = row.overtime,
                    percentageSalaryHike = row.percentageSalaryHike,
                    performance_rating = row.performance_rating,
                    relationship_satisfaction = row.relationship_satisfaction,
                    standard_hours = row.standard_hours,
                    stockOptionLevel = row.stockOptionLevel,
                    totalWorkingYears = row.totalWorkingYears,
                    trainingTimeLastYear = row.trainingTimeLastYear,
                    workLifeBalance = row.workLifeBalance,
                    yearsAtCompany = row.yearsAtCompany,
                    yearsInCurrentRole = row.yearsInCurrentRole,
                    yearsSinceLastPromotion = row.yearsSinceLastPromotion,
                    yearsWithCurrentManager = row.yearsWithCurrentManager,


                });
            }

            return View();
        }


        public ActionResult Employee()
        {
            ViewBag.Message = "Employee.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Employee(employeeModel model)
        {
            if(ModelState.IsValid)
            {
                int recordsCreated = createEmployee(2, model.age, model.attrition, model.business_travel, model.daily_rate, model.department, model.distanceFromHome, model.education, model.education_field, model.employee_count, model.employee_number, model.environmental_satisfaction, model.gender, model.hourly_rate, model.job_involvement, model.job_level, model.job_role, model.job_satisfaction, model.marital_status, model.monthly_income, model.monthly_rate, model.num_companies_worked,model.overtime, model.over_18, model.percentageSalaryHike, model.performance_rating, model.relationship_satisfaction, model.standard_hours, model.stockOptionLevel, model.totalWorkingYears, model.trainingTimeLastYear, model.workLifeBalance, model.yearsAtCompany, model.yearsInCurrentRole, model.yearsSinceLastPromotion, model.yearsWithCurrentManager);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}