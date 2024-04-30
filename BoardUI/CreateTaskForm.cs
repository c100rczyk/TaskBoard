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
    public partial class CreateTaskForm : Form
    {
        private List<PersonModel> availablePersons = new List<PersonModel>();
        private List<ProjectModel> availableProjects = new List<ProjectModel>();
        private List<PersonModel> selectedPersons = new List<PersonModel>();


        public CreateTaskForm()
        {
            InitializeComponent();
            //CreateSampleData();
            LoadPersonsFromDataBase();
            WireUpLists();
        }

        //private void CreateSampleData()
        //{
        //    availablePersons.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
        //    availablePersons.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

        //    selectedPersons.Add(new PersonModel { FirstName = "joe", LastName = "Smith" });
        //    selectedPersons.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        //}

        private void LoadPersonsFromDataBase()
        {
            using (var context = new BoardContext())
            {
                availablePersons = context.Persons.ToList();
                availableProjects = context.Project.ToList();
            }
        }

        private void WireUpLists()
        {
            TaskPersonListComboBox.DataSource = availablePersons;
            taskProjectNameComboBox.DataSource = availableProjects;

            TaskPersonListComboBox.DisplayMember = "FullName";
            taskProjectNameComboBox.DisplayMember = "ProjectName";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TaskCreateTaskButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                using (var context = new BoardContext())
                {
                    TaskModel newTask = new TaskModel();

                    newTask.Title = TaskTitleValue.Text;
                    newTask.DifLevel = TaskDifficultyLevelValue.Text;
                    newTask.AssignedTo = TaskPersonListComboBox.Text;
                    newTask.Deadline = TaskDeadlineValue.Text;
                    newTask.ProjectName = taskProjectNameComboBox.Text;
                    newTask.Status = "To Do";

                    context.Tasks.Add(newTask);
                    context.SaveChanges();
                    //RefreshToDoList();
                }
                TaskTitleValue.Text = "";
                TaskDifficultyLevelValue.Text = "";
                TaskPersonListComboBox.Text = "";
                TaskDeadlineValue.Text = "";
                taskProjectNameComboBox.Text = "";

                MessageBox.Show("Task saved successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid form of data");
            }
        }

        private bool ValidateForm()
        {
            //TODO - add validation to the form
            return true;
        }

        private void TaskDeadlineValue_TextChanged(object sender, EventArgs e)
        {

        }

        //private void TaskAssignPersonListBox_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void addPersonToAssignedList_Click(object sender, EventArgs e)
        //{

        //}

        private void TaskPersonListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TaskProjectNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void taskProjectNameValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
