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
                Debug.Text = filename;

                XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));

                using FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
                try
                {
                    students = (List<Student>)formatter.Deserialize(fs);
                    foreach (Student a in students)
                        Debug.Text += a.FirstName + " " + a.SecondName + " " + a.Faculty + " ";
                    Previous.Enabled = false;

                    FirstNameTextBox.Text = students[0].FirstName;
                    SecondNameTextBox.Text = students[0].SecondName;
                    FacultyTextBox.Text = students[0].Faculty;
                }
                catch (Exception exp)
                {
                    Debug.Text = exp.Message;
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

        private void Next_Click(object sender, EventArgs e)     //кнопка следующий на форме
        {
            pos++;
            if (pos == (students.Count - 1))
            {
                Next.Enabled = false;
                Next_item.Enabled = false;
            }
            Previous.Enabled = true;
            Previous_item.Enabled = true;
            FirstNameTextBox.Text = students[pos].FirstName;
            SecondNameTextBox.Text = students[pos].SecondName;
            FacultyTextBox.Text = students[pos].Faculty;
        }
        private void addStudentItem_Click(object sender, EventArgs e)//добавление нового студента
        {
            if (students == null)
                students = new List<Student>();
            if (label_first_name.Text == string.Empty || label_second_name.Text == string.Empty || label_faculty.Text == string.Empty)
            {
                Debug.Text = "Поля пустые";
                return;
            }
            students.Add(new Student(FirstNameTextBox.Text, SecondNameTextBox.Text, FacultyTextBox.Text));
            pos = students.Count - 1;

            Next.Enabled = false;
            Next_item.Enabled = false;

            if (pos != 0)
            {
                Previous.Enabled = true;
                Previous_item.Enabled = true;
            }
            Debug.Text = "Информация";
        }

        private void DeleteStudentClick(object sender, EventArgs e) //удаление выбранного студента
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
                label_first_name.Text = "Incorrect first name";
            else
                label_first_name.Text = string.Empty;
        }

        private void SecondNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SecondNameTextBox.Text))
                label_second_name.Text = "Incorrect second name";
            else
                label_second_name.Text = string.Empty;
        }

        private void FacultyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FacultyTextBox.Text))
                label_faculty.Text = "Incorrect faculty";
            else
                label_faculty.Text = string.Empty;
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
