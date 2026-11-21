namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class TeachingAssignmentDisciplineEditForm
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
            comboBoxDiscipline = new ComboBox();
            comboBoxAssignment = new ComboBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            labelHours = new Label();
            labelDiscipline = new Label();
            labelAssignment = new Label();
            labelTitle = new Label();
            numericUpDownHours = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            SuspendLayout();
            // 
            // comboBoxDiscipline
            // 
            comboBoxDiscipline.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDiscipline.FormattingEnabled = true;
            comboBoxDiscipline.Location = new Point(12, 158);
            comboBoxDiscipline.Name = "comboBoxDiscipline";
            comboBoxDiscipline.Size = new Size(488, 28);
            comboBoxDiscipline.TabIndex = 50;
            // 
            // comboBoxAssignment
            // 
            comboBoxAssignment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAssignment.FormattingEnabled = true;
            comboBoxAssignment.Location = new Point(12, 91);
            comboBoxAssignment.Name = "comboBoxAssignment";
            comboBoxAssignment.Size = new Size(490, 28);
            comboBoxAssignment.TabIndex = 48;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(408, 265);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 39);
            buttonCancel.TabIndex = 47;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(298, 266);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(104, 39);
            buttonSave.TabIndex = 46;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelHours
            // 
            labelHours.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelHours.Location = new Point(12, 200);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(227, 20);
            labelHours.TabIndex = 45;
            labelHours.Text = "Количество часов";
            // 
            // labelDiscipline
            // 
            labelDiscipline.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelDiscipline.Location = new Point(12, 135);
            labelDiscipline.Name = "labelDiscipline";
            labelDiscipline.Size = new Size(167, 20);
            labelDiscipline.TabIndex = 44;
            labelDiscipline.Text = "Дисциплина";
            // 
            // labelAssignment
            // 
            labelAssignment.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelAssignment.Location = new Point(12, 68);
            labelAssignment.Name = "labelAssignment";
            labelAssignment.Size = new Size(210, 20);
            labelAssignment.TabIndex = 43;
            labelAssignment.Text = "Назначение преподаватель";
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(390, 28);
            labelTitle.TabIndex = 42;
            labelTitle.Text = "Добавление дисциплины к назначению";
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.Location = new Point(12, 223);
            numericUpDownHours.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(488, 27);
            numericUpDownHours.TabIndex = 51;
            numericUpDownHours.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TeachingAssignmentDisciplineEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 308);
            Controls.Add(numericUpDownHours);
            Controls.Add(comboBoxDiscipline);
            Controls.Add(comboBoxAssignment);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelHours);
            Controls.Add(labelDiscipline);
            Controls.Add(labelAssignment);
            Controls.Add(labelTitle);
            Name = "TeachingAssignmentDisciplineEditForm";
            Text = "Добавление дисциплины к назначению";
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxDiscipline;
        private ComboBox comboBoxAssignment;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelHours;
        private Label labelDiscipline;
        private Label labelAssignment;
        private Label labelTitle;
        private NumericUpDown numericUpDownHours;
    }
}