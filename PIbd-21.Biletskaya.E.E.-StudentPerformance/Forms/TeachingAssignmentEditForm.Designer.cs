namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class TeachingAssignmentEditForm
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
            labelDate = new Label();
            labelDepartment = new Label();
            labelTeacher = new Label();
            labelTitle = new Label();
            comboBoxTeacher = new ComboBox();
            dateTimePickerAssignmentDate = new DateTimePicker();
            comboBoxDepartment = new ComboBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(408, 265);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 39);
            buttonCancel.TabIndex = 35;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(298, 266);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(104, 39);
            buttonSave.TabIndex = 34;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelDate
            // 
            labelDate.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelDate.Location = new Point(12, 200);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(227, 20);
            labelDate.TabIndex = 33;
            labelDate.Text = "Дата назначения";
            // 
            // labelDepartment
            // 
            labelDepartment.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelDepartment.Location = new Point(12, 135);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(167, 20);
            labelDepartment.TabIndex = 32;
            labelDepartment.Text = "Кафедра";
            // 
            // labelTeacher
            // 
            labelTeacher.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelTeacher.Location = new Point(12, 68);
            labelTeacher.Name = "labelTeacher";
            labelTeacher.Size = new Size(126, 20);
            labelTeacher.TabIndex = 30;
            labelTeacher.Text = "Преподаватель";
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(292, 28);
            labelTitle.TabIndex = 29;
            labelTitle.Text = "Назначение преподавателя";
            // 
            // comboBoxTeacher
            // 
            comboBoxTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTeacher.FormattingEnabled = true;
            comboBoxTeacher.Location = new Point(12, 91);
            comboBoxTeacher.Name = "comboBoxTeacher";
            comboBoxTeacher.Size = new Size(490, 28);
            comboBoxTeacher.TabIndex = 38;
            // 
            // dateTimePickerAssignmentDate
            // 
            dateTimePickerAssignmentDate.Format = DateTimePickerFormat.Short;
            dateTimePickerAssignmentDate.Location = new Point(12, 223);
            dateTimePickerAssignmentDate.Name = "dateTimePickerAssignmentDate";
            dateTimePickerAssignmentDate.Size = new Size(489, 27);
            dateTimePickerAssignmentDate.TabIndex = 40;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(12, 158);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(488, 28);
            comboBoxDepartment.TabIndex = 41;
            // 
            // TeachingAssignmentEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 310);
            Controls.Add(comboBoxDepartment);
            Controls.Add(dateTimePickerAssignmentDate);
            Controls.Add(comboBoxTeacher);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelDate);
            Controls.Add(labelDepartment);
            Controls.Add(labelTeacher);
            Controls.Add(labelTitle);
            Name = "TeachingAssignmentEditForm";
            Text = "Данные назначения преподавателя";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelDate;
        private Label labelDepartment;
        private Label labelTeacher;
        private Label labelTitle;
        private ComboBox comboBoxTeacher;
        private DateTimePicker dateTimePickerAssignmentDate;
        private ComboBox comboBoxDepartment;
    }
}