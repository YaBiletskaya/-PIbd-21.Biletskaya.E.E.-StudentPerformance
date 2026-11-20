namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class DepartmentEditForm
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
            textBoxHead = new TextBox();
            labelHead = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            labelTitle = new Label();
            labelFaculty = new Label();
            comboBoxFaculty = new ComboBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textBoxHead
            // 
            textBoxHead.ForeColor = SystemColors.GrayText;
            textBoxHead.Location = new Point(12, 235);
            textBoxHead.Name = "textBoxHead";
            textBoxHead.Size = new Size(489, 27);
            textBoxHead.TabIndex = 9;
            textBoxHead.Text = "Введите ФИО заведующего";
            // 
            // labelHead
            // 
            labelHead.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelHead.Location = new Point(12, 212);
            labelHead.Name = "labelHead";
            labelHead.Size = new Size(167, 20);
            labelHead.TabIndex = 8;
            labelHead.Text = "ФИО заведующего";
            // 
            // textBoxName
            // 
            textBoxName.ForeColor = SystemColors.GrayText;
            textBoxName.Location = new Point(12, 164);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(489, 27);
            textBoxName.TabIndex = 7;
            textBoxName.Text = "Введите название кафедры";
            // 
            // labelName
            // 
            labelName.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelName.Location = new Point(12, 141);
            labelName.Name = "labelName";
            labelName.Size = new Size(167, 20);
            labelName.TabIndex = 6;
            labelName.Text = "Название кафедры";
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(258, 28);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Информация о кафедре";
            // 
            // labelFaculty
            // 
            labelFaculty.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelFaculty.Location = new Point(12, 75);
            labelFaculty.Name = "labelFaculty";
            labelFaculty.Size = new Size(86, 20);
            labelFaculty.TabIndex = 10;
            labelFaculty.Text = "Факультет";
            // 
            // comboBoxFaculty
            // 
            comboBoxFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFaculty.ForeColor = SystemColors.ControlDarkDark;
            comboBoxFaculty.FormattingEnabled = true;
            comboBoxFaculty.Location = new Point(12, 98);
            comboBoxFaculty.Name = "comboBoxFaculty";
            comboBoxFaculty.Size = new Size(321, 28);
            comboBoxFaculty.TabIndex = 11;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(447, 281);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 39);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(337, 282);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(104, 39);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // DepartmentEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 333);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxFaculty);
            Controls.Add(labelFaculty);
            Controls.Add(textBoxHead);
            Controls.Add(labelHead);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DepartmentEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Данные кафедры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHead;
        private Label labelHead;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelTitle;
        private Label labelFaculty;
        private ComboBox comboBoxFaculty;
        private Button buttonCancel;
        private Button buttonSave;
    }
}