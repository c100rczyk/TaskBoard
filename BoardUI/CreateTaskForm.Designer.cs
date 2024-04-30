namespace BoardUI
{
    partial class CreateTaskForm
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
            CreateTaskHeader = new Label();
            TaskTitleLabel = new Label();
            TaskDifficultyLevelLabel = new Label();
            TaskPersonsListLabel = new Label();
            TaskPersonListComboBox = new ComboBox();
            TaskDeadLineLabel = new Label();
            TaskDeadlineValue = new TextBox();
            TaskDifficultyLevelValue = new TextBox();
            TaskTitleValue = new TextBox();
            TaskProjectNameLabel = new Label();
            TaskCreateTaskButton = new Button();
            taskProjectNameComboBox = new ComboBox();
            SuspendLayout();
            // 
            // CreateTaskHeader
            // 
            CreateTaskHeader.AutoSize = true;
            CreateTaskHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CreateTaskHeader.Location = new Point(229, 20);
            CreateTaskHeader.Name = "CreateTaskHeader";
            CreateTaskHeader.Size = new Size(189, 46);
            CreateTaskHeader.TabIndex = 0;
            CreateTaskHeader.Text = "Create Task";
            CreateTaskHeader.Click += label1_Click;
            // 
            // TaskTitleLabel
            // 
            TaskTitleLabel.AutoSize = true;
            TaskTitleLabel.ForeColor = SystemColors.MenuHighlight;
            TaskTitleLabel.Location = new Point(77, 95);
            TaskTitleLabel.Name = "TaskTitleLabel";
            TaskTitleLabel.Size = new Size(132, 31);
            TaskTitleLabel.TabIndex = 1;
            TaskTitleLabel.Text = "Title of Task";
            // 
            // TaskDifficultyLevelLabel
            // 
            TaskDifficultyLevelLabel.AutoSize = true;
            TaskDifficultyLevelLabel.ForeColor = SystemColors.MenuHighlight;
            TaskDifficultyLevelLabel.Location = new Point(77, 143);
            TaskDifficultyLevelLabel.Name = "TaskDifficultyLevelLabel";
            TaskDifficultyLevelLabel.Size = new Size(169, 31);
            TaskDifficultyLevelLabel.TabIndex = 3;
            TaskDifficultyLevelLabel.Text = "Difficulty  Level";
            // 
            // TaskPersonsListLabel
            // 
            TaskPersonsListLabel.AutoSize = true;
            TaskPersonsListLabel.ForeColor = SystemColors.MenuHighlight;
            TaskPersonsListLabel.Location = new Point(77, 323);
            TaskPersonsListLabel.Name = "TaskPersonsListLabel";
            TaskPersonsListLabel.Size = new Size(156, 31);
            TaskPersonsListLabel.TabIndex = 4;
            TaskPersonsListLabel.Text = "Assign Person";
            // 
            // TaskPersonListComboBox
            // 
            TaskPersonListComboBox.BackColor = Color.LightCyan;
            TaskPersonListComboBox.FormattingEnabled = true;
            TaskPersonListComboBox.Location = new Point(313, 320);
            TaskPersonListComboBox.Name = "TaskPersonListComboBox";
            TaskPersonListComboBox.Size = new Size(242, 39);
            TaskPersonListComboBox.TabIndex = 5;
            TaskPersonListComboBox.SelectedIndexChanged += TaskPersonListComboBox_SelectedIndexChanged;
            // 
            // TaskDeadLineLabel
            // 
            TaskDeadLineLabel.AutoSize = true;
            TaskDeadLineLabel.ForeColor = SystemColors.MenuHighlight;
            TaskDeadLineLabel.Location = new Point(77, 190);
            TaskDeadLineLabel.Name = "TaskDeadLineLabel";
            TaskDeadLineLabel.Size = new Size(105, 31);
            TaskDeadLineLabel.TabIndex = 7;
            TaskDeadLineLabel.Text = "Deadline";
            // 
            // TaskDeadlineValue
            // 
            TaskDeadlineValue.BackColor = Color.LightCyan;
            TaskDeadlineValue.Location = new Point(313, 187);
            TaskDeadlineValue.Name = "TaskDeadlineValue";
            TaskDeadlineValue.Size = new Size(242, 38);
            TaskDeadlineValue.TabIndex = 8;
            TaskDeadlineValue.TextChanged += TaskDeadlineValue_TextChanged;
            // 
            // TaskDifficultyLevelValue
            // 
            TaskDifficultyLevelValue.BackColor = Color.LightCyan;
            TaskDifficultyLevelValue.Location = new Point(315, 137);
            TaskDifficultyLevelValue.Name = "TaskDifficultyLevelValue";
            TaskDifficultyLevelValue.Size = new Size(240, 38);
            TaskDifficultyLevelValue.TabIndex = 9;
            // 
            // TaskTitleValue
            // 
            TaskTitleValue.BackColor = Color.LightCyan;
            TaskTitleValue.Location = new Point(313, 88);
            TaskTitleValue.Name = "TaskTitleValue";
            TaskTitleValue.Size = new Size(242, 38);
            TaskTitleValue.TabIndex = 10;
            // 
            // TaskProjectNameLabel
            // 
            TaskProjectNameLabel.AutoSize = true;
            TaskProjectNameLabel.ForeColor = SystemColors.MenuHighlight;
            TaskProjectNameLabel.Location = new Point(77, 247);
            TaskProjectNameLabel.Name = "TaskProjectNameLabel";
            TaskProjectNameLabel.Size = new Size(152, 31);
            TaskProjectNameLabel.TabIndex = 11;
            TaskProjectNameLabel.Text = "Project Name";
            TaskProjectNameLabel.Click += TaskProjectNameLabel_Click;
            // 
            // TaskCreateTaskButton
            // 
            TaskCreateTaskButton.BackColor = SystemColors.HotTrack;
            TaskCreateTaskButton.ForeColor = Color.White;
            TaskCreateTaskButton.Location = new Point(214, 395);
            TaskCreateTaskButton.Name = "TaskCreateTaskButton";
            TaskCreateTaskButton.Size = new Size(204, 65);
            TaskCreateTaskButton.TabIndex = 13;
            TaskCreateTaskButton.Text = "Create Task";
            TaskCreateTaskButton.UseVisualStyleBackColor = false;
            TaskCreateTaskButton.Click += TaskCreateTaskButton_Click;
            // 
            // taskProjectNameComboBox
            // 
            taskProjectNameComboBox.FormattingEnabled = true;
            taskProjectNameComboBox.Location = new Point(313, 250);
            taskProjectNameComboBox.Name = "taskProjectNameComboBox";
            taskProjectNameComboBox.Size = new Size(242, 39);
            taskProjectNameComboBox.TabIndex = 14;
            taskProjectNameComboBox.SelectedIndexChanged += taskProjectNameValue_SelectedIndexChanged;
            // 
            // CreateTaskForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 490);
            Controls.Add(taskProjectNameComboBox);
            Controls.Add(TaskCreateTaskButton);
            Controls.Add(TaskProjectNameLabel);
            Controls.Add(TaskTitleValue);
            Controls.Add(TaskDifficultyLevelValue);
            Controls.Add(TaskDeadlineValue);
            Controls.Add(TaskDeadLineLabel);
            Controls.Add(TaskPersonListComboBox);
            Controls.Add(TaskPersonsListLabel);
            Controls.Add(TaskDifficultyLevelLabel);
            Controls.Add(TaskTitleLabel);
            Controls.Add(CreateTaskHeader);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5);
            Name = "CreateTaskForm";
            Text = "CreateTaskForm";
            Load += CreateTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTaskHeader;
        private Label TaskTitleLabel;
        private Label label3;
        private Label TaskDifficultyLevelLabel;
        private Label TaskPersonsListLabel;
        private ComboBox TaskPersonListComboBox;
        private Label TaskDeadLineLabel;
        private TextBox TaskDeadlineValue;
        private TextBox TaskDifficultyLevelValue;
        private TextBox TaskTitleValue;
        private Label TaskProjectNameLabel;
        private Button TaskCreateTaskButton;
        private ComboBox taskProjectNameComboBox;
    }
}