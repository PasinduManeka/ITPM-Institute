using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Institute.Classes
{
    class Session
    {
        private String slec1;
        private String slec2;
        private String tag;
        private String sgroup;
        private String ssubj;
        private String scode;
        private String noofstudent;
        private String duration;
        private String msession;
        private int id;

        public String Slec1 { get => slec1; set => slec1 = value; }

        public String Slec2 { get => slec2; set => slec2 = value; }

        public String Tag { get => tag; set => tag = value; }

        public String Sgroup { get => sgroup; set => sgroup = value; }

        public String Ssubj { get => ssubj; set => ssubj = value; }

        public String Scode { get => scode; set => scode = value; }

        public String OnOfStudent { get => noofstudent; set => noofstudent = value; }

        public String Duration { get => duration; set => duration = value; }

        public String Msession { get => msession; set => msession = value; }

        public int ID { get => id; set => id = value; }




    }
}
