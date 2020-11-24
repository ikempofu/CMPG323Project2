using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DimensionDataCollab.Models.employeeModel))]

namespace DimensionDataCollab.Models
{
    public class employeeModel
    {
        public int age { get; set; }
        public string attrition { get; set; }
        public string business_travel{ get; set; }
        public int daily_rate { get; set; }
        public string department{ get; set; }
        public int distanceFromHome { get; set; }
        public string education { get; set; }
        public string education_field { get; set; }
        public int employee_count { get; set; }
        public int employee_number { get; set; }
        public int environmental_satisfaction { get; set; }
        public string gender { get; set; }
        public int hourly_rate{ get; set; }
        public int job_involvement { get; set; }
        public int job_level { get; set; }
        public string job_role { get; set; }
        public int job_satisfaction { get; set; }
        public string marital_status{ get; set; }
        public int monthly_income{ get; set; }
        public int monthly_rate { get; set; }
        public int num_companies_worked{ get; set; }
        public string over_18 { get; set; }
        public string overtime{ get; set; }
        public int percentageSalaryHike{ get; set; }
        public int performance_rating { get; set; }
        public int relationship_satisfaction{ get; set; }
        public int standard_hours { get; set; }
        public int stockOptionLevel { get; set; }
        public int totalWorkingYears { get; set; }
        public int trainingTimeLastYear { get; set; }
        public int workLifeBalance { get; set; }
        public int yearsAtCompany { get; set; }
        public int yearsInCurrentRole { get; set; }
        public int yearsSinceLastPromotion { get; set; }
        public int yearsWithCurrentManager { get; set; }
    }
}
