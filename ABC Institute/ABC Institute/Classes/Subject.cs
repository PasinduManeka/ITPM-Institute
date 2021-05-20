using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPM.Classes
{
    class Subject
    {
        private String sub_name;
        private String sub_code;
        private String off_year;
        private String off_sem;
        private String no_of_lecH;
        private String no_of_tuteH;
        private String no_of_labH;
        private String no_of_evalH;
        private int id;


        public String SUB_name { get => sub_name; set => sub_name = value; }
        public String SUB_code { get => sub_code; set => sub_code = value; }
        public String OFF_year { get => off_year; set => off_year = value; }
        public String OFF_sem { get => off_sem; set => off_sem = value; }
        public String NO_of_lecH { get => no_of_lecH; set => no_of_lecH = value; }
        public String NO_of_tuteH { get => no_of_tuteH; set => no_of_tuteH = value; }
        public String NO_of_labH { get => no_of_labH; set => no_of_labH = value; }
        public String NO_of_evalH { get => no_of_evalH; set => no_of_evalH = value; }
        public int ID { get => id; set => id = value; }




    }
}
