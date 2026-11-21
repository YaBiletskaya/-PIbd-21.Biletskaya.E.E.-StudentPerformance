namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class AcademicPerformanceEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxAssignmentDiscipline = new ComboBox();
            comboBoxStudent = new ComboBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            labelAcademicYear = new Label();
            labelAssignmentDiscipline = new Label();
            labelStudent = new Label();
            labelTitle = new Label();
            comboBoxSemester = new ComboBox();
            labelSemester = new Label();
            numericUpDownGrade = new NumericUpDown();
            labelGrade = new Label();
            labelAssessmentDate = new Label();
            dateTimePickerAssessmentDate = new DateTimePicker();
            labelOptions = new Label();
            checkedListBoxOptions = new CheckedListBox();
            textBoxAcademicYear = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            SuspendLayout();
            // 
            // comboBoxAssignmentDiscipline
            // 
            comboBoxAssignmentDiscipline.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAssignmentDiscipline.FormattingEnabled = true;
            comboBoxAssignmentDiscipline.Location = new Point(12, 147);
            comboBoxAssignmentDiscipline.Name = "comboBoxAssignmentDiscipline";
            comboBoxAssignmentDiscipline.Size = new Size(488, 28);
            comboBoxAssignmentDiscipline.TabIndex = 59;
            // 
            // comboBoxStudent
            // 
            comboBoxStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStudent.FormattingEnabled = true;
            comboBoxStudent.Location = new Point(12, 80);
            comboBoxStudent.Name = "comboBoxStudent";
            comboBoxStudent.Size = new Size(490, 28);
            comboBoxStudent.TabIndex = 58;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(659, 329);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 39);
            buttonCancel.TabIndex = 57;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(549, 330);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(104, 39);
            buttonSave.TabIndex = 56;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelAcademicYear
            // 
            labelAcademicYear.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelAcademicYear.Location = new Point(559, 57);
            labelAcademicYear.Name = "labelAcademicYear";
            labelAcademicYear.Size = new Size(103, 20);
            labelAcademicYear.TabIndex = 55;
            labelAcademicYear.Text = "Учебный год";
            // 
            // labelAssignmentDiscipline
            // 
            labelAssignmentDiscipline.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelAssignmentDiscipline.Location = new Point(12, 124);
            labelAssignmentDiscipline.Name = "labelAssignmentDiscipline";
            labelAssignmentDiscipline.Size = new Size(227, 20);
            labelAssignmentDiscipline.TabIndex = 54;
            labelAssignmentDiscipline.Text = "Дисциплина и преподаватель";
            // 
            // labelStudent
            // 
            labelStudent.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelStudent.Location = new Point(12, 57);
            labelStudent.Name = "labelStudent";
            labelStudent.Size = new Size(210, 20);
            labelStudent.TabIndex = 53;
            labelStudent.Text = "Студент";
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(390, 28);
            labelTitle.TabIndex = 52;
            labelTitle.Text = "Информация об успеваемости";
            // 
            // comboBoxSemester
            // 
            comboBoxSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemester.FormattingEnabled = true;
            comboBoxSemester.Location = new Point(12, 215);
            comboBoxSemester.Name = "comboBoxSemester";
            comboBoxSemester.Size = new Size(488, 28);
            comboBoxSemester.TabIndex = 62;
            // 
            // labelSemester
            // 
            labelSemester.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelSemester.Location = new Point(12, 192);
            labelSemester.Name = "labelSemester";
            labelSemester.Size = new Size(227, 20);
            labelSemester.TabIndex = 61;
            labelSemester.Text = "Семестр";
            // 
            // numericUpDownGrade
            // 
            numericUpDownGrade.Location = new Point(559, 147);
            numericUpDownGrade.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownGrade.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.Size = new Size(194, 27);
            numericUpDownGrade.TabIndex = 64;
            numericUpDownGrade.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // labelGrade
            // 
            labelGrade.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelGrade.Location = new Point(559, 124);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(83, 20);
            labelGrade.TabIndex = 63;
            labelGrade.Text = "Оценка";
            // 
            // labelAssessmentDate
            // 
            labelAssessmentDate.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelAssessmentDate.Location = new Point(12, 262);
            labelAssessmentDate.Name = "labelAssessmentDate";
            labelAssessmentDate.Size = new Size(227, 20);
            labelAssessmentDate.TabIndex = 65;
            labelAssessmentDate.Text = "Дата выставления оценки";
            // 
            // dateTimePickerAssessmentDate
            // 
            dateTimePickerAssessmentDate.Format = DateTimePickerFormat.Short;
            dateTimePickerAssessmentDate.Location = new Point(12, 285);
            dateTimePickerAssessmentDate.Name = "dateTimePickerAssessmentDate";
            dateTimePickerAssessmentDate.Size = new Size(490, 27);
            dateTimePickerAssessmentDate.TabIndex = 66;
            // 
            // labelOptions
            // 
            labelOptions.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelOptions.Location = new Point(549, 192);
            labelOptions.Name = "labelOptions";
            labelOptions.Size = new Size(227, 20);
            labelOptions.TabIndex = 67;
            labelOptions.Text = "Дополнительные параметры";
            // 
            // checkedListBoxOptions
            // 
            checkedListBoxOptions.CheckOnClick = true;
            checkedListBoxOptions.ForeColor = SystemColors.GrayText;
            checkedListBoxOptions.FormattingEnabled = true;
            checkedListBoxOptions.Location = new Point(549, 215);
            checkedListBoxOptions.Name = "checkedListBoxOptions";
            checkedListBoxOptions.Size = new Size(214, 92);
            checkedListBoxOptions.TabIndex = 68;
            // 
            // textBoxAcademicYear
            // 
            textBoxAcademicYear.ForeColor = SystemColors.GrayText;
            textBoxAcademicYear.Location = new Point(559, 81);
            textBoxAcademicYear.Name = "textBoxAcademicYear";
            textBoxAcademicYear.Size = new Size(194, 27);
            textBoxAcademicYear.TabIndex = 69;
            textBoxAcademicYear.Text = "2026-2027";
            // 
            // AcademicPerformanceEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 374);
            Controls.Add(textBoxAcademicYear);
            Controls.Add(checkedListBoxOptions);
            Controls.Add(labelOptions);
            Controls.Add(dateTimePickerAssessmentDate);
            Controls.Add(labelAssessmentDate);
            Controls.Add(numericUpDownGrade);
            Controls.Add(labelGrade);
            Controls.Add(comboBoxSemester);
            Controls.Add(labelSemester);
            Controls.Add(comboBoxAssignmentDiscipline);
            Controls.Add(comboBoxStudent);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelAcademicYear);
            Controls.Add(labelAssignmentDiscipline);
            Controls.Add(labelStudent);
            Controls.Add(labelTitle);
            Name = "AcademicPerformanceEditForm";
            Text = "Данные об успеваемости";
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxAssignmentDiscipline;
        private ComboBox comboBoxStudent;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelAcademicYear;
        private Label labelAssignmentDiscipline;
        private Label labelStudent;
        private Label labelTitle;
        private ComboBox comboBoxSemester;
        private Label labelSemester;
        private NumericUpDown numericUpDownGrade;
        private Label labelGrade;
        private Label labelAssessmentDate;
        private DateTimePicker dateTimePickerAssessmentDate;
        private Label labelOptions;
        private CheckedListBox checkedListBoxOptions;
        private TextBox textBoxAcademicYear;
    }
}