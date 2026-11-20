namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class StudentEditForm
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
            buttonCancel = new Button();
            buttonSave = new Button();
            labelDepartment = new Label();
            labelTitle = new Label();
            comboBoxDepartment = new ComboBox();
            textBoxMiddleName = new TextBox();
            labelMiddleName = new Label();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            textBoxStudentNumber = new TextBox();
            labelStudentNumber = new Label();
            labelBirthDate = new Label();
            dateTimePickerBirthDate = new DateTimePicker();
            textBoxStreamName = new TextBox();
            labelStreamName = new Label();
            textBoxGroupName = new TextBox();
            labelGroupName = new Label();
            labelAdmissionYear = new Label();
            numericUpDownAdmissionYear = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdmissionYear).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(794, 350);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 39);
            buttonCancel.TabIndex = 35;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(684, 351);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(104, 39);
            buttonSave.TabIndex = 34;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelDepartment
            // 
            labelDepartment.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelDepartment.Location = new Point(12, 71);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(83, 20);
            labelDepartment.TabIndex = 30;
            labelDepartment.Text = "Кафедра";
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 23);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(292, 28);
            labelTitle.TabIndex = 29;
            labelTitle.Text = "Информация о студенте";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(12, 101);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(489, 28);
            comboBoxDepartment.TabIndex = 38;
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.ForeColor = SystemColors.GrayText;
            textBoxMiddleName.Location = new Point(12, 286);
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Size = new Size(489, 27);
            textBoxMiddleName.TabIndex = 44;
            textBoxMiddleName.Text = "Введите отчество";
            // 
            // labelMiddleName
            // 
            labelMiddleName.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelMiddleName.Location = new Point(12, 263);
            labelMiddleName.Name = "labelMiddleName";
            labelMiddleName.Size = new Size(167, 20);
            labelMiddleName.TabIndex = 43;
            labelMiddleName.Text = "Отчество";
            // 
            // textBoxLastName
            // 
            textBoxLastName.ForeColor = SystemColors.GrayText;
            textBoxLastName.Location = new Point(12, 224);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(489, 27);
            textBoxLastName.TabIndex = 42;
            textBoxLastName.Text = "Введите фамилию";
            // 
            // labelLastName
            // 
            labelLastName.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelLastName.Location = new Point(12, 201);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(167, 20);
            labelLastName.TabIndex = 41;
            labelLastName.Text = "Фамилия";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.ForeColor = SystemColors.GrayText;
            textBoxFirstName.Location = new Point(12, 160);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(489, 27);
            textBoxFirstName.TabIndex = 40;
            textBoxFirstName.Text = "Введите имя";
            // 
            // labelFirstName
            // 
            labelFirstName.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelFirstName.Location = new Point(12, 137);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(47, 20);
            labelFirstName.TabIndex = 39;
            labelFirstName.Text = "Имя";
            // 
            // textBoxStudentNumber
            // 
            textBoxStudentNumber.ForeColor = SystemColors.GrayText;
            textBoxStudentNumber.Location = new Point(596, 94);
            textBoxStudentNumber.Name = "textBoxStudentNumber";
            textBoxStudentNumber.Size = new Size(292, 27);
            textBoxStudentNumber.TabIndex = 46;
            textBoxStudentNumber.Text = "Введите номер студенческого билета";
            // 
            // labelStudentNumber
            // 
            labelStudentNumber.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelStudentNumber.Location = new Point(596, 71);
            labelStudentNumber.Name = "labelStudentNumber";
            labelStudentNumber.Size = new Size(221, 20);
            labelStudentNumber.TabIndex = 45;
            labelStudentNumber.Text = "Номер студенческого билета";
            // 
            // labelBirthDate
            // 
            labelBirthDate.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelBirthDate.Location = new Point(12, 336);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(221, 20);
            labelBirthDate.TabIndex = 47;
            labelBirthDate.Text = "Дата рождения";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthDate.Location = new Point(12, 359);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(489, 27);
            dateTimePickerBirthDate.TabIndex = 48;
            // 
            // textBoxStreamName
            // 
            textBoxStreamName.ForeColor = SystemColors.GrayText;
            textBoxStreamName.Location = new Point(596, 160);
            textBoxStreamName.Name = "textBoxStreamName";
            textBoxStreamName.Size = new Size(292, 27);
            textBoxStreamName.TabIndex = 50;
            textBoxStreamName.Text = "Введите поток";
            // 
            // labelStreamName
            // 
            labelStreamName.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelStreamName.Location = new Point(596, 137);
            labelStreamName.Name = "labelStreamName";
            labelStreamName.Size = new Size(221, 20);
            labelStreamName.TabIndex = 49;
            labelStreamName.Text = "Поток";
            // 
            // textBoxGroupName
            // 
            textBoxGroupName.ForeColor = SystemColors.GrayText;
            textBoxGroupName.Location = new Point(596, 224);
            textBoxGroupName.Name = "textBoxGroupName";
            textBoxGroupName.Size = new Size(292, 27);
            textBoxGroupName.TabIndex = 52;
            textBoxGroupName.Text = "Введите группу";
            // 
            // labelGroupName
            // 
            labelGroupName.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelGroupName.Location = new Point(596, 201);
            labelGroupName.Name = "labelGroupName";
            labelGroupName.Size = new Size(221, 20);
            labelGroupName.TabIndex = 51;
            labelGroupName.Text = "Группа";
            // 
            // labelAdmissionYear
            // 
            labelAdmissionYear.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelAdmissionYear.Location = new Point(596, 263);
            labelAdmissionYear.Name = "labelAdmissionYear";
            labelAdmissionYear.Size = new Size(221, 20);
            labelAdmissionYear.TabIndex = 53;
            labelAdmissionYear.Text = "Год поступления";
            // 
            // numericUpDownAdmissionYear
            // 
            numericUpDownAdmissionYear.Location = new Point(596, 287);
            numericUpDownAdmissionYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDownAdmissionYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDownAdmissionYear.Name = "numericUpDownAdmissionYear";
            numericUpDownAdmissionYear.Size = new Size(292, 27);
            numericUpDownAdmissionYear.TabIndex = 55;
            numericUpDownAdmissionYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // StudentEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 401);
            Controls.Add(numericUpDownAdmissionYear);
            Controls.Add(labelAdmissionYear);
            Controls.Add(textBoxGroupName);
            Controls.Add(labelGroupName);
            Controls.Add(textBoxStreamName);
            Controls.Add(labelStreamName);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(labelBirthDate);
            Controls.Add(textBoxStudentNumber);
            Controls.Add(labelStudentNumber);
            Controls.Add(textBoxMiddleName);
            Controls.Add(labelMiddleName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(comboBoxDepartment);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelDepartment);
            Controls.Add(labelTitle);
            Name = "StudentEditForm";
            Text = "Данные о студенте";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdmissionYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelDepartment;
        private Label labelTitle;
        private ComboBox comboBoxDepartment;
        private TextBox textBoxMiddleName;
        private Label labelMiddleName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private TextBox textBoxStudentNumber;
        private Label labelStudentNumber;
        private Label labelBirthDate;
        private DateTimePicker dateTimePickerBirthDate;
        private TextBox textBoxStreamName;
        private Label labelStreamName;
        private TextBox textBoxGroupName;
        private Label labelGroupName;
        private Label labelAdmissionYear;
        private NumericUpDown numericUpDownAdmissionYear;
    }
}