using System.Collections.Generic;
using ListOfStudents;

namespace ListStudents
{
    public class StudentsCollection : IMyEnumerable
    {
        public List<Student> students_list { get; private set; }

        private ConsistenlyOrder consistenlyOrder;
        private FilterOrder skipOneOrder;

        public Student Current => (Student)GetEnumerator().Current;

        private TypeOrder type_order = TypeOrder.ConsistenlyOrder;
        public StudentsCollection()
        {
            students_list = new List<Student>();
            consistenlyOrder = new ConsistenlyOrder(this);
            skipOneOrder = new FilterOrder(this);
        }
        public StudentsCollection(List<Student> students_list) : this()
        {
            this.students_list = students_list;
        }
        public void AddStudent(Student student)
        {
            students_list.Add(student);
        }

        public void SetOrder(TypeOrder typeOrder)
        {
            type_order = typeOrder;
        }

        public IMyIterator GetEnumerator()
        {
            if (type_order == 0)
                return consistenlyOrder;
            else
                return skipOneOrder;
        }
    }
}
