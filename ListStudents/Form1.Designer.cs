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
            this.SaveSpisok = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSpicok = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Previous_item = new System.Windows.Forms.ToolStripMenuItem();
            this.Next_item = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudent = new System.Windows.Forms.ToolStripMenuItem();
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
            this.statusStrip_state = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelnfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlg_open = new System.Windows.Forms.OpenFileDialog();
            this.dlg_save = new System.Windows.Forms.SaveFileDialog();
            this.button_update = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.comboBox_options = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.button_cancel_search = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip_state.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(674, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateSpisok,
            this.SaveSpisok,
            this.OpenSpicok});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // CreateSpisok
            // 
            this.CreateSpisok.Name = "CreateSpisok";
            this.CreateSpisok.Size = new System.Drawing.Size(249, 26);
            this.CreateSpisok.Text = "Создать новый список";
            this.CreateSpisok.Click += new System.EventHandler(this.CreateSpisokItem_Click);
            // 
            // SaveSpisok
            // 
            this.SaveSpisok.Name = "SaveSpisok";
            this.SaveSpisok.Size = new System.Drawing.Size(249, 26);
            this.SaveSpisok.Text = "Сохранить список";
            this.SaveSpisok.Click += new System.EventHandler(this.SaveSpisokClick);
            // 
            // OpenSpicok
            // 
            this.OpenSpicok.Name = "OpenSpicok";
            this.OpenSpicok.Size = new System.Drawing.Size(249, 26);
            this.OpenSpicok.Text = "Открыть список";
            this.OpenSpicok.Click += new System.EventHandler(this.OpenSpisokClick);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Previous_item,
            this.Next_item});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // Previous_item
            // 
            this.Previous_item.Enabled = false;
            this.Previous_item.Name = "Previous_item";
            this.Previous_item.Size = new System.Drawing.Size(184, 26);
            this.Previous_item.Text = "Предыдущий";
            this.Previous_item.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next_item
            // 
            this.Next_item.Enabled = false;
            this.Next_item.Name = "Next_item";
            this.Next_item.Size = new System.Drawing.Size(184, 26);
            this.Next_item.Text = "Следующий";
            this.Next_item.Click += new System.EventHandler(this.Next_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudent,
            this.deleteStudent});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // addStudent
            // 
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(159, 26);
            this.addStudent.Text = "Добавить";
            this.addStudent.Click += new System.EventHandler(this.addStudentItem_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Enabled = false;
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(159, 26);
            this.deleteStudent.Text = "Удалить";
            this.deleteStudent.Click += new System.EventHandler(this.DeleteStudentClick);
            // 
            // SecondName
            // 
            this.SecondName.AutoSize = true;
            this.SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondName.Location = new System.Drawing.Point(124, 123);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(103, 25);
            this.SecondName.TabIndex = 2;
            this.SecondName.Text = "Фамилия";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(173, 72);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(54, 25);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "Имя";
            // 
            // Faculty
            // 
            this.Faculty.AutoSize = true;
            this.Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Faculty.Location = new System.Drawing.Point(110, 176);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(117, 25);
            this.Faculty.TabIndex = 4;
            this.Faculty.Text = "Факультет";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(233, 75);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(223, 22);
            this.FirstNameTextBox.TabIndex = 5;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(233, 127);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(223, 22);
            this.SecondNameTextBox.TabIndex = 6;
            this.SecondNameTextBox.TextChanged += new System.EventHandler(this.SecondNameTextBox_TextChanged);
            // 
            // FacultyTextBox
            // 
            this.FacultyTextBox.Location = new System.Drawing.Point(233, 176);
            this.FacultyTextBox.Name = "FacultyTextBox";
            this.FacultyTextBox.Size = new System.Drawing.Size(223, 22);
            this.FacultyTextBox.TabIndex = 7;
            this.FacultyTextBox.TextChanged += new System.EventHandler(this.FacultyTextBox_TextChanged);
            // 
            // Previous
            // 
            this.Previous.Enabled = false;
            this.Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Previous.Location = new System.Drawing.Point(47, 252);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(148, 59);
            this.Previous.TabIndex = 8;
            this.Previous.Text = "Предыдущий";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Next.Location = new System.Drawing.Point(216, 252);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(148, 59);
            this.Next.TabIndex = 9;
            this.Next.Text = "Следующий";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Location = new System.Drawing.Point(478, 80);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(0, 17);
            this.label_first_name.TabIndex = 10;
            this.label_first_name.Tag = "-1";
            // 
            // label_second_name
            // 
            this.label_second_name.AutoSize = true;
            this.label_second_name.Location = new System.Drawing.Point(478, 132);
            this.label_second_name.Name = "label_second_name";
            this.label_second_name.Size = new System.Drawing.Size(0, 17);
            this.label_second_name.TabIndex = 11;
            this.label_second_name.Tag = "-1";
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Location = new System.Drawing.Point(478, 184);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(0, 17);
            this.label_faculty.TabIndex = 12;
            this.label_faculty.Tag = "-1";
            // 
            // statusStrip_state
            // 
            this.statusStrip_state.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_state.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelnfo});
            this.statusStrip_state.Location = new System.Drawing.Point(0, 417);
            this.statusStrip_state.Name = "statusStrip_state";
            this.statusStrip_state.Size = new System.Drawing.Size(674, 22);
            this.statusStrip_state.TabIndex = 13;
            this.statusStrip_state.Text = "statusStrip1";
            // 
            // toolStripLabelnfo
            // 
            this.toolStripLabelnfo.Name = "toolStripLabelnfo";
            this.toolStripLabelnfo.Size = new System.Drawing.Size(0, 16);
            // 
            // dlg_open
            // 
            this.dlg_open.DefaultExt = "xml";
            this.dlg_open.Filter = "xml files|*.xml|all files|*.*";
            // 
            // dlg_save
            // 
            this.dlg_save.DefaultExt = "xml";
            this.dlg_save.Filter = "xml files|*.xml";
            this.dlg_save.InitialDirectory = "D:\\VSProject\\ListOfStudents\\ListStudents";
            // 
            // button_update
            // 
            this.button_update.Enabled = false;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button_update.Location = new System.Drawing.Point(384, 252);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(148, 59);
            this.button_update.TabIndex = 14;
            this.button_update.Text = "Обновить студента";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search.Location = new System.Drawing.Point(43, 324);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(64, 24);
            this.label_search.TabIndex = 15;
            this.label_search.Text = "Поиск";
            // 
            // comboBox_options
            // 
            this.comboBox_options.FormattingEnabled = true;
            this.comboBox_options.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Факультет"});
            this.comboBox_options.Location = new System.Drawing.Point(47, 362);
            this.comboBox_options.Name = "comboBox_options";
            this.comboBox_options.Size = new System.Drawing.Size(180, 24);
            this.comboBox_options.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "=";
            // 
            // textBox_value
            // 
            this.textBox_value.Location = new System.Drawing.Point(257, 364);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(180, 22);
            this.textBox_value.TabIndex = 18;
            this.textBox_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_value_KeyPress);
            // 
            // button_cancel_search
            // 
            this.button_cancel_search.Location = new System.Drawing.Point(443, 362);
            this.button_cancel_search.Name = "button_cancel_search";
            this.button_cancel_search.Size = new System.Drawing.Size(138, 23);
            this.button_cancel_search.TabIndex = 19;
            this.button_cancel_search.Text = "Отменить поиск";
            this.button_cancel_search.UseVisualStyleBackColor = true;
            this.button_cancel_search.Click += new System.EventHandler(this.button_cancel_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 439);
            this.Controls.Add(this.button_cancel_search);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_options);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.statusStrip_state);
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Студенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip_state.ResumeLayout(false);
            this.statusStrip_state.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip_state;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelnfo;
        private System.Windows.Forms.OpenFileDialog dlg_open;
        private System.Windows.Forms.SaveFileDialog dlg_save;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox_options;
        public System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Button button_cancel_search;
    }
}

