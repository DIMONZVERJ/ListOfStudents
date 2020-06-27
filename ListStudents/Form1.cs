using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Xml.Serialization;
using ListStudents;

namespace ListOfStudents
{
    enum TypeAction { Prev, Next};
    public partial class Form1 : Form
    {
        StudentsCollection students; //текущий список студентов
        bool need_updated = false;
        string file_name;
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateSpisokItem_Click(object sender, EventArgs e)
        {
            if (need_updated == true)
            {
                if (students != null)
                {
                    if (students.students_list.Count > 0)
                    {
                        DialogResult result = WantSaveList();
                        if (result == DialogResult.Yes)
                            SaveSpisokClick(sender, e);
                        else if (result == DialogResult.Cancel)
                            return;
                    }
                }
            }
            students = new StudentsCollection();
            need_updated = true;
            SetButtonEnable(TypeAction.Prev, false);
            SetButtonEnable(TypeAction.Next, false);
            toolStripLabelnfo.Text = "Пустой список создан";
        }

        private void OpenSpisokClick(object sender, EventArgs e)
        {
            if (need_updated == true)
            {
                DialogResult result = WantSaveList();
                if (result == DialogResult.Yes)
                    SaveSpisokClick(sender, e);
                else if (result == DialogResult.Cancel)
                    return;
            }
            dlg_open.InitialDirectory = Directory.GetCurrentDirectory();
            if (dlg_open.ShowDialog() == DialogResult.OK)
            {
                file_name = dlg_open.FileName;
                DirectoryInfo info = new DirectoryInfo(file_name);
                if (info.Extension != ".xml")
                {
                    toolStripLabelnfo.Text = "Файл имеет неверное расширение";
                    return;
                }
                toolStripLabelnfo.Text = "Файл открыт: " + info.Name;

                XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));

                using FileStream fs = new FileStream(file_name, FileMode.OpenOrCreate);
                try
                {
                    students = new StudentsCollection((List<Student>)formatter.Deserialize(fs));
                    need_updated = false;
                    SetButtonEnable(TypeAction.Prev, false);
                    deleteStudent.Enabled = true;

                    if (students.students_list.Count == 0)
                    {
                        deleteStudent.Enabled = false;
                        SetButtonEnable(TypeAction.Next, false);
                    }
                    else
                    {
                        button_update.Enabled = true;
                        deleteStudent.Enabled = true;
                        SetButtonEnable(TypeAction.Next, true);
                    }
                    if (students.GetEnumerator().MoveFirst())
                    {
                        FirstNameTextBox.Text = students.Current.FirstName;
                        SecondNameTextBox.Text = students.Current.SecondName;
                        FacultyTextBox.Text = students.Current.Faculty;
                    }

                }
                catch
                {
                    toolStripLabelnfo.Text = "Файл пустой";
                }
            }
        }

        private void SaveSpisokClick(object sender, EventArgs e)
        {
            dlg_save.InitialDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo info = new DirectoryInfo(file_name);
            dlg_save.FileName = info.Name ?? string.Empty;
            if (dlg_save.ShowDialog() == DialogResult.OK)
            {
                string file_name = dlg_save.FileName;
                toolStripLabelnfo.Text = "Файл сохранён: " + info.Name;
                XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
                using FileStream fs = new FileStream(file_name, FileMode.OpenOrCreate);
                formatter.Serialize(fs, students.students_list);
                need_updated = false;
            }
        }
        private void Previous_Click(object sender, EventArgs e)     //кнопка предыдущий на форме
        {
            button_update.Enabled = true;
            SetButtonEnable(TypeAction.Next, true);
            if (students.GetEnumerator().MovePrev())
            {
                FirstNameTextBox.Text = students.Current.FirstName;
                SecondNameTextBox.Text = students.Current.SecondName;
                FacultyTextBox.Text = students.Current.Faculty;
                if (students.GetEnumerator().IsFirst())
                    SetButtonEnable(TypeAction.Prev, false);
            }
            else
                SetButtonEnable(TypeAction.Prev, false);
        }

        private void Next_Click(object sender, EventArgs e)     //button next
        {
            SetButtonEnable(TypeAction.Prev, true);
            if (students.GetEnumerator().MoveNext())
            {
                FirstNameTextBox.Text = students.Current.FirstName;
                SecondNameTextBox.Text = students.Current.SecondName;
                FacultyTextBox.Text = students.Current.Faculty;
                if (students.GetEnumerator() is FilterOrder)
                    if (students.GetEnumerator().IsLast())
                    {
                        SetButtonEnable(TypeAction.Next, false);
                    }
            }
            else
            {
                button_update.Enabled = false;
                SetButtonEnable(TypeAction.Next, false);
                MoveToAddForm();
                return;
            }
        }
        private void addStudentItem_Click(object sender, EventArgs e) //adding a new student
        {
            if (Text_boxes_empty()) return;

            if (students == null)
                students = new StudentsCollection();
            if (students.GetEnumerator().Position + 1 >= students.students_list.Count)
            {
                students.AddStudent(new Student(FirstNameTextBox.Text, SecondNameTextBox.Text, FacultyTextBox.Text));
                students.GetEnumerator().MoveEnd();
                deleteStudent.Enabled = true;
                SetButtonEnable(TypeAction.Next, false);
                SetButtonEnable(TypeAction.Prev, true);
                need_updated = true;
                FirstNameTextBox.Focus();

                MoveToAddForm();

                toolStripLabelnfo.Text = "Студент добавлен";
            }
            else
                toolStripLabelnfo.Text = "Перейдите в поле для добавления";
        }

        private void DeleteStudentClick(object sender, EventArgs e) //delete selected student
        {
            if (students == null)
            {
                toolStripLabelnfo.Text = "список не инициализован";
                return;
            }
            if (Text_boxes_empty()) return;
            string first_name = FirstNameTextBox.Text;
            string second_name = SecondNameTextBox.Text;
            string faculty_name = FacultyTextBox.Text;

            int index = students.students_list.FindIndex(x => x.FirstName == first_name && x.SecondName == second_name && x.Faculty == faculty_name);
            if (index < 0)
            {
                toolStripLabelnfo.Text = "Элемент не найден";
                return;
            }
            students.students_list.RemoveAt(index);
            toolStripLabelnfo.Text = "Элемент удалён";
            if (students.students_list.Count == 0) //если удалили последнего студента
            {
                button_update.Enabled = false;
                SetButtonEnable(TypeAction.Prev, false);
                SetButtonEnable(TypeAction.Next, false);
                deleteStudent.Enabled = false;
                MoveToAddForm();
                return;
            }
            if (students.GetEnumerator().Position + 1 == (students.students_list.Count - 1) || students.GetEnumerator().Position == students.students_list.Count) //если удалили предпоследнего студента
            {
                if (students.students_list.Count == 1)
                {
                    SetButtonEnable(TypeAction.Prev, false);
                    SetButtonEnable(TypeAction.Next, false);
                }
                if (students.GetEnumerator().Position + 1 == students.students_list.Count) students.GetEnumerator().MovePrev();
            }
            need_updated = true;
            if (file_name != null) //если открыт файл, то обновить файл
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
                using FileStream fs = new FileStream(file_name, FileMode.Truncate);
                formatter.Serialize(fs, students);
                need_updated = false;
            }
            FirstNameTextBox.Text = students.Current.FirstName;
            SecondNameTextBox.Text = students.Current.SecondName;
            FacultyTextBox.Text = students.Current.Faculty;
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

        private void MoveToAddForm()
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

        private bool Text_boxes_empty()
        {
            if (int.Parse(label_first_name.Tag.ToString()) == -1 || int.Parse(label_second_name.Tag.ToString()) == -1 || int.Parse(label_faculty.Tag.ToString()) == -1)
            {
                toolStripLabelnfo.Text = "Поля пустые";
                return true;
            }
            return false;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if ((int)label_first_name.Tag == -1 || (int)label_second_name.Tag == -1 || (int)label_faculty.Tag == -1)
            {
                MessageBox.Show("не все поля заполнены", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                students.Current.FirstName = FirstNameTextBox.Text;
                students.Current.SecondName = SecondNameTextBox.Text;
                students.Current.Faculty = FacultyTextBox.Text;
                need_updated = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (need_updated == false) return;
            DialogResult result = WantSaveList();
            if (result == DialogResult.Cancel)
                e.Cancel = true;
            else if (result == DialogResult.Yes)
                SaveSpisokClick(sender, e);
        }
        private DialogResult WantSaveList()
        {
            return MessageBox.Show("Есть незафиксированные изменения, сохранить их?", "Информация",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void textBox_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (students == null) return;
                students.SetOrder(TypeOrder.FilterOrder);
                ((FilterOrder)students.GetEnumerator()).criteria_value = new Tuple<string, string>(comboBox_options.Text, textBox_value.Text);
                if (students.GetEnumerator().Position != -1 || students.GetEnumerator().MoveFirst())
                {
                    FirstNameTextBox.Text = students.Current.FirstName;
                    SecondNameTextBox.Text = students.Current.SecondName;
                    FacultyTextBox.Text = students.Current.Faculty;
                    if (students.GetEnumerator().IsFirst())
                        SetButtonEnable(TypeAction.Prev, false);
                    if (students.GetEnumerator().IsLast())
                        SetButtonEnable(TypeAction.Next, false);
                    else
                        SetButtonEnable(TypeAction.Next, true);
                }
                else
                {
                    toolStripLabelnfo.Text = "Поиск не дал результатов";
                    FirstNameTextBox.TextChanged -= FirstNameTextBox_TextChanged;
                    SecondNameTextBox.TextChanged -= SecondNameTextBox_TextChanged;
                    FacultyTextBox.TextChanged -= FacultyTextBox_TextChanged;
                    FirstNameTextBox.Text = string.Empty;
                    SecondNameTextBox.Text = string.Empty;
                    FacultyTextBox.Text = string.Empty;
                    SetButtonEnable(TypeAction.Next, false);
                    SetButtonEnable(TypeAction.Prev, false);
                    button_update.Enabled = false;
                }
            }
        }

        private void button_cancel_search_Click(object sender, EventArgs e)
        {
            students.SetOrder(TypeOrder.ConsistenlyOrder);
            if (students.GetEnumerator().Position != students.students_list.Count)
            {
                FirstNameTextBox.Text = students.Current.FirstName;
                SecondNameTextBox.Text = students.Current.SecondName;
                FacultyTextBox.Text = students.Current.Faculty;
                button_update.Enabled = true;
            }
            if (!students.GetEnumerator().IsFirst())
                SetButtonEnable(TypeAction.Prev, true);
            if (!students.GetEnumerator().IsLast())
                SetButtonEnable(TypeAction.Next, true);
            else
            {
                FirstNameTextBox.TextChanged -= FirstNameTextBox_TextChanged;
                SecondNameTextBox.TextChanged -= SecondNameTextBox_TextChanged;
                FacultyTextBox.TextChanged -= FacultyTextBox_TextChanged;
                FirstNameTextBox.Text = string.Empty;
                SecondNameTextBox.Text = string.Empty;
                FacultyTextBox.Text = string.Empty;
                button_update.Enabled = false;
            }
        }

        private void SetButtonEnable(TypeAction action, bool value)
        {
            if (action == TypeAction.Next)
            {
                Next.Enabled = value;
                Next_item.Enabled = value;
            }
            else if (action == TypeAction.Prev)
            {
                Previous.Enabled = value;
                Previous_item.Enabled = value;
            }
        }
    }
}
