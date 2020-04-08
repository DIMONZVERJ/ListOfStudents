namespace ListOfStudents
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateSpisok = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSpicok = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSpisok = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Previous_item = new System.Windows.Forms.ToolStripMenuItem();
            this.Next_item = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.Faculty = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.FacultyTextBox = new System.Windows.Forms.TextBox();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.label_first_name = new System.Windows.Forms.Label();
            this.label_second_name = new System.Windows.Forms.Label();
            this.label_faculty = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.студентыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateSpisok,
            this.OpenSpicok,
            this.SaveSpisok});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // CreateSpisok
            // 
            this.CreateSpisok.Name = "CreateSpisok";
            this.CreateSpisok.Size = new System.Drawing.Size(224, 26);
            this.CreateSpisok.Text = "Создать список";
            this.CreateSpisok.Click += new System.EventHandler(this.CreateSpisokItem_Click);
            // 
            // OpenSpicok
            // 
            this.OpenSpicok.Name = "OpenSpicok";
            this.OpenSpicok.Size = new System.Drawing.Size(224, 26);
            this.OpenSpicok.Text = "Открыть список";
            this.OpenSpicok.Click += new System.EventHandler(this.OpenSpisokClick);
            // 
            // SaveSpisok
            // 
            this.SaveSpisok.Name = "SaveSpisok";
            this.SaveSpisok.Size = new System.Drawing.Size(224, 26);
            this.SaveSpisok.Text = "Сохранить список";
            this.SaveSpisok.Click += new System.EventHandler(this.SaveSpisokClick);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Previous_item,
            this.Next_item});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // Previus
            // 
            this.Previous_item.Name = "Previus";
            this.Previous_item.Size = new System.Drawing.Size(224, 26);
            this.Previous_item.Text = "Предыдущий";
            this.Previous_item.Click += new System.EventHandler(this.PreviousItemClick);
            // 
            // Next_item
            // 
            this.Next_item.Name = "Next_item";
            this.Next_item.Size = new System.Drawing.Size(224, 26);
            this.Next_item.Text = "Следующий";
            this.Next_item.Click += new System.EventHandler(this.NextItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudent,
            this.deleteStudent});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // addStudent
            // 
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(224, 26);
            this.addStudent.Text = "Добавить";
            this.addStudent.Click += new System.EventHandler(this.addStudentItem_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(224, 26);
            this.deleteStudent.Text = "Удалить";
            this.deleteStudent.Click += new System.EventHandler(this.DeleteStudentClick);
            // 
            // Debug
            // 
            this.Debug.AutoSize = true;
            this.Debug.Location = new System.Drawing.Point(12, 43);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(94, 17);
            this.Debug.TabIndex = 1;
            this.Debug.Text = "Информация";
            // 
            // SecondName
            // 
            this.SecondName.AutoSize = true;
            this.SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondName.Location = new System.Drawing.Point(188, 128);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(103, 25);
            this.SecondName.TabIndex = 2;
            this.SecondName.Text = "Фамилия";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(237, 77);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(54, 25);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "Имя";
            // 
            // Faculty
            // 
            this.Faculty.AutoSize = true;
            this.Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Faculty.Location = new System.Drawing.Point(174, 181);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(117, 25);
            this.Faculty.TabIndex = 4;
            this.Faculty.Text = "Факультет";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(297, 80);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(223, 22);
            this.FirstNameTextBox.TabIndex = 5;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(297, 132);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(223, 22);
            this.SecondNameTextBox.TabIndex = 6;
            this.SecondNameTextBox.TextChanged += new System.EventHandler(this.SecondNameTextBox_TextChanged);
            // 
            // FacultyTextBox
            // 
            this.FacultyTextBox.Location = new System.Drawing.Point(297, 181);
            this.FacultyTextBox.Name = "FacultyTextBox";
            this.FacultyTextBox.Size = new System.Drawing.Size(223, 22);
            this.FacultyTextBox.TabIndex = 7;
            this.FacultyTextBox.TextChanged += new System.EventHandler(this.FacultyTextBox_TextChanged);
            // 
            // Previous
            // 
            this.Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Previous.Location = new System.Drawing.Point(150, 257);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(210, 98);
            this.Previous.TabIndex = 8;
            this.Previous.Text = "Предыдущий";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(410, 257);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(210, 98);
            this.Next.TabIndex = 9;
            this.Next.Text = "Следующий";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Location = new System.Drawing.Point(542, 85);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(0, 17);
            this.label_first_name.TabIndex = 10;
            // 
            // label_second_name
            // 
            this.label_second_name.AutoSize = true;
            this.label_second_name.Location = new System.Drawing.Point(542, 137);
            this.label_second_name.Name = "label_second_name";
            this.label_second_name.Size = new System.Drawing.Size(0, 17);
            this.label_second_name.TabIndex = 11;
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Location = new System.Drawing.Point(542, 189);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(0, 17);
            this.label_faculty.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.label_faculty);
            this.Controls.Add(this.label_second_name);
            this.Controls.Add(this.label_first_name);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.FacultyTextBox);
            this.Controls.Add(this.SecondNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.Faculty);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Студенты";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateSpisok;
        private System.Windows.Forms.ToolStripMenuItem OpenSpicok;
        private System.Windows.Forms.ToolStripMenuItem SaveSpisok;
        private System.Windows.Forms.Label Debug;
        private System.Windows.Forms.ToolStripMenuItem Previous_item;
        private System.Windows.Forms.ToolStripMenuItem Next_item;
        private System.Windows.Forms.Label SecondName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label Faculty;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.TextBox FacultyTextBox;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.ToolStripMenuItem addStudent;
        private System.Windows.Forms.ToolStripMenuItem deleteStudent;
        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.Label label_second_name;
        private System.Windows.Forms.Label label_faculty;
    }
}

