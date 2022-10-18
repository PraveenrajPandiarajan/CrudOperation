using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.Core.Model
{
    public class Student
    {
        public int Student_Id { get; set; }
       
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public string Course { get; set; }
     
        public string Phone { get; set; }
  
        public string Address { get; set; }

        public string Email_Id { get; set; }

        public string Password { get; set; }
 
        public string Retype_Password { get; set; }
        public bool Is_Deleted { get; set; }
        public DateTime Create_Time_Stamp { get; set; }
        public DateTime Update_Time_Stamp { get; set; }
    }
}
