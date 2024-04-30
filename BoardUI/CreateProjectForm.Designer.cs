namespace BoardUI
{
    partial class CreateProjectForm
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
            CreateProjectHeader = new Label();
            ProjectNameLabel = new Label();
            ProjectTechnologyLabel = new Label();
            ProjectNameValue = new TextBox();
            ProjectTechnologyValue = new TextBox();
            CreateProjectButton = new Button();
            SuspendLayout();
            // 
            // CreateProjectHeader
            // 
            CreateProjectHeader.AutoSize = true;
            CreateProjectHeader.Location = new Point(241, 35);
            CreateProjectHeader.Name = "CreateProjectHeader";
            CreateProjectHeader.Size = new Size(157, 31);
            CreateProjectHeader.TabIndex = 0;
            CreateProjectHeader.Text = "Create Project";
            CreateProjectHeader.Click += label1_Click;
            // 
            // ProjectNameLabel
            // 
            ProjectNameLabel.AutoSize = true;
            ProjectNameLabel.ForeColor = SystemColors.MenuHighlight;
            ProjectNameLabel.Location = new Point(74, 115);
            ProjectNameLabel.Name = "ProjectNameLabel";
            ProjectNameLabel.Size = new Size(152, 31);
            ProjectNameLabel.TabIndex = 1;
            ProjectNameLabel.Text = "Project Name";
            // 
            // ProjectTechnologyLabel
            // 
            ProjectTechnologyLabel.AutoSize = true;
            ProjectTechnologyLabel.ForeColor = SystemColors.MenuHighlight;
            ProjectTechnologyLabel.Location = new Point(74, 177);
            ProjectTechnologyLabel.Name = "ProjectTechnologyLabel";
            ProjectTechnologyLabel.Size = new Size(130, 31);
            ProjectTechnologyLabel.TabIndex = 2;
            ProjectTechnologyLabel.Text = "Technology";
            // 
            // ProjectNameValue
            // 
            ProjectNameValue.BackColor = Color.LightCyan;
            ProjectNameValue.Location = new Point(314, 112);
            ProjectNameValue.Name = "ProjectNameValue";
            ProjectNameValue.Size = new Size(246, 38);
            ProjectNameValue.TabIndex = 3;
            // 
            // ProjectTechnologyValue
            // 
            ProjectTechnologyValue.BackColor = Color.LightCyan;
            ProjectTechnologyValue.Location = new Point(314, 174);
            ProjectTechnologyValue.Name = "ProjectTechnologyValue";
            ProjectTechnologyValue.Size = new Size(246, 38);
            ProjectTechnologyValue.TabIndex = 4;
            // 
            // CreateProjectButton
            // 
            CreateProjectButton.BackColor = SystemColors.HotTrack;
            CreateProjectButton.ForeColor = SystemColors.Window;
            CreateProjectButton.Location = new Point(190, 251);
            CreateProjectButton.Name = "CreateProjectButton";
            CreateProjectButton.Size = new Size(232, 76);
            CreateProjectButton.TabIndex = 5;
            CreateProjectButton.Text = "Create a project!";
            CreateProjectButton.UseVisualStyleBackColor = false;
            CreateProjectButton.Click += CreateProjectButton_Click;
            // 
            // CreateProjectForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 373);
            Controls.Add(CreateProjectButton);
            Controls.Add(ProjectTechnologyValue);
            Controls.Add(ProjectNameValue);
            Controls.Add(ProjectTechnologyLabel);
            Controls.Add(ProjectNameLabel);
            Controls.Add(CreateProjectHeader);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5);
            Name = "CreateProjectForm";
            Text = "CreateProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateProjectHeader;
        private Label ProjectNameLabel;
        private Label ProjectTechnologyLabel;
        private TextBox ProjectNameValue;
        private TextBox ProjectTechnologyValue;
        private Button CreateProjectButton;
    }
}