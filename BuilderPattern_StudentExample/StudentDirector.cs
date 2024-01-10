using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_StudentExample
{
    public class StudentDirector
    {
        private IStudentBuilder _builder;

        public StudentDirector(IStudentBuilder builder)
        {
            _builder = builder;
        }

        public void BuildStudent(string Name,string Gender,string RollNo)
        {
            _builder.SetName(Name);
            _builder.SetGender(Gender);
            _builder.SetRollNo(RollNo);
        }
    }
}
