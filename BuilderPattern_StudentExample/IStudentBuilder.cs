using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_StudentExample
{
    public interface IStudentBuilder
    {
        void SetName(string name);
        void SetGender(string gender);
        void SetRollNo(string rollno);
        Student GetStudent();
    }
}
