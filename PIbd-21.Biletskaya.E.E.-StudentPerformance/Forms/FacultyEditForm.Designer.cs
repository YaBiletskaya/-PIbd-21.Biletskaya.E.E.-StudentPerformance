namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class FacultyEditForm
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
            labelTitle = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            textBoxDean = new TextBox();
            labelDean = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            labelTitle.Location = new Point(24, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(258, 28);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "\tИнформация о факультете";
            // 
            // labelName
            // 
            labelName.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelName.Location = new Point(24, 76);
            labelName.Name = "labelName";
            labelName.Size = new Size(167, 20);
            labelName.TabIndex = 1;
            labelName.Text = "Название факультета";
            // 
            // textBoxName
            // 
            textBoxName.ForeColor = SystemColors.GrayText;
            textBoxName.Location = new Point(24, 99);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(489, 27);
            textBoxName.TabIndex = 2;
            textBoxName.Text = "Введите название факультета";
            // 
            // textBoxDean
            // 
            textBoxDean.ForeColor = SystemColors.GrayText;
            textBoxDean.Location = new Point(24, 183);
            textBoxDean.Name = "textBoxDean";
            textBoxDean.Size = new Size(489, 27);
            textBoxDean.TabIndex = 4;
            textBoxDean.Text = "Введите ФИО декана";
            // 
            // labelDean
            // 
            labelDean.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            labelDean.Location = new Point(24, 160);
            labelDean.Name = "labelDean";
            labelDean.Size = new Size(167, 20);
            labelDean.TabIndex = 3;
            labelDean.Text = "ФИО декана";
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(333, 268);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(104, 39);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(443, 267);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 39);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FacultyEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 311);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxDean);
            Controls.Add(labelDean);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FacultyEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Данные факультета";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxDean;
        private Label labelDean;
        private Button buttonSave;
        private Button buttonCancel;
    }
}