using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateLogin(int ID, string email, string password)
        {
            LoginModel data = new LoginModel
            {
                Id = ID,
                email = email,
                password = password,
            };
            string sql = @"insert into dbo.Login (Id, email, password) values(@Id, @email, @password);";
            return SQLDataAccess.SaveData(sql, data);
        }

        public static List<LoginModel> LoadLogin()
        {
            string sql = @"select Id, email, password from dbo.Login;";

            return SQLDataAccess.LoadData<LoginModel>(sql);
        }
    }
}
