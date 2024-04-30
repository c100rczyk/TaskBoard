using BoardLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardUI
{
    public partial class CreateProjectForm : Form
    {
        public CreateProjectForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            using (var context = new BoardContext())
            {
                ProjectModel newProject = new ProjectModel();

                newProject.ProjectName = ProjectNameValue.Text;
                newProject.Technology = ProjectTechnologyValue.Text;

                context.Project.Add(newProject);
                context.SaveChanges();
            }

            ProjectNameValue.Text = "";
            ProjectTechnologyValue.Text = "";

            MessageBox.Show("Project saved successfully!");
            this.Close();

        }
    }
}
