using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    class EmployeeProcessor
    {
        public static int createEmployee(int Id, int age, string attrition, string business_travel, int daily_rate, string department,
            int distancefromHome, string education, string education_field, int employee_count,
            int employee_number, int environmental_satisfaction, string gender, int hourly_rate, int job_involvement, int job_level,
            string job_role, int job_satisfaction, string marital_status, int monthly_income,
            int monthly_rate, int numCompaniesWorked, string over_18, string overtime, int percentageSalaryHike, int performance_rating, int relationsatis, int standardHours, int stock, int totworkyears, int traininglastyear, int worklife, int yearscompany, int yearsrole, int yearslastpromo, int yearscurrman)
        {
            EmployeeModel data = new EmployeeModel
            {
                Id = Id,
                age = age,
                attrition = attrition,
                business_travel = business_travel,
                daily_rate = daily_rate,
                department = department,
                distanceFromHome = distancefromHome,
                education =education,
                education_field = education_field,
                employee_count = employee_count,
                employee_number = employee_number,
                environmental_satisfaction = environmental_satisfaction,
                gender = gender,
                hourly_rate = hourly_rate,
                job_involvement = job_involvement,
                job_level = job_level,
                job_role = job_role,
                job_satisfaction = job_satisfaction,
                marital_status = marital_status,
                monthly_income = monthly_income,
                monthly_rate = monthly_rate,
                num_companies_worked = numCompaniesWorked,
                over_18 = over_18,
                overtime = overtime,
                percentageSalaryHike = percentageSalaryHike,
                performance_rating = performance_rating,
                relationship_satisfaction = relationsatis,
                standard_hours =standardHours,
                stockOptionLevel = stock,
                totalWorkingYears = totworkyears,
                trainingTimeLastYear = traininglastyear,
                workLifeBalance = worklife,
                yearsAtCompany = yearscompany,
                yearsInCurrentRole = yearsrole,
                yearsSinceLastPromotion = yearslastpromo,
                yearsWithCurrentManager = yearscurrman,
                
            };
            string sql = @"insert into dbo.Employee (Id, age, attrition, business_travel, daily_rate, department, distanceFromHome, education, education_field, employee_count, employee_number, envirnmental_satisfaction, gender, hourly_rate, job_involvement, job_level, job_role, job_satisfaction, marital_status, monthly_income, monthly_rate, numCompaniesWorked, over_18, overtime, percentageSalaryHike, performance_rating, relationship_satisfaction, standard_hours, stockOptionLevel, totalWorkingYears, trainingtimeLastYear, workLifeBalance, yearsAtCompany, yearsInCurrentRole, yearsSinceLastPromotion, yearsWithCurrentManager) 
values(@Id, @age, @attrition, @business_travel, @daily_rate, @department, @distanceFromHome, @education, @education_field, @employee_count, @employee_number, @environmental_satisfaction, @gender, @hourly_rate, @job_involvement, @job_level, @job_role, @job_satisfaction, @marital_status, @monthly_income, @monthly_rate, @numCompaniesWorked, @over_18, @overtime, @percentageSalaryHike, @performance_rating, @relationship_satisfaction, @standard_hours, @stockOptionLevel, @totalWorkingYears, @trainingtimeLastYear, @workLifeBalance, @yearsAtCompany, @yearsInCurrentRole, @yearsSinceLastPromotion, @yearsWithCurrentManager);";
            return SQLDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> loadEmployee()
        {
            string sql = @"select Id, age, attrition, business_travel, daily_rate, department, distanceFromHome, education, education_field, employee_count, employee_number, envirnmental_satisfaction, gender, hourly_rate, job_involvement, job_level, job_role, job_satisfaction, marital_status, monthly_income, monthly_rate, numCompaniesWorked, over_18, overtime, percentageSalaryHike, performance_rating, relationship_satisfaction, standard_hours, stockOptionLevel, totalWorkingYears, trainingtimeLastYear, workLifeBalance, yearsAtCompany, yearsInCurrentRole, yearsSinceLastPromotion, yearsWithCurrentManager from dbo.Employee;";

            return SQLDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
