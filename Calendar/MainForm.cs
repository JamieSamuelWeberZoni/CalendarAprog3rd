
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC;
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
            DataGridViewRow? teacher = TeacherDataGridView.CurrentRow;
            if (teacher != null)
            {
                IdInfoTeacherLabel.Text = teacher.Cells[0].Value.ToString();
                NameTeacherTextBox.Text = teacher.Cells[1].Value.ToString();
                EmailTeacherTextBox.Text = teacher.Cells[2].Value.ToString();
                PhoneTeacherTextBox.Text = teacher.Cells[3].Value.ToString();
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
            DataGridViewRow? room = RoomDataGridView.CurrentRow;
            if (room != null)
            {
                IdInfoRoomLabel.Text = room.Cells[0].Value.ToString();
                NameRoomTextBox.Text = room.Cells[1].Value.ToString();
                CapacityRoomNumericUpDown.Value = (int)room.Cells[2].Value;
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
            DataGridViewRow? myClass = ClassDataGridView.CurrentRow;
            if (myClass != null)
            {
                IdInfoClassLabel.Text = myClass.Cells[0].Value.ToString();
                NameClassTextBox.Text = myClass.Cells[1].Value.ToString();
                DescriptionClassTextBox.Text = myClass.Cells[2].Value.ToString();

                ComboBox.ObjectCollection teachers = TeacherClassComboBox.Items;
                foreach (DataRowView teacher in teachers)
                {
                    if (teacher.Row[1].ToString() == myClass.Cells[3].Value.ToString())
                    {
                        TeacherClassComboBox.SelectedItem = teacher;
                    }
                }
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
            DataGridViewRow? schedule = ScheduleDataGridView.CurrentRow;
            if (schedule != null)
            {
                IdInfoScheduleLabel.Text = schedule.Cells[0].Value.ToString();
                WeekDayScheduleComboBox.SelectedItem = schedule.Cells[1].Value.ToString();
                StartScheduleDateTimePicker.Value = DateTime.Parse(schedule.Cells[2].Value.ToString());
                EndScheduleDateTimePicker.Value = DateTime.Parse(schedule.Cells[3].Value.ToString());
            }

            ComboBox.ObjectCollection rooms = RoomScheduleComboBox.Items;
            foreach (DataRowView room in rooms)
            {
                if (room.Row[1].ToString() == schedule.Cells[4].Value.ToString())
                {
                    RoomScheduleComboBox.SelectedItem = room;
                }
            }

            ComboBox.ObjectCollection classes = ClassScheduleComboBox.Items;
            foreach (DataRowView myClass in classes)
            {
                if (myClass.Row[1].ToString() == schedule.Cells[5].Value.ToString())
                {
                    ClassScheduleComboBox.SelectedItem = myClass;
                }
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
                MessageBox.Show("Professeur ajouté avec succès!");
                NameTeacherTextBox.Text = "";
                EmailTeacherTextBox.Text = "";
                PhoneTeacherTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Veuillez s'il-vous-plaît remplir tout les champs");
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
                MessageBox.Show("Salle ajoutée avec succès!");
                NameRoomTextBox.Text = "";
                CapacityRoomNumericUpDown.Value = 0;
            }
            else
            {
                MessageBox.Show("Veuillez s'il-vous-plaît remplir tout les champs");
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
                MessageBox.Show("Cours ajouté avec succès!");
                NameClassTextBox.Text = "";
                DescriptionClassTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Veuillez s'il-vous-plaît remplir tout les champs");
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
                MessageBox.Show("Horaire ajouté avec succès!");
                StartScheduleDateTimePicker.Value = DateTime.Parse("08:00:00");
                EndScheduleDateTimePicker.Value = DateTime.Parse("08:00:00");
                WeekDayScheduleComboBox.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Veuillez s'il-vous-plaît remplir tout les champs");
            }
        }


        // #############################
        // Clicking on delete buttons
        // #############################


        /// <summary>
        /// When clicking the DeleteTeacherButton control
        /// Delete the selected teacher if they have no class to give
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void DeleteTeacherButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow? teacher = TeacherDataGridView.CurrentRow;
            if (teacher != null && dbManager.CheckIfFree("Teachers", "Classes", teacher.Cells[0].Value.ToString()))
            {
                dbManager.DeleteData("Teachers", teacher.Cells[0].Value.ToString());
                UpdateTeachers();
                MessageBox.Show("Professeur supprimé avec succès!");
            }
            else
            {
                MessageBox.Show(teacher != null ? "Veuillez s'il-vous-plaît disassocier le(s) cours que le professeur donne du professeur avant de le supprimer" : "Il est impossible de supprimer un professeur car aucun n'est séléctionné, vérifiez que la table n'est pas vide");
            }
        }

        /// <summary>
        /// When clicking the DeleteRoomButton control
        /// Delete the selected room if it is not used during the week
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow? room = RoomDataGridView.CurrentRow;
            if (room != null && dbManager.CheckIfFree("Rooms", "Schedules", room.Cells[0].Value.ToString()))
            {
                dbManager.DeleteData("Rooms", room.Cells[0].Value.ToString());
                UpdateRooms();
                MessageBox.Show("Salle supprimée avec succès!");
            }
            else
            {
                MessageBox.Show(room != null ? "Veuillez s'il-vous-plaît disassocier le(s) horaire(s) où cette salle est utilisée" : "Il est impossible de supprimer une salle car aucune n'est séléctionnée, vérifiez que la table n'est pas vide");
            }
        }

        /// <summary>
        /// When clicking the DeleteClassButton control
        /// Delete the selected class if it is not given during the week
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void DeleteClassButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow? myClass = ClassDataGridView.CurrentRow;
            if (myClass != null && dbManager.CheckIfFree("Classes", "Schedules", myClass.Cells[0].Value.ToString())) {
                dbManager.DeleteData("Classes", myClass.Cells[0].Value.ToString());
                UpdateClasses();
                MessageBox.Show("Cours supprimé avec succès!");
            }
            else
            {
                MessageBox.Show(myClass != null ? "Veuillez s'il-vous-plaît disassocier le(s) horaire(s) où le cours a lieu" : "Il est impossible de supprimer un cours car aucun n'est séléctionné, vérifiez que la table n'est pas vide");
            }
        }

        /// <summary>
        /// When clicking the DeleteScheduleButton control
        /// Delete the selected schedule
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void DeleteScheduleButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow? schedule = ScheduleDataGridView.CurrentRow;
            if (schedule != null)
            {
                dbManager.DeleteData("Schedules", schedule.Cells[0].Value.ToString());
                UpdateSchedules();
                MessageBox.Show("Horaire supprimé avec succès!");
            }
            else
            {
                MessageBox.Show("Il est impossible de supprimer un horaire car aucun n'est séléctionné, vérifiez que la table n'est pas vide");
            }
        }


        // #############################
        // Clicking on modify button
        // #############################


        /// <summary>
        /// When clicking the ModifyTeacherButton control
        /// Verify if we can modify the selected teacher and modify them if we can
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void ModifyTeacherButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow? teacher = TeacherDataGridView.CurrentRow;
            if (teacher != null && NameTeacherTextBox.Text != "" && EmailTeacherTextBox.Text != "" && PhoneTeacherTextBox.Text != "")
            {
                string[] data = new string[3];
                data[0] = NameTeacherTextBox.Text;
                data[1] = EmailTeacherTextBox.Text;
                data[2] = PhoneTeacherTextBox.Text;
                dbManager.ModifyData("Teachers", teacher.Cells[0].Value.ToString(), data);
                UpdateTeachers();
                MessageBox.Show("Professeur changé avec succès");
            }
            else
            {
                MessageBox.Show("Veuillez s'il-vous-plaît remplir tout les champs et choisir un professeur, vérifiez que la table n'est pas vide");
            }
        }

        /// <summary>
        /// When clicking the ModifyRoomButton control
        /// Verify if we can modify the selected room and modify it if we can
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void ModifyRoomButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow? room = RoomDataGridView.CurrentRow;
            if (room != null && NameRoomTextBox.Text != "" && CapacityRoomNumericUpDown.Value != 0)
            {
                string[] data = new string[2];
                data[0] = NameRoomTextBox.Text;
                data[1] = Convert.ToString(CapacityRoomNumericUpDown.Value);
                dbManager.ModifyData("Rooms", room.Cells[0].Value.ToString(), data);
                UpdateRooms();
                MessageBox.Show("Salle modifiée avec succès");
            }
            else
            {
                MessageBox.Show("Veuillez s'il-vous-plaît remplir tout les champs et choisir une salle, vérifiez que la table n'est pas vide");
            }
        }

        /// <summary>
        /// When clicking the ModifyClassButton control
        /// Verify if we can modify a selected class and modify it if we can
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void ModifyClassButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow? myClass = ClassDataGridView.CurrentRow;
            if (myClass != null && NameClassTextBox.Text != "" && DescriptionClassTextBox.Text != "" && TeacherClassComboBox.SelectedIndex != -1)
            {
                string[] data = new string[3];
                data[0] = NameClassTextBox.Text;
                data[1] = DescriptionClassTextBox.Text;
                DataRowView teacherId = (DataRowView)TeacherClassComboBox.SelectedValue;
                data[2] = Convert.ToString(teacherId.Row[0]);
                dbManager.ModifyData("Classes", myClass.Cells[0].Value.ToString(), data);
                UpdateClasses();
                MessageBox.Show("Cours modifié avec succès");
            }
            else
            {
                MessageBox.Show("Veuillez s'il-vous-plaît remplir tout les champs et choisir un cours, vérifiez que la table n'est pas vide");
            }
        }

        /// <summary>
        /// When clicking the ModifyScheduleButton control
        /// Verify if we can modify a selected schedule and modify it if we can
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that was triggered</param>
        private void ModifyScheduleButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow? schedule = ScheduleDataGridView.CurrentRow;
            if (schedule != null && RoomScheduleComboBox.SelectedIndex != -1 && ClassScheduleComboBox.SelectedIndex != -1 && WeekDayScheduleComboBox.SelectedIndex != -1)
            {
                string[] data = new string[5];
                data[0] = WeekDayScheduleComboBox.SelectedItem.ToString();
                data[1] = StartScheduleDateTimePicker.Value.TimeOfDay.ToString();
                data[2] = EndScheduleDateTimePicker.Value.TimeOfDay.ToString();
                DataRowView roomId = (DataRowView)RoomScheduleComboBox.SelectedValue;
                DataRowView classId = (DataRowView)ClassScheduleComboBox.SelectedValue;
                data[3] = Convert.ToString(roomId.Row[0]);
                data[4] = Convert.ToString(classId.Row[0]);
                dbManager.ModifyData("Schedules", schedule.Cells[0].Value.ToString(), data);
                UpdateSchedules();
                MessageBox.Show("horaire modifié avec succès");
            }
            else
            {
                MessageBox.Show("Veuillez s'il-vous-plaît remplir tout les champs et choisir un horaire, vérifiez que la table n'est pas vide");
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