

namespace App_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Doc
    {
        public int Project_ID { get; set; }
        public int Doc_ID { get; set; }
        public string Doc_Name { get; set; }
        public string Doc_Description { get; set; }
        public System.DateTime Doc_Date { get; set; }
        public string Doc_Type { get; set; }
        public string Doc_URL { get; set; }
    }
}
