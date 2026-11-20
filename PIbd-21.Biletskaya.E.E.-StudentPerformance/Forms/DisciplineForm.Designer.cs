namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class DisciplineForm
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
            dataGridViewDisciplines = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisciplines).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ControlLight;
            buttonDelete.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(384, 385);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 41);
            buttonDelete.TabIndex = 17;
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
            buttonClose.TabIndex = 16;
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
            buttonRefresh.TabIndex = 15;
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
            buttonEdit.TabIndex = 14;
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
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDisciplines
            // 
            dataGridViewDisciplines.AllowUserToAddRows = false;
            dataGridViewDisciplines.AllowUserToDeleteRows = false;
            dataGridViewDisciplines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDisciplines.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewDisciplines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDisciplines.GridColor = SystemColors.Info;
            dataGridViewDisciplines.Location = new Point(12, 12);
            dataGridViewDisciplines.MultiSelect = false;
            dataGridViewDisciplines.Name = "dataGridViewDisciplines";
            dataGridViewDisciplines.ReadOnly = true;
            dataGridViewDisciplines.RowHeadersWidth = 51;
            dataGridViewDisciplines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDisciplines.Size = new Size(776, 367);
            dataGridViewDisciplines.TabIndex = 12;
            // 
            // DisciplineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClose);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewDisciplines);
            Name = "DisciplineForm";
            Text = "Дисциплины";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisciplines).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDelete;
        private Button buttonClose;
        private Button buttonRefresh;
        private Button buttonEdit;
        private Button buttonAdd;
        private DataGridView dataGridViewDisciplines;
    }
}