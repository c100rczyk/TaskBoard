namespace BoardUI
{
    partial class CreatePersonForm
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
            CreatePersonHeader = new Label();
            CreateFirstNameLabel = new Label();
            CreateLastNameLabel = new Label();
            CreateEmailLabel = new Label();
            CreateFirstNameValue = new TextBox();
            CreateLastNameValue = new TextBox();
            CreateEmailValue = new TextBox();
            CreatePersonButton = new Button();
            SuspendLayout();
            // 
            // CreatePersonHeader
            // 
            CreatePersonHeader.AutoSize = true;
            CreatePersonHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CreatePersonHeader.Location = new Point(175, 9);
            CreatePersonHeader.Margin = new Padding(5, 0, 5, 0);
            CreatePersonHeader.Name = "CreatePersonHeader";
            CreatePersonHeader.Size = new Size(228, 46);
            CreatePersonHeader.TabIndex = 0;
            CreatePersonHeader.Text = "Create Person";
            CreatePersonHeader.Click += label1_Click;
            // 
            // CreateFirstNameLabel
            // 
            CreateFirstNameLabel.AutoSize = true;
            CreateFirstNameLabel.ForeColor = SystemColors.MenuHighlight;
            CreateFirstNameLabel.Location = new Point(56, 111);
            CreateFirstNameLabel.Margin = new Padding(5, 0, 5, 0);
            CreateFirstNameLabel.Name = "CreateFirstNameLabel";
            CreateFirstNameLabel.Size = new Size(198, 31);
            CreateFirstNameLabel.TabIndex = 1;
            CreateFirstNameLabel.Text = "Person First Name";
            CreateFirstNameLabel.Click += label1_Click_1;
            // 
            // CreateLastNameLabel
            // 
            CreateLastNameLabel.AutoSize = true;
            CreateLastNameLabel.ForeColor = SystemColors.MenuHighlight;
            CreateLastNameLabel.Location = new Point(56, 186);
            CreateLastNameLabel.Margin = new Padding(5, 0, 5, 0);
            CreateLastNameLabel.Name = "CreateLastNameLabel";
            CreateLastNameLabel.Size = new Size(196, 31);
            CreateLastNameLabel.TabIndex = 2;
            CreateLastNameLabel.Text = "Person Last Name";
            CreateLastNameLabel.Click += label2_Click;
            // 
            // CreateEmailLabel
            // 
            CreateEmailLabel.AutoSize = true;
            CreateEmailLabel.ForeColor = SystemColors.MenuHighlight;
            CreateEmailLabel.Location = new Point(56, 261);
            CreateEmailLabel.Margin = new Padding(5, 0, 5, 0);
            CreateEmailLabel.Name = "CreateEmailLabel";
            CreateEmailLabel.Size = new Size(145, 31);
            CreateEmailLabel.TabIndex = 3;
            CreateEmailLabel.Text = "Email Adress";
            // 
            // CreateFirstNameValue
            // 
            CreateFirstNameValue.BackColor = Color.LightCyan;
            CreateFirstNameValue.Location = new Point(313, 111);
            CreateFirstNameValue.Name = "CreateFirstNameValue";
            CreateFirstNameValue.Size = new Size(239, 38);
            CreateFirstNameValue.TabIndex = 4;
            // 
            // CreateLastNameValue
            // 
            CreateLastNameValue.BackColor = Color.LightCyan;
            CreateLastNameValue.Location = new Point(313, 186);
            CreateLastNameValue.Name = "CreateLastNameValue";
            CreateLastNameValue.Size = new Size(239, 38);
            CreateLastNameValue.TabIndex = 5;
            // 
            // CreateEmailValue
            // 
            CreateEmailValue.BackColor = Color.LightCyan;
            CreateEmailValue.Location = new Point(313, 261);
            CreateEmailValue.Name = "CreateEmailValue";
            CreateEmailValue.Size = new Size(239, 38);
            CreateEmailValue.TabIndex = 6;
            // 
            // CreatePersonButton
            // 
            CreatePersonButton.BackColor = SystemColors.MenuHighlight;
            CreatePersonButton.ForeColor = SystemColors.Window;
            CreatePersonButton.Location = new Point(174, 338);
            CreatePersonButton.Name = "CreatePersonButton";
            CreatePersonButton.Size = new Size(259, 77);
            CreatePersonButton.TabIndex = 7;
            CreatePersonButton.Text = "Create Person";
            CreatePersonButton.UseVisualStyleBackColor = false;
            CreatePersonButton.Click += CreatePersonButton_Click;
            // 
            // CreatePersonForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(592, 447);
            Controls.Add(CreatePersonButton);
            Controls.Add(CreateEmailValue);
            Controls.Add(CreateLastNameValue);
            Controls.Add(CreateFirstNameValue);
            Controls.Add(CreateEmailLabel);
            Controls.Add(CreateLastNameLabel);
            Controls.Add(CreateFirstNameLabel);
            Controls.Add(CreatePersonHeader);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5);
            Name = "CreatePersonForm";
            Text = "CreatePersonForm";
            Load += CreatePersonForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatePersonHeader;
        private Label CreateFirstNameLabel;
        private Label CreateLastNameLabel;
        private Label CreateEmailLabel;
        private TextBox CreateFirstNameValue;
        private TextBox CreateLastNameValue;
        private TextBox CreateEmailValue;
        private Button CreatePersonButton;
    }
}