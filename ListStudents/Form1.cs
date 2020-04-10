using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ListOfStudents
{
    public partial class Form1 : Form
    {
        List<Student> students; //текущий список студентов
        int pos;    //номер позиции студента, которого мы сейчас просматриваем
        string file_name;
        public Form1()
        {
            InitializeComponent();
            Previous.Enabled = false;
            Previous_item.Enabled = false;
            Next.Enabled = false;
            Next_item.Enabled = false;
            label_first_name.Tag = -1;
            label_second_name.Tag = -1;
            label_faculty.Tag = -1;
        }
        private void CreateSpisokItem_Click(object sender, EventArgs e)
        {
            students = new List<Student>();

            Previous.Enabled = false;
            Previous_item.Enabled = false;
            Next.Enabled = false;
            Next_item.Enabled = false;
            Debug.Text = "Пустой список создан";
        }

        private void OpenSpisokClick(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                InitialDirectory = @"D:\VSProject\ListOfStudents\ListStudents",
                DefaultExt = ".xml", // Default file extension
                Filter = "xml files|*.xml",
                AutoUpgradeEnabled = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                file_name = dlg.FileName;
                if (!dlg.SafeFileName.Contains(".xml") || string.IsNullOrEmpty(file_name)) return;
                Debug.Text = "File is opened: " + file_name;

                XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));

                using FileStream fs = new FileStream(file_name, FileMode.OpenOrCreate);
                try
                {
                    students = (List<Student>)formatter.Deserialize(fs);
                    Previous_item.Enabled = false;
                    Previous.Enabled = false;
                    deleteStudent.Enabled = true;

                    pos = 0;
                    Next.Enabled = true;
                    Next_item.Enabled = true;
                    FirstNameTextBox.Text = students[pos].FirstName;
                    SecondNameTextBox.Text = students[pos].SecondName;
                    FacultyTextBox.Text = students[pos].Faculty;

                }
                catch
                {
                    Debug.Text = "Файл пустой";
                }
            }
        }

        private void SaveSpisokClick(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog
            {
                InitialDirectory = @"D:\VSProject\ListOfStudents\ListStudents",
                DefaultExt = ".xml", // Default file extension
                Filter = "xml files|*.xml"
            };
            if (file_name != null) dlg.FileName = file_name;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filename = dlg.FileName;
                if (!dlg.FileName.Contains(".xml")) return;
                Debug.Text = filename;
                XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
                using FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
                formatter.Serialize(fs, students);
            }
        }
        private void Previous_Click(object sender, EventArgs e)     //кнопка предыдущий на форме
        {
            pos--;
            if (pos == 0)
            {
                Previous.Enabled = false;
                Previous_item.Enabled = false;
            }
            Next.Enabled = true;
            Next_item.Enabled = true;
            FirstNameTextBox.Text = students[pos].FirstName;
            SecondNameTextBox.Text = students[pos].SecondName;
            FacultyTextBox.Text = students[pos].Faculty;
        }

        private void Next_Click(object sender, EventArgs e)     //button next
        {
            Previous.Enabled = true;
            Previous_item.Enabled = true;
            pos++;
            if (pos == students.Count) //если в списке больше нет элементов, то очистить поля ввода
            {
                Next.Enabled = false;
                Next_item.Enabled = false;
                MakingEmptyLabel();

                return;
            }
            FirstNameTextBox.Text = students[pos].FirstName;
            SecondNameTextBox.Text = students[pos].SecondName;
            FacultyTextBox.Text = students[pos].Faculty;
        }
        private void addStudentItem_Click(object sender, EventArgs e)//adding a new student
        {
            Check_text_boxes();
            if (students == null)
                students = new List<Student>();
            students.Add(new Student(FirstNameTextBox.Text, SecondNameTextBox.Text, FacultyTextBox.Text));
            pos = students.Count;

            Next.Enabled = false;
            Next_item.Enabled = false;
            Previous.Enabled = true;
            Previous_item.Enabled = true;

            MakingEmptyLabel();

            Debug.Text = "Студент добавлен";
        }

        private void DeleteStudentClick(object sender, EventArgs e) //delete selected student
        {
            if (students == null)
            {
                Debug.Text = "список не инициализован";
                return;
            }
            Check_text_boxes();
            string first_name = FirstNameTextBox.Text;
            string second_name = SecondNameTextBox.Text;
            string faculty_name = FacultyTextBox.Text;

            int index = students.FindIndex(x => x.FirstName == first_name && x.SecondName == second_name && x.Faculty == faculty_name);
            if (index < 0)
            {
                Debug.Text = "Элемент не найден";
                return;
            }
            students.RemoveAt(index);
            pos = index;
            if (students.Count == 0) //если удалили последнего студента
            {
                Previous.Enabled = false;
                Previous_item.Enabled = false;
                Next.Enabled = false;
                Next_item.Enabled = false;

                MakingEmptyLabel();
                return;
            }
            if (pos == (students.Count - 1)) //если удалили предпоследнего студента
            {
                if (students.Count == 1)
                {
                    Previous.Enabled = false;
                    Previous_item.Enabled = false;
                }
            }
            if (pos == students.Count) //если удалили последнего студента в списке
            {
                if (students.Count == 1)
                {
                    Previous.Enabled = false;
                    Previous_item.Enabled = false;
                }
                pos--;
            }

            FirstNameTextBox.Text = students[pos].FirstName;
            SecondNameTextBox.Text = students[pos].SecondName;
            FacultyTextBox.Text = students[pos].Faculty;
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                label_first_name.Text = "Некорректное имя";
                label_first_name.Tag = -1;
            }
            else
            {
                label_first_name.Text = string.Empty;
                label_first_name.Tag = 0;
            }
        }

        private void SecondNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SecondNameTextBox.Text))
            {
                label_second_name.Text = "Некорректная фамилия";
                label_second_name.Tag = -1;
            }
            else
            {
                label_second_name.Text = string.Empty;
                label_second_name.Tag = 0;
            }
        }

        private void FacultyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FacultyTextBox.Text))
            {
                label_faculty.Text = "Некорректный факультет";
                label_faculty.Tag = -1;
            }
            else
            {
                label_faculty.Text = string.Empty;
                label_faculty.Tag = 0;
            }
        }

        private void MakingEmptyLabel()
        {
            FirstNameTextBox.Text = string.Empty;
            SecondNameTextBox.Text = string.Empty;
            FacultyTextBox.Text = string.Empty;

            label_first_name.Text = string.Empty;
            label_second_name.Text = string.Empty;
            label_faculty.Text = string.Empty;
            label_first_name.Tag = -1;
            label_second_name.Tag = -1;
            label_faculty.Tag = -1;
        }

        private void Check_text_boxes()
        {
            if ((int)label_first_name.Tag == -1 || (int)label_second_name.Tag == -1 || (int)label_faculty.Tag == -1)
            {
                Debug.Text = "Поля пустые";
                return;
            }
        }
    }

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
