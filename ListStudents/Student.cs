using System;

namespace ListStudents
{

    [Serializable]
    public class Student    //класс для студентов
    {
        public string FirstName { get; set; }   //имя
        public string SecondName { get; set; } //фамилия
        public string Faculty { get; set; } //факультет
        public Student() { }
        public Student(string FirstName, string SecondName, string Faculty)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.Faculty = Faculty;
        }

    }
}
