namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class DisciplineEditForm
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
            labelCredits = new Label();
            labelHours = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            labelTitle = new Label();
            numericUpDownHours = new NumericUpDown();
            numericUpDownCredits = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCredits).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(407, 303);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 39);
            buttonCancel.TabIndex = 26;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(297, 304);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(104, 39);
            buttonSave.TabIndex = 25;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += this.buttonSave_Click;
            // 
            // labelCredits
            // 
            labelCredits.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelCredits.Location = new Point(12, 230);
            labelCredits.Name = "labelCredits";
            labelCredits.Size = new Size(227, 20);
            labelCredits.TabIndex = 23;
            labelCredits.Text = "Количество зачётных единиц";
            // 
            // labelHours
            // 
            labelHours.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelHours.Location = new Point(12, 152);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(167, 20);
            labelHours.TabIndex = 21;
            labelHours.Text = "Количество часов";
            // 
            // textBoxName
            // 
            textBoxName.ForeColor = SystemColors.GrayText;
            textBoxName.Location = new Point(12, 94);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(489, 27);
            textBoxName.TabIndex = 20;
            textBoxName.Text = "Введите название";
            // 
            // labelName
            // 
            labelName.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelName.Location = new Point(12, 71);
            labelName.Name = "labelName";
            labelName.Size = new Size(83, 20);
            labelName.TabIndex = 19;
            labelName.Text = "Название";
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 23);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(292, 28);
            labelTitle.TabIndex = 18;
            labelTitle.Text = "Информация о дисциплине";
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.Location = new Point(12, 175);
            numericUpDownHours.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(490, 27);
            numericUpDownHours.TabIndex = 27;
            numericUpDownHours.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownCredits
            // 
            numericUpDownCredits.DecimalPlaces = 1;
            numericUpDownCredits.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDownCredits.Location = new Point(12, 253);
            numericUpDownCredits.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownCredits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCredits.Name = "numericUpDownCredits";
            numericUpDownCredits.Size = new Size(489, 27);
            numericUpDownCredits.TabIndex = 28;
            numericUpDownCredits.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DisciplineEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 354);
            Controls.Add(numericUpDownCredits);
            Controls.Add(numericUpDownHours);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelCredits);
            Controls.Add(labelHours);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisciplineEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Данные о дисциплине";
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCredits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonSave;
        private Label labelCredits;
        private Label labelHours;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelTitle;
        private NumericUpDown numericUpDownHours;
        private NumericUpDown numericUpDownCredits;
    }
}