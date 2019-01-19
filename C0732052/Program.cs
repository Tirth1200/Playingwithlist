using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732052
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation Mary = new StudentInformation("Marry", 3.9, 20);
            StudentInformation John = new StudentInformation("John", 2.0, 10);
            StudentInformation Mark = new StudentInformation("Mark", 0.2, 3);
            StudentInformation Steven = new StudentInformation("Steven", 2.9, 10);
            StudentInformation Cindy = new StudentInformation("Cindy", 3.8, 20);
        }
    }
    class StudentInformation
    {
        public string Name;
        public double GPA;
        public int Attendance;
        public StudentInformation(string aName,double aGPA,int aAttendance)
        {
            Name = aName;
            GPA = aGPA;
            Attendance = aAttendance;
        }
    }

}
