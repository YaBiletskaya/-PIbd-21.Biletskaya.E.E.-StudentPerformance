namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    partial class FacultyForm
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
            dataGridViewFaculties = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonRefresh = new Button();
            buttonClose = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFaculties).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFaculties
            // 
            dataGridViewFaculties.AllowUserToAddRows = false;
            dataGridViewFaculties.AllowUserToDeleteRows = false;
            dataGridViewFaculties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFaculties.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewFaculties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFaculties.GridColor = SystemColors.Info;
            dataGridViewFaculties.Location = new Point(12, 12);
            dataGridViewFaculties.MultiSelect = false;
            dataGridViewFaculties.Name = "dataGridViewFaculties";
            dataGridViewFaculties.ReadOnly = true;
            dataGridViewFaculties.RowHeadersWidth = 51;
            dataGridViewFaculties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFaculties.Size = new Size(776, 367);
            dataGridViewFaculties.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonAdd.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(12, 385);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(118, 41);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.ControlLight;
            buttonEdit.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(136, 385);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(118, 41);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.ControlLight;
            buttonRefresh.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRefresh.Location = new Point(260, 385);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(118, 41);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.ControlLight;
            buttonClose.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(670, 397);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(118, 41);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ControlLight;
            buttonDelete.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(384, 385);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 41);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // FacultyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClose);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewFaculties);
            Name = "FacultyForm";
            Text = "Факультеты";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFaculties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewFaculties;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonRefresh;
        private Button buttonClose;
        private Button buttonDelete;
    }
}