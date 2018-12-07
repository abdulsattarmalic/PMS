
namespace App_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_PM
    {
        public int PM_ID { get; set; }
        public string PM_First_Name { get; set; }
        public string PM_Last_Name { get; set; }
        public string PM_Email_ID { get; set; }
        public decimal PM_Phone_Number { get; set; }
        public string PM_Address { get; set; }
        public string PM_User_Name { get; set; }
        public string PM_Password { get; set; }
    }
}
