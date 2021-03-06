﻿CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [age] INT NOT NULL, 
    [attrition] NVARCHAR(50) NOT NULL, 
    [business_travel] NVARCHAR(50) NOT NULL, 
    [daily_rate] INT NOT NULL, 
    [department] NVARCHAR(50) NOT NULL, 
    [distanceFromHome] INT NOT NULL, 
    [education] NVARCHAR(50) NOT NULL, 
    [education_field] NVARCHAR(50) NOT NULL, 
    [employee_count] INT NOT NULL, 
    [employee_number] INT NOT NULL, 
    [envirnmental_satisfaction] INT NOT NULL, 
    [gender] NVARCHAR(50) NOT NULL, 
    [hourly_rate] INT NOT NULL, 
    [job_involvement] INT NOT NULL, 
    [job_level] INT NOT NULL, 
    [job_role] NVARCHAR(50) NOT NULL, 
    [job_satisfaction] INT NOT NULL, 
    [marital_status] NVARCHAR(50) NOT NULL, 
    [monthly_income] INT NOT NULL, 
    [monthly_rate] INT NOT NULL, 
    [numCompaniesWorked] INT NOT NULL, 
    [over_18] VARCHAR(50) NOT NULL, 
    [overtime] NVARCHAR(50) NOT NULL, 
    [percentageSalaryHike] INT NOT NULL, 
    [performance_rating] INT NOT NULL, 
    [relationship_satisfaction] INT NOT NULL, 
    [standard_hours] INT NOT NULL, 
    [stockOptionLevel] INT NOT NULL, 
    [totalWorkingYears] INT NOT NULL, 
    [trainingTimeLastYear] INT NOT NULL, 
    [workLifeBalance] INT NOT NULL, 
    [yearsAtCompany] INT NOT NULL, 
    [yearsInCurrentRole] INT NOT NULL, 
    [yearsSinceLastPromotion] INT NOT NULL, 
    [yearsWithCurrentManager] INT NOT NULL
)
