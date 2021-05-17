using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProposedExercise.Entities
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

        public Student(int id,string course)
        {
            this.Id = id;
            this.Course = course;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
                 return false;

            Student other = obj as Student;

            return Id.Equals(other.Id); 
        }
    }
}
