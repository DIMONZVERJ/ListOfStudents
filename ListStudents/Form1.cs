using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace ListOfStudents
{
    public partial class Form1 : Form
    {
        List<Student> students; //текущий список студентов
        int pos;    //номер позиции студента, которого мы сейчас просматриваем
        public Form1()
        {
            InitializeComponent();
            Previous.Enabled = false;
            Previous_item.Enabled = false;
            Next.Enabled = false;
            Next_item.Enabled = false;
            deleteStudent.Enabled = false;
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
            Debug.Text = "Empty spisok is created";
        }

        private void OpenSpisokClick(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                InitialDirectory = @"D:\VSProject\ListOfStudents\ListStudents",
                DefaultExt = ".xml", // Default file extension
                AutoUpgradeEnabled = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filename = dlg.FileName;
                if (!dlg.SafeFileName.Contains(".xml") || string.IsNullOrEmpty(filename)) return;
                Debug.Text = "File is opened: " + filename;

                XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));

                using FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
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
            };

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

        private void PreviousItemClick(object sender, EventArgs e)
        {
            Previous_Click(sender, e);
        }

        private void NextItem_Click(object sender, EventArgs e)
        {
            Next_Click(sender, e);
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
                FirstNameTextBox.Text = string.Empty;
                SecondNameTextBox.Text = string.Empty;
                FacultyTextBox.Text = string.Empty;

                label_first_name.Text = string.Empty;
                label_first_name.Tag = -1;
                label_second_name.Text = string.Empty;
                label_second_name.Tag = -1;
                label_faculty.Text = string.Empty;
                label_faculty.Tag = -1;

                return;
            }
            FirstNameTextBox.Text = students[pos].FirstName;
            SecondNameTextBox.Text = students[pos].SecondName;
            FacultyTextBox.Text = students[pos].Faculty;
        }
        private void addStudentItem_Click(object sender, EventArgs e)//adding a new student
        {
            if ((int)label_first_name.Tag != 0 || (int)label_second_name.Tag != 0 || (int)label_faculty.Tag != 0) //if label is no empty then textobes is empty
            {
                Debug.Text = "Поля пустые";
                return;
            }
            if (students == null)
                students = new List<Student>();
            students.Add(new Student(FirstNameTextBox.Text, SecondNameTextBox.Text, FacultyTextBox.Text));
            pos = students.Count;

            FirstNameTextBox.Text = string.Empty;
            SecondNameTextBox.Text = string.Empty;
            FacultyTextBox.Text = string.Empty;

            Next.Enabled = false;
            Next_item.Enabled = false;
            Previous.Enabled = true;
            Previous_item.Enabled = true;

            label_first_name.Text = string.Empty;
            label_first_name.Tag = -1;
            label_second_name.Text = string.Empty;
            label_second_name.Tag = -1;
            label_faculty.Text = string.Empty;
            label_faculty.Tag = -1;
            Debug.Text = "Студент добавлен";
        }

        private void DeleteStudentClick(object sender, EventArgs e) //delete selected student
        {
            students.RemoveAt(pos);

            if (pos > 0) pos--;
            if (pos == 0)
            {
                Previous.Enabled = false;
                Previous_item.Enabled = false;
            }
            if (pos == (students.Count - 1))
            {
                Next.Enabled = false;
                Next_item.Enabled = false;
            }

            FirstNameTextBox.Text = students[pos].FirstName;
            SecondNameTextBox.Text = students[pos].SecondName;
            FacultyTextBox.Text = students[pos].Faculty;
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                label_first_name.Text = "Incorrect first name";
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
                label_second_name.Text = "Incorrect second name";
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
                label_faculty.Text = "Incorrect faculty";
                label_faculty.Tag = -1;
            }
            else
            {
                label_faculty.Text = string.Empty;
                label_faculty.Tag = 0;
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
