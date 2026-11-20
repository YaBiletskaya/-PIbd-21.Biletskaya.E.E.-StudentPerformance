namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class TeachingAssignmentDisciplineForm
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
            buttonAdd = new Button();
            dataGridViewAssignmentDisciplines = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignmentDisciplines).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ControlLight;
            buttonDelete.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(260, 385);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 41);
            buttonDelete.TabIndex = 28;
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
            buttonClose.TabIndex = 27;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = false;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.ControlLight;
            buttonRefresh.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRefresh.Location = new Point(136, 385);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(118, 41);
            buttonRefresh.TabIndex = 26;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonAdd.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(12, 385);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(118, 41);
            buttonAdd.TabIndex = 25;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAssignmentDisciplines
            // 
            dataGridViewAssignmentDisciplines.AllowUserToAddRows = false;
            dataGridViewAssignmentDisciplines.AllowUserToDeleteRows = false;
            dataGridViewAssignmentDisciplines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAssignmentDisciplines.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewAssignmentDisciplines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssignmentDisciplines.GridColor = SystemColors.Info;
            dataGridViewAssignmentDisciplines.Location = new Point(12, 12);
            dataGridViewAssignmentDisciplines.MultiSelect = false;
            dataGridViewAssignmentDisciplines.Name = "dataGridViewAssignmentDisciplines";
            dataGridViewAssignmentDisciplines.ReadOnly = true;
            dataGridViewAssignmentDisciplines.RowHeadersWidth = 51;
            dataGridViewAssignmentDisciplines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAssignmentDisciplines.Size = new Size(776, 367);
            dataGridViewAssignmentDisciplines.TabIndex = 24;
            // 
            // TeachingAssignmentDisciplineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClose);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewAssignmentDisciplines);
            Name = "TeachingAssignmentDisciplineForm";
            Text = "Дисциплины и назначения";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignmentDisciplines).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDelete;
        private Button buttonClose;
        private Button buttonRefresh;
        private Button buttonAdd;
        private DataGridView dataGridViewAssignmentDisciplines;
    }
}