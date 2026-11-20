namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class DepartmentForm
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
            dataGridViewDepartments = new DataGridView();
            buttonDelete = new Button();
            buttonClose = new Button();
            buttonRefresh = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDepartments
            // 
            dataGridViewDepartments.AllowUserToAddRows = false;
            dataGridViewDepartments.AllowUserToDeleteRows = false;
            dataGridViewDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDepartments.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDepartments.Location = new Point(12, 12);
            dataGridViewDepartments.MultiSelect = false;
            dataGridViewDepartments.Name = "dataGridViewDepartments";
            dataGridViewDepartments.RowHeadersWidth = 51;
            dataGridViewDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDepartments.Size = new Size(776, 368);
            dataGridViewDepartments.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ControlLight;
            buttonDelete.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(390, 386);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 41);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.ControlLight;
            buttonClose.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(676, 398);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(118, 41);
            buttonClose.TabIndex = 9;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = false;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.ControlLight;
            buttonRefresh.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRefresh.Location = new Point(266, 386);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(118, 41);
            buttonRefresh.TabIndex = 8;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.ControlLight;
            buttonEdit.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(142, 386);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(118, 41);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonAdd.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(18, 386);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(118, 41);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClose);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewDepartments);
            Name = "DepartmentForm";
            Text = "Кафедры";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDepartments;
        private Button buttonDelete;
        private Button buttonClose;
        private Button buttonRefresh;
        private Button buttonEdit;
        private Button buttonAdd;
    }
}