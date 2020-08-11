using EF.DB.Mysql.Database;
using EF.DB.Mysql.Repository;
using System;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            EFRepositoryBase<T_User> eFRepositoryBase = new EFRepositoryBase<T_User>();
            T_User user = new T_User();
            user.User_ID = "1235";
            user.Name = "SSSS";
            user.Remark = "1";
            int result= eFRepositoryBase.AddAsync(user).Result;
            user.Remark = "2";
            result= eFRepositoryBase.UpdateAsync(user).Result;
        }
    }
}
