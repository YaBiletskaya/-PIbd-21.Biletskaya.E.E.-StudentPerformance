namespace PIbd_21.Biletskaya.E.E._StudentPerformance
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Справочники = new ContextMenuStrip(components);
            contextMenuStripGuide = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            факультетыToolStripMenuItem = new ToolStripMenuItem();
            кафедрыToolStripMenuItem = new ToolStripMenuItem();
            преподавателиToolStripMenuItem = new ToolStripMenuItem();
            дисциплиныToolStripMenuItem = new ToolStripMenuItem();
            студентыToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            назначенияПреподавателейToolStripMenuItem = new ToolStripMenuItem();
            дисциплиныПреподавателейtoolStripMenuItem = new ToolStripMenuItem();
            успеваемостьСтудентовToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Справочники
            // 
            Справочники.ImageScalingSize = new Size(20, 20);
            Справочники.Name = "Справочники";
            Справочники.Size = new Size(61, 4);
            // 
            // contextMenuStripGuide
            // 
            contextMenuStripGuide.ImageScalingSize = new Size(20, 20);
            contextMenuStripGuide.Name = "contextMenuStrip1";
            contextMenuStripGuide.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, операцииToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { факультетыToolStripMenuItem, кафедрыToolStripMenuItem, преподавателиToolStripMenuItem, дисциплиныToolStripMenuItem, студентыToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(117, 24);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // факультетыToolStripMenuItem
            // 
            факультетыToolStripMenuItem.Name = "факультетыToolStripMenuItem";
            факультетыToolStripMenuItem.Size = new Size(201, 26);
            факультетыToolStripMenuItem.Text = "Факультеты";
            факультетыToolStripMenuItem.Click += факультетыToolStripMenuItem_Click;
            // 
            // кафедрыToolStripMenuItem
            // 
            кафедрыToolStripMenuItem.Name = "кафедрыToolStripMenuItem";
            кафедрыToolStripMenuItem.Size = new Size(201, 26);
            кафедрыToolStripMenuItem.Text = "Кафедры";
            кафедрыToolStripMenuItem.Click += кафедрыToolStripMenuItem_Click;
            // 
            // преподавателиToolStripMenuItem
            // 
            преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            преподавателиToolStripMenuItem.Size = new Size(201, 26);
            преподавателиToolStripMenuItem.Text = "Преподаватели";
            преподавателиToolStripMenuItem.Click += преподавателиToolStripMenuItem_Click;
            // 
            // дисциплиныToolStripMenuItem
            // 
            дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            дисциплиныToolStripMenuItem.Size = new Size(201, 26);
            дисциплиныToolStripMenuItem.Text = "Дисциплины";
            дисциплиныToolStripMenuItem.Click += дисциплиныToolStripMenuItem_Click;
            // 
            // студентыToolStripMenuItem
            // 
            студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            студентыToolStripMenuItem.Size = new Size(201, 26);
            студентыToolStripMenuItem.Text = "Студенты";
            студентыToolStripMenuItem.Click += студентыToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { назначенияПреподавателейToolStripMenuItem, успеваемостьСтудентовToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(95, 24);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // назначенияПреподавателейToolStripMenuItem
            // 
            назначенияПреподавателейToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { дисциплиныПреподавателейtoolStripMenuItem });
            назначенияПреподавателейToolStripMenuItem.Name = "назначенияПреподавателейToolStripMenuItem";
            назначенияПреподавателейToolStripMenuItem.Size = new Size(296, 26);
            назначенияПреподавателейToolStripMenuItem.Text = "Назначения преподавателей";
            назначенияПреподавателейToolStripMenuItem.Click += назначенияПреподавателейToolStripMenuItem_Click;
            // 
            // дисциплиныПреподавателейtoolStripMenuItem
            // 
            дисциплиныПреподавателейtoolStripMenuItem.Name = "дисциплиныПреподавателейtoolStripMenuItem";
            дисциплиныПреподавателейtoolStripMenuItem.Size = new Size(301, 26);
            дисциплиныПреподавателейtoolStripMenuItem.Text = "Дисциплины преподавателей";
            дисциплиныПреподавателейtoolStripMenuItem.Click += дисциплиныПреподавателейtoolStripMenuItem_Click;
            // 
            // успеваемостьСтудентовToolStripMenuItem
            // 
            успеваемостьСтудентовToolStripMenuItem.Name = "успеваемостьСтудентовToolStripMenuItem";
            успеваемостьСтудентовToolStripMenuItem.Size = new Size(296, 26);
            успеваемостьСтудентовToolStripMenuItem.Text = "Успеваемость студентов";
            успеваемостьСтудентовToolStripMenuItem.Click += успеваемостьСтудентовToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Система учёта успеваемости студентов";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip Справочники;
        private ContextMenuStrip contextMenuStripGuide;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem факультетыToolStripMenuItem;
        private ToolStripMenuItem кафедрыToolStripMenuItem;
        private ToolStripMenuItem преподавателиToolStripMenuItem;
        private ToolStripMenuItem дисциплиныToolStripMenuItem;
        private ToolStripMenuItem студентыToolStripMenuItem;
        private ToolStripMenuItem назначенияПреподавателейToolStripMenuItem;
        private ToolStripMenuItem успеваемостьСтудентовToolStripMenuItem;
        private ToolStripMenuItem дисциплиныПреподавателейtoolStripMenuItem;
    }
}
