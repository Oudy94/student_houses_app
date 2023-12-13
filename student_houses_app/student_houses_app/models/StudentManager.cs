using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.models
{
    public class StudentManager
    {
        public List<Student> students = new List<Student>;

        public void addStudent (Student student)
        {
            int verify = 1;

                foreach (Student s in this.students)
                    if (s == student) verify = 0;

            if (verify == 1) this.students.Add(student);
            else MessageBox.Show("Already added this student");

        }

    }
}
