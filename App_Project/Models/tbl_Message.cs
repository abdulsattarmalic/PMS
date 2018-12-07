

namespace App_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Message
    {
        public int Message_ID { get; set; }
        public string Message_Name { get; set; }
        public string Message_Description { get; set; }
        public System.DateTime Message_Date { get; set; }
    }
}
