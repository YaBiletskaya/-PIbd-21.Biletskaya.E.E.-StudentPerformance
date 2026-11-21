namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class TeacherEditForm
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
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            labelTitle = new Label();
            textBoxMiddleName = new TextBox();
            labelMiddleName = new Label();
            textBoxAcademicDegree = new TextBox();
            labelAcademicDegree = new Label();
            labelPosition = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            comboBoxPosition = new ComboBox();
            SuspendLayout();
            // 
            // textBoxLastName
            // 
            textBoxLastName.ForeColor = SystemColors.GrayText;
            textBoxLastName.Location = new Point(12, 165);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(489, 27);
            textBoxLastName.TabIndex = 9;
            textBoxLastName.Text = "Введите фамилию";
            // 
            // labelLastName
            // 
            labelLastName.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelLastName.Location = new Point(12, 142);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(167, 20);
            labelLastName.TabIndex = 8;
            labelLastName.Text = "Фамилия";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.ForeColor = SystemColors.GrayText;
            textBoxFirstName.Location = new Point(12, 101);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(489, 27);
            textBoxFirstName.TabIndex = 7;
            textBoxFirstName.Text = "Введите имя";
            // 
            // labelFirstName
            // 
            labelFirstName.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelFirstName.Location = new Point(12, 78);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(47, 20);
            labelFirstName.TabIndex = 6;
            labelFirstName.Text = "Имя";
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(292, 28);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Информация о преподавателе";
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.ForeColor = SystemColors.GrayText;
            textBoxMiddleName.Location = new Point(12, 227);
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Size = new Size(489, 27);
            textBoxMiddleName.TabIndex = 11;
            textBoxMiddleName.Text = "Введите отчество";
            // 
            // labelMiddleName
            // 
            labelMiddleName.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelMiddleName.Location = new Point(12, 204);
            labelMiddleName.Name = "labelMiddleName";
            labelMiddleName.Size = new Size(167, 20);
            labelMiddleName.TabIndex = 10;
            labelMiddleName.Text = "Отчество";
            // 
            // textBoxAcademicDegree
            // 
            textBoxAcademicDegree.ForeColor = SystemColors.GrayText;
            textBoxAcademicDegree.Location = new Point(12, 291);
            textBoxAcademicDegree.Name = "textBoxAcademicDegree";
            textBoxAcademicDegree.Size = new Size(489, 27);
            textBoxAcademicDegree.TabIndex = 13;
            textBoxAcademicDegree.Text = "Введите ученую степень";
            // 
            // labelAcademicDegree
            // 
            labelAcademicDegree.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelAcademicDegree.Location = new Point(12, 268);
            labelAcademicDegree.Name = "labelAcademicDegree";
            labelAcademicDegree.Size = new Size(167, 20);
            labelAcademicDegree.TabIndex = 12;
            labelAcademicDegree.Text = "Ученая степень";
            // 
            // labelPosition
            // 
            labelPosition.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelPosition.Location = new Point(12, 331);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(167, 20);
            labelPosition.TabIndex = 14;
            labelPosition.Text = "Должность";
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(407, 399);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 39);
            buttonCancel.TabIndex = 17;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(297, 400);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(104, 39);
            buttonSave.TabIndex = 16;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Location = new Point(12, 354);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(489, 28);
            comboBoxPosition.TabIndex = 18;
            // 
            // TeacherEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 444);
            Controls.Add(comboBoxPosition);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelPosition);
            Controls.Add(textBoxAcademicDegree);
            Controls.Add(labelAcademicDegree);
            Controls.Add(textBoxMiddleName);
            Controls.Add(labelMiddleName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TeacherEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Данные о преподавателе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private Label labelTitle;
        private TextBox textBoxMiddleName;
        private Label labelMiddleName;
        private TextBox textBoxAcademicDegree;
        private Label labelAcademicDegree;
        private Label labelPosition;
        private Button buttonCancel;
        private Button buttonSave;
        private ComboBox comboBoxPosition;
    }
}