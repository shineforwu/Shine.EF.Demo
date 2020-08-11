using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF.DB.Mysql.Database
{
    [Table("T_User")]
    public class T_User
    {
        
        [Key]
        public string User_ID { get; set; }

        public string Name { get; set; }
        public string Remark { get; set; }
    }
}
