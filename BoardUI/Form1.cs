using BoardLibrary;
using Microsoft.EntityFrameworkCore;

namespace BoardUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTasks();

            ToDoListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            CompletedListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            IncompleteListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == ToDoListBox)
            {
                CompletedListBox.ClearSelected();
                IncompleteListBox.ClearSelected();
            }
            else if (sender == CompletedListBox)
            {
                ToDoListBox.ClearSelected();
                IncompleteListBox.ClearSelected();
            }
            else if (sender == IncompleteListBox)
            {
                ToDoListBox.ClearSelected();
                CompletedListBox.ClearSelected();
            }
        }


        private void LoadTasks()
        {
            using (var context = new BoardContext())
            {
                var tasks = context.Tasks.AsNoTracking().ToList();

                var toDoTasks = tasks.Where(t => t.Status == "To Do").ToList();
                ToDoListBox.DataSource = null;
                ToDoListBox.DataSource = toDoTasks;
                ToDoListBox.DisplayMember = "FullInfo";

                var completedTasks = tasks.Where(t => t.Status == "Completed").ToList();
                CompletedListBox.DataSource = null;
                CompletedListBox.DataSource = completedTasks;
                CompletedListBox.DisplayMember = "FullInfo";

                var incompleteTasks = tasks.Where(t => t.Status == "Incomplete").ToList();
                IncompleteListBox.DataSource = null;
                IncompleteListBox.DataSource = incompleteTasks;
                IncompleteListBox.DisplayMember = "FullInfo";

                ToDoListBox.ClearSelected();
                CompletedListBox.ClearSelected();
                IncompleteListBox.ClearSelected();


                RefreshCompletedList();
                RefreshToDoList();
                RefreshIncompleteList();

            }
        }




        ///////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////ODSWIEZANIE LIST///////////////////////////////////////////////////////////

        private void RefreshAllLists()
        {
            LoadTasks(); 
            RefreshCompletedList();
            RefreshToDoList();
            RefreshIncompleteList();
        }

        public void RefreshToDoList()
        {
            using (var context = new BoardContext())
            {
                ToDoListBox.DataSource = null; 
                ToDoListBox.DataSource = context.Tasks.Where(t => t.Status == "To Do").ToList(); 
                ToDoListBox.DisplayMember = "FullInfo"; 
            }
        }

        public void RefreshCompletedList()
        {
            using (var context = new BoardContext())
            {
                CompletedListBox.DataSource = null;
                CompletedListBox.DataSource = context.Tasks.Where(t => t.Status == "Completed").ToList();
                CompletedListBox.DisplayMember = "FullInfo";
            }
        }

        public void RefreshIncompleteList()
        {
            using (var context = new BoardContext())
            {
                IncompleteListBox.DataSource = null;
                IncompleteListBox.DataSource = context.Tasks.Where(t => t.Status == "Incomplete").ToList();
                IncompleteListBox.DisplayMember = "FullInfo";
            }
        }


        ////////////////////////////////////////ODSWIEZANIE LIST///////////////////////////////////////////////////////////






        /////////////////////////////////////////////CHANGING//////////////////////////////////////////////////////




        private void ChangeTaskStatus(string newStatus, ListBox fromListBox, ListBox toListBox)
        {
            if (fromListBox.SelectedItem != null)
            {
                TaskModel selectedTask = (TaskModel)fromListBox.SelectedItem;
                using (var context = new BoardContext())
                {
                    
                    selectedTask.Status = newStatus;
                    context.Tasks.Update(selectedTask);

                    context.SaveChanges();
                }

                
                RefreshAllLists();
            }
        }

        private void ChangeCompletedButton_Click(object sender, EventArgs e)
        {
            ChangeTaskStatus("Completed", ToDoListBox, CompletedListBox);

            RefreshAllLists();
        }

        private void ChangeIncompleteButton_Click(object sender, EventArgs e)
        {
            ChangeTaskStatus("Incomplete", ToDoListBox, IncompleteListBox);
            RefreshAllLists();
        }
        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (CompletedListBox.SelectedItem != null)
            {
                ChangeTaskStatus("To Do", CompletedListBox, ToDoListBox);
            }
            else if (IncompleteListBox.SelectedItem != null)
            {
                ChangeTaskStatus("To Do", IncompleteListBox, ToDoListBox);
            }
            RefreshAllLists();
        }

        /////////////////////////////////////////////CHANGING//////////////////////////////////////////////////////

        ////////////////////////////////////////USUWANIE///////////////////////////////////////////////////////////

        private void RefreshListBox(ListBox listBox, List<TaskModel> tasks)
        {
            listBox.DataSource = null;
            listBox.DataSource = tasks;
            listBox.DisplayMember = "FullInfo";
        }
        private void RemoveSelectedTask()
        {

            if (ToDoListBox.SelectedItem != null)
            {
                TaskModel selectedTask = (TaskModel)ToDoListBox.SelectedItem;
                List<TaskModel> tasks = (List<TaskModel>)ToDoListBox.DataSource;
                RemoveTaskFromDatabase(selectedTask);
                tasks.Remove(selectedTask);
                RefreshListBox(ToDoListBox, tasks);
            }


            else if (CompletedListBox.SelectedItem != null)
            {
                TaskModel selectedTask = (TaskModel)CompletedListBox.SelectedItem;
                List<TaskModel> tasks = (List<TaskModel>)CompletedListBox.DataSource;
                RemoveTaskFromDatabase(selectedTask);
                tasks.Remove(selectedTask);
                RefreshListBox(CompletedListBox, tasks);
            }


            else if (IncompleteListBox.SelectedItem != null)
            {
                TaskModel selectedTask = (TaskModel)IncompleteListBox.SelectedItem;
                List<TaskModel> tasks = (List<TaskModel>)IncompleteListBox.DataSource;
                RemoveTaskFromDatabase(selectedTask);
                tasks.Remove(selectedTask);
                RefreshListBox(IncompleteListBox, tasks);
            }
        }

        private void RemoveTaskFromDatabase(TaskModel task)
        {
            using (var context = new BoardContext())
            {
                context.Tasks.Remove(task);
                context.SaveChanges();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RemoveSelectedTask();
        }




        /////////////////////////////////////////////USUWANIE//////////////////////////////////////////////////////
        private void ProjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /////////////////////////////////////////////PERSON//////////////////////////////////////////////////////

        public void RefreshPersonsList()
        {
            LoadPersonsFromDataBase();
            PersonListBox.DataSource = null;
            PersonListBox.DataSource = availablePersons;
            PersonListBox.DisplayMember = "FullName";
        }

        private void CreatePersonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshPersonsList();
        }



        private void CreatePersonFormButton_Click(object sender, EventArgs e)
        {
            CreatePersonForm openPersonForm = new CreatePersonForm();
            openPersonForm.FormClosed += CreatePersonForm_FormClosed;
            openPersonForm.Show();
        }


        /////////////////////////////////////////////PERSON//////////////////////////////////////////////////////


        /////////////////////////////////////////////PROOOJECT//////////////////////////////////////////////////////

        public void RefreshProjectsList()
        {
            LoadPersonsFromDataBase();
            ProjectsListBox.DataSource = null;
            ProjectsListBox.DataSource = availableProjects;
            ProjectsListBox.DisplayMember = "ProjectName";
        }
        public void CreateProjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshProjectsList();
        }

        private void CreateProjectFormButton_Click(object sender, EventArgs e)
        {
            CreateProjectForm openProjectForm = new CreateProjectForm();
            openProjectForm.FormClosed += CreateProjectForm_FormClosed;
            openProjectForm.Show();
        }



        /////////////////////////////////////////////PROOOJECT//////////////////////////////////////////////////////



        /////////////////////////////////////////////TASK//////////////////////////////////////////////////////
        public void CreateTaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshToDoList();
        }



        private void CreateTaskFormButton_Click(object sender, EventArgs e)
        {
            CreateTaskForm openTaskForm = new CreateTaskForm();
            openTaskForm.FormClosed += CreateTaskForm_FormClosed;
            openTaskForm.Show();
        }
        /////////////////////////////////////////////TASK//////////////////////////////////////////////////////
        private void ToDoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToDoListBox.SelectedIndex == -1) return;

            var selectedTask = (TaskModel)ToDoListBox.SelectedItem;
            if (selectedTask.Status != "To Do")
            {
                RefreshToDoList();
            }
        }

    }
}



