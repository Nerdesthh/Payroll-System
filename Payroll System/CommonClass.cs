using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_System
{
    internal class CommonClass
    {
        //a list of class/variable that can be easily called from another internal class.
        //
        public static SeniorHigh PayrollSHS { get; set; }
        private static Form _currentOrigin;
        public static Form origin { get; set; }
        public static Dashboard MainBoard { get; set; }
        public static string Username { get; set; }
        public static Login Loginpage { get; set; }
        public static InputStaff Staffinput { get; set; }
        public static MainFunctionStaff Maincalc { get; set; }
        public static SendToStaff EmailNow { get; set; }   
        public static JuniorHigh PayrollJHS { get; set; }
        public static College PayrollCollege { get; set; }
        public static editadmin editadmin { get; set; }
        public static Login adminlogin { get; set; }
        public static Teachers teacherslogin { get; set; }
        public static Selection staffselection { get; set; }
        public static TeacherDashboard teacherdash { get; set;}
        public static string staffusernamedashboard { get; set; }
        public static string passwordadmin { get; set; }
        public static Image imagestaff { get; set; }
        public static string adminfullname { get; set; }
        public static string stafffolder { get; set; } 
        public static Teachercalc Teachercalc { get; set; }
        public static paysliphistory paysliphistory { get; set; }
        public static Credits credits { get; set; }
        public static Selection Selection { get; set; }
            

        //making a script that is full of a function to call a class that is common for the purpose of switching windows are efficient
        //reducing the risk of data loss, and ease of use -Carb Of Kill <333
    }
}
