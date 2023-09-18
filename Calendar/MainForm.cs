
using MySql.Data.MySqlClient;
using System.Data;
/**
* Project      : Calendar
* File         : MainForm.cs
* Description  : A calendar app for a school where you can add/modify/delete teachers, rooms, classes and schedules
* Author       : Weber Jamie
* Date         : 08 September 2023 - 
**/
namespace Calendar
{
    /// <summary>
    /// The main form of the app where we can access, modify and deletes infos from the database
    /// </summary>
    public partial class MainForm : Form
    {
        // #############################
        // The global variables of the class
        // #############################


        /// <summary>
        /// The manager of the database
        /// </summary>
        DbManager dbManager;


        // #############################
        // The start of the object
        // #############################


        /// <summary>
        /// The constructor of the class, initialize all components
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            dbManager = new DbManager();
        }

        /// <summary>
        /// When loading the form
        /// Set the width of the tab control and call once every update functions
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            MainTabControl.Width = ClientSize.Width;
            MainTabControl.Height = ClientSize.Height;
            UpdateTeachers();
            UpdateRooms();
            UpdateClasses();
            UpdateSchedules();
        }


        // #############################
        // Clicking on the DataGridViews
        // #############################


        /// <summary>
        /// When clicking the TeacherDataGridView control
        /// Modify the infos of the groupbox to the infos of the item that we selected
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void TeacherDataGridView_Click(object sender, EventArgs e)
        {
            if (TeacherDataGridView.CurrentRow != null)
            {
                DataGridViewCellCollection teacher = TeacherDataGridView.CurrentRow.Cells;
                IdInfoTeacherLabel.Text = teacher[0].Value.ToString();
                NameTeacherTextBox.Text = teacher[1].Value.ToString();
                EmailTeacherTextBox.Text = teacher[2].Value.ToString();
                PhoneTeacherTextBox.Text = teacher[3].Value.ToString();
            }
        }

        /// <summary>
        /// When clicking the RoomDataGridView control
        /// Modify the infos of the groupbox to the infos of the item that we selected
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void RoomDataGridView_Click(object sender, EventArgs e)
        {
            if (RoomDataGridView.CurrentRow != null)
            {
                DataGridViewCellCollection room = RoomDataGridView.CurrentRow.Cells;
                IdInfoRoomLabel.Text = room[0].Value.ToString();
                NameRoomTextBox.Text = room[1].Value.ToString();
                CapacityRoomNumericUpDown.Value = (int)room[2].Value;
            }
        }

        /// <summary>
        /// When clicking the ClassDataGridView control
        /// Modify the infos of the groupbox to the infos of the item that we selected
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void ClassDataGridView_Click(object sender, EventArgs e)
        {
            if (ClassDataGridView.CurrentRow != null)
            {
                DataGridViewCellCollection myClass = ClassDataGridView.CurrentRow.Cells;
                IdInfoClassLabel.Text = myClass[0].Value.ToString();
                NameClassTextBox.Text = myClass[1].Value.ToString();
                DescriptionClassTextBox.Text = myClass[2].Value.ToString();
            }
        }

        /// <summary>
        /// When clicking the ScheduleDataGridView control
        /// Modify the infos of the groupbox to the infos of the item that we selected
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void ScheduleDataGridView_Click(object sender, EventArgs e)
        {
            if (ScheduleDataGridView.CurrentRow != null)
            {
                DataGridViewCellCollection schedule = ScheduleDataGridView.CurrentRow.Cells;
                IdInfoScheduleLabel.Text = schedule[0].Value.ToString();
                StartScheduleDateTimePicker.Value = DateTime.Parse(schedule[2].Value.ToString());
                EndScheduleDateTimePicker.Value = DateTime.Parse(schedule[3].Value.ToString());
            }
        }


        // #############################
        // Clicking on add buttons
        // #############################


        /// <summary>
        /// When clicking the AddTeacherButton control
        /// Verify if we can add the teacher and add it in the database if we can
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            if (NameTeacherTextBox.Text != "" && EmailTeacherTextBox.Text != "" && PhoneTeacherTextBox.Text != "")
            {
                dbManager.AddData("Teachers", new string[3] { NameTeacherTextBox.Text, EmailTeacherTextBox.Text, PhoneTeacherTextBox.Text });
                UpdateTeachers();
            }
        }

        /// <summary>
        /// When clicking the AddRoomButton control
        /// Verify if we can add the room and add it in the database if we can
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            if (NameRoomTextBox.Text != "" && CapacityRoomNumericUpDown.Value > 0)
            {
                dbManager.AddData("Rooms", new string[2] { NameRoomTextBox.Text, Convert.ToString(CapacityRoomNumericUpDown.Value) });
                UpdateRooms();
            }
        }

        /// <summary>
        /// When clicking the AddClassButton control
        /// Verify if we can add the class and add it in the database if we can
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void AddClassButton_Click(object sender, EventArgs e)
        {
            if (NameClassTextBox.Text != "" && DescriptionClassTextBox.Text != "" && TeacherClassComboBox.SelectedIndex != -1)
            {
                DataRowView curr = (DataRowView)TeacherClassComboBox.SelectedItem;
                DataRow teacher = curr.Row;
                dbManager.AddData("Classes", new string[3] { NameClassTextBox.Text, DescriptionClassTextBox.Text, Convert.ToString(teacher["ID"]) });
                UpdateClasses();
            }
        }

        /// <summary>
        /// When clicking the AddScheduleButton control
        /// Verify if we can add the schedule and add it in the database if we can
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void AddScheduleButton_Click(object sender, EventArgs e)
        {
            if (WeekDayScheduleComboBox.SelectedIndex != -1 && ClassScheduleComboBox.SelectedIndex != -1 && RoomScheduleComboBox.SelectedIndex != -1)
            {
                DataRowView currClass = (DataRowView)ClassScheduleComboBox.SelectedItem;
                DataRowView currRoom = (DataRowView)RoomScheduleComboBox.SelectedItem;
                DataRow myClass = currClass.Row;
                DataRow room = currRoom.Row;
                string start = StartScheduleDateTimePicker.Value.TimeOfDay.ToString();
                string end = EndScheduleDateTimePicker.Value.TimeOfDay.ToString();
                dbManager.AddData("Schedules", new string[5] { WeekDayScheduleComboBox.SelectedItem.ToString(), start, end, Convert.ToString(room["ID"]), Convert.ToString(myClass["id"]) });
                UpdateSchedules();
            }
        }


        // #############################
        // Updates variables
        // #############################


        /// <summary>
        /// Update the infos in the controls of the form about the teachers
        /// </summary>
        private void UpdateTeachers()
        {
            MySqlDataAdapter adapter = dbManager.GetListObject("Teachers", "idTeacher as 'ID', name as 'nom', email, phoneNbr as 'Téléphone'");
            DataTable table = new DataTable();
            adapter.Fill(table);
            TeacherDataGridView.DataSource = table;
            TeacherClassComboBox.DataSource = table;
            TeacherClassComboBox.DisplayMember = "nom";
        }

        /// <summary>
        /// Update the infos in the controls of the form about the rooms
        /// </summary>
        private void UpdateRooms()
        {
            MySqlDataAdapter adapter = dbManager.GetListObject("Rooms", "idRoom as 'ID', name as 'nom', capacity as 'capacité'");
            DataTable table = new DataTable();
            adapter.Fill(table);
            RoomDataGridView.DataSource = table;
            RoomScheduleComboBox.DataSource = table;
            RoomScheduleComboBox.DisplayMember = "nom";
        }

        /// <summary>
        /// Update the infos in the controls of the form about the classes
        /// </summary>
        private void UpdateClasses()
        {
            MySqlDataAdapter adapter = dbManager.GetListObject("Classes, Teachers", "idClass as 'ID', Classes.name as 'nom', description, Teachers.name as 'professeur'", "WHERE Classes.idTeacher = Teachers.idTeacher");
            DataTable table = new DataTable();
            adapter.Fill(table);
            ClassDataGridView.DataSource = table;
            ClassScheduleComboBox.DataSource = table;
            ClassScheduleComboBox.DisplayMember = "nom";
        }

        /// <summary>
        /// Update the infos in the controls of the form about the schedules
        /// </summary>
        private void UpdateSchedules()
        {
            MySqlDataAdapter adapter = dbManager.GetListObject("Schedules, Classes, Rooms", "idSchedule as 'ID', weekDay as 'jour', startHour as 'début', endHour as 'fin', Rooms.name as 'salle', Classes.name as 'cours'", "WHERE Schedules.idClass = Classes.idClass AND Schedules.idRoom = Rooms.idRoom");
            DataTable table = new DataTable();
            adapter.Fill(table);
            ScheduleDataGridView.DataSource = table;
        }

    }
}