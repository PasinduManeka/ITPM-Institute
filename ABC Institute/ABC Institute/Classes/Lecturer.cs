using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace ABC_Institute.Classes
{
    class Lecturer
    {


        private String lname;
        private String empID;
        private String faculty;
        private String department;
        private String center;
        private String building;
        private String level;
        private String rank;
        private int id;


        public String Name { get => lname; set => lname = value; }
        public String EmpID { get => empID; set => empID = value; }
        public String Faculty { get => faculty; set => faculty = value; }
        public String Department { get => department; set => department = value; }
        public String Center { get => center; set => center = value; }
        public String Building { get => building; set => building = value; }
        public String Level { get => level; set => level = value; }
        public String Rank { get => rank; set => rank = value; }
        public int Id { get => id; set => id = value; }

    }
}
