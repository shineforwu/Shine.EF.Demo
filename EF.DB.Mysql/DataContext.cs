using EF.DB.Mysql.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF.DB.Mysql
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connection = "Server=localhost;Port=3306;Database=demo; User=Xman;Password=nopassword";
            options.UseMySQL(connection);
        }

        public virtual DbSet<T_User> User { get; set; }
    }
}
