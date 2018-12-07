

namespace App_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Task
    {
        public int Task_ID { get; set; }
        public string Task_Name { get; set; }
        public string Task_Description { get; set; }
        public System.DateTime Task_Sart_Date { get; set; }
        public System.DateTime Task_End_Date { get; set; }
        public int Task_TM_ID { get; set; }
    }
}
