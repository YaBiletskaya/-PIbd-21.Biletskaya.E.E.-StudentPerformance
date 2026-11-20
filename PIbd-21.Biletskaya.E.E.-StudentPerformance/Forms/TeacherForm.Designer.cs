namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class TeacherForm
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
            buttonDelete = new Button();
            buttonClose = new Button();
            buttonRefresh = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            dataGridViewTeachers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ControlLight;
            buttonDelete.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(384, 385);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 41);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.ControlLight;
            buttonClose.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(670, 397);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(118, 41);
            buttonClose.TabIndex = 10;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = false;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.ControlLight;
            buttonRefresh.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRefresh.Location = new Point(260, 385);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(118, 41);
            buttonRefresh.TabIndex = 9;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.ControlLight;
            buttonEdit.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(136, 385);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(118, 41);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonAdd.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(12, 385);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(118, 41);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTeachers
            // 
            dataGridViewTeachers.AllowUserToAddRows = false;
            dataGridViewTeachers.AllowUserToDeleteRows = false;
            dataGridViewTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTeachers.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers.GridColor = SystemColors.Info;
            dataGridViewTeachers.Location = new Point(12, 12);
            dataGridViewTeachers.MultiSelect = false;
            dataGridViewTeachers.Name = "dataGridViewTeachers";
            dataGridViewTeachers.ReadOnly = true;
            dataGridViewTeachers.RowHeadersWidth = 51;
            dataGridViewTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTeachers.Size = new Size(776, 367);
            dataGridViewTeachers.TabIndex = 6;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClose);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewTeachers);
            Name = "TeacherForm";
            Text = "Преподаватели";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDelete;
        private Button buttonClose;
        private Button buttonRefresh;
        private Button buttonEdit;
        private Button buttonAdd;
        private DataGridView dataGridViewTeachers;
    }
}