using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Student
    {
        string Name { get; set; }
        int Age { get; }

        int Height { get; }

        string DOB { get; }

        private Student() { }

        public  class StudentBuilder
        {
            private  readonly Student _student = new Student() ;

            public StudentBuilder SetName(string name)
            {
                _student.Name = name;
                return this;
            }

            public StudentBuilder()
            {
                _student = new Student();
            }

            public Student Build()
            {
                if(_student.Name == null)
                {
                    throw new InvalidOperationException("Name is required");
                }
                return _student;


            }

    }
}
