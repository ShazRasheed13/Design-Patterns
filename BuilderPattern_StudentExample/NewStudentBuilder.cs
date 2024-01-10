using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_StudentExample
{
    public class NewStudentBuilder: IStudentBuilder
    {
        private Student _student = new Student();
        public void SetName(string name)
        {
            _student.Name = name;
        }

        public void SetGender(string gender)
        {
            _student.Gender="Male";
        }

        public void SetRollNo(string rollno)
        {
            _student.RollNo = "123";
        }

        public Student GetStudent()
        {
            return _student;
        }
    }
}
