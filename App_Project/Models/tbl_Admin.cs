

namespace App_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Admin
    {
        public int Admin_ID { get; set; }
        public string Admin_First_Name { get; set; }
        public string Admin_Last_Name { get; set; }
        public string Admin_Email_ID { get; set; }
        public string Admin_Phone_Number { get; set; }
        public string Admin_Address { get; set; }
        public string Admin_User_Name { get; set; }
        public string Admin_Password { get; set; }
    
        public virtual tbl_Admin tbl_Admin1 { get; set; }
        public virtual tbl_Admin tbl_Admin2 { get; set; }
    }
}
