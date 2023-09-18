namespace Calendar
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.TeacherPage = new System.Windows.Forms.TabPage();
            this.TeacherGroupBox = new System.Windows.Forms.GroupBox();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.DeleteTeacherButton = new System.Windows.Forms.Button();
            this.ModifyTeacherButton = new System.Windows.Forms.Button();
            this.IdInfoTeacherLabel = new System.Windows.Forms.Label();
            this.PhoneTeacherTextBox = new System.Windows.Forms.TextBox();
            this.EmailTeacherTextBox = new System.Windows.Forms.TextBox();
            this.NameTeacherTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTeacherLabel = new System.Windows.Forms.Label();
            this.EmailTeacherLabel = new System.Windows.Forms.Label();
            this.NameteacherLabel = new System.Windows.Forms.Label();
            this.IdTeacherLabel = new System.Windows.Forms.Label();
            this.TeacherDataGridView = new System.Windows.Forms.DataGridView();
            this.RoomPage = new System.Windows.Forms.TabPage();
            this.RoomGroupBox = new System.Windows.Forms.GroupBox();
            this.CapacityRoomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.ModifyRoomButton = new System.Windows.Forms.Button();
            this.IdInfoRoomLabel = new System.Windows.Forms.Label();
            this.NameRoomTextBox = new System.Windows.Forms.TextBox();
            this.CapacityRoomLabel = new System.Windows.Forms.Label();
            this.NameRoomLabel = new System.Windows.Forms.Label();
            this.IdRoomLabel = new System.Windows.Forms.Label();
            this.RoomDataGridView = new System.Windows.Forms.DataGridView();
            this.ClassPage = new System.Windows.Forms.TabPage();
            this.ClassesGroupBox = new System.Windows.Forms.GroupBox();
            this.TeacherClassComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionClassTextBox = new System.Windows.Forms.RichTextBox();
            this.AddClassButton = new System.Windows.Forms.Button();
            this.DeleteClassButton = new System.Windows.Forms.Button();
            this.ModifyClassButton = new System.Windows.Forms.Button();
            this.IdInfoClassLabel = new System.Windows.Forms.Label();
            this.NameClassTextBox = new System.Windows.Forms.TextBox();
            this.TeacherClassLabel = new System.Windows.Forms.Label();
            this.DescriptionClassLabel = new System.Windows.Forms.Label();
            this.NameClassLabel = new System.Windows.Forms.Label();
            this.IdClassLabel = new System.Windows.Forms.Label();
            this.ClassDataGridView = new System.Windows.Forms.DataGridView();
            this.SchedulePage = new System.Windows.Forms.TabPage();
            this.ScheduleGroupBox = new System.Windows.Forms.GroupBox();
            this.EndScheduleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartScheduleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WeekDayScheduleComboBox = new System.Windows.Forms.ComboBox();
            this.RoomScheduleComboBox = new System.Windows.Forms.ComboBox();
            this.RoomScheduleLabel = new System.Windows.Forms.Label();
            this.EndScheduleLabel = new System.Windows.Forms.Label();
            this.ClassScheduleComboBox = new System.Windows.Forms.ComboBox();
            this.AddScheduleButton = new System.Windows.Forms.Button();
            this.DeleteScheduleButton = new System.Windows.Forms.Button();
            this.ModifyScheduleButton = new System.Windows.Forms.Button();
            this.IdInfoScheduleLabel = new System.Windows.Forms.Label();
            this.ClassScheduleLabel = new System.Windows.Forms.Label();
            this.StartScheduleLabel = new System.Windows.Forms.Label();
            this.WeekDayScheduleLabel = new System.Windows.Forms.Label();
            this.IdScheduleLabel = new System.Windows.Forms.Label();
            this.ScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.MainTabControl.SuspendLayout();
            this.TeacherPage.SuspendLayout();
            this.TeacherGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGridView)).BeginInit();
            this.RoomPage.SuspendLayout();
            this.RoomGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityRoomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGridView)).BeginInit();
            this.ClassPage.SuspendLayout();
            this.ClassesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataGridView)).BeginInit();
            this.SchedulePage.SuspendLayout();
            this.ScheduleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.TeacherPage);
            this.MainTabControl.Controls.Add(this.RoomPage);
            this.MainTabControl.Controls.Add(this.ClassPage);
            this.MainTabControl.Controls.Add(this.SchedulePage);
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(790, 363);
            this.MainTabControl.TabIndex = 0;
            // 
            // TeacherPage
            // 
            this.TeacherPage.Controls.Add(this.TeacherGroupBox);
            this.TeacherPage.Controls.Add(this.TeacherDataGridView);
            this.TeacherPage.Location = new System.Drawing.Point(4, 24);
            this.TeacherPage.Name = "TeacherPage";
            this.TeacherPage.Padding = new System.Windows.Forms.Padding(3);
            this.TeacherPage.Size = new System.Drawing.Size(782, 335);
            this.TeacherPage.TabIndex = 0;
            this.TeacherPage.Text = "Professeurs";
            this.TeacherPage.UseVisualStyleBackColor = true;
            // 
            // TeacherGroupBox
            // 
            this.TeacherGroupBox.Controls.Add(this.AddTeacherButton);
            this.TeacherGroupBox.Controls.Add(this.DeleteTeacherButton);
            this.TeacherGroupBox.Controls.Add(this.ModifyTeacherButton);
            this.TeacherGroupBox.Controls.Add(this.IdInfoTeacherLabel);
            this.TeacherGroupBox.Controls.Add(this.PhoneTeacherTextBox);
            this.TeacherGroupBox.Controls.Add(this.EmailTeacherTextBox);
            this.TeacherGroupBox.Controls.Add(this.NameTeacherTextBox);
            this.TeacherGroupBox.Controls.Add(this.PhoneTeacherLabel);
            this.TeacherGroupBox.Controls.Add(this.EmailTeacherLabel);
            this.TeacherGroupBox.Controls.Add(this.NameteacherLabel);
            this.TeacherGroupBox.Controls.Add(this.IdTeacherLabel);
            this.TeacherGroupBox.Location = new System.Drawing.Point(6, 6);
            this.TeacherGroupBox.Name = "TeacherGroupBox";
            this.TeacherGroupBox.Size = new System.Drawing.Size(285, 324);
            this.TeacherGroupBox.TabIndex = 1;
            this.TeacherGroupBox.TabStop = false;
            this.TeacherGroupBox.Text = "Professeur";
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.Location = new System.Drawing.Point(6, 222);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(273, 28);
            this.AddTeacherButton.TabIndex = 10;
            this.AddTeacherButton.Text = "Ajouter Prof";
            this.AddTeacherButton.UseVisualStyleBackColor = true;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButton_Click);
            // 
            // DeleteTeacherButton
            // 
            this.DeleteTeacherButton.Location = new System.Drawing.Point(6, 256);
            this.DeleteTeacherButton.Name = "DeleteTeacherButton";
            this.DeleteTeacherButton.Size = new System.Drawing.Size(273, 28);
            this.DeleteTeacherButton.TabIndex = 9;
            this.DeleteTeacherButton.Text = "Supprimer Prof";
            this.DeleteTeacherButton.UseVisualStyleBackColor = true;
            this.DeleteTeacherButton.Click += new System.EventHandler(this.DeleteTeacherButton_Click);
            // 
            // ModifyTeacherButton
            // 
            this.ModifyTeacherButton.Location = new System.Drawing.Point(6, 290);
            this.ModifyTeacherButton.Name = "ModifyTeacherButton";
            this.ModifyTeacherButton.Size = new System.Drawing.Size(273, 28);
            this.ModifyTeacherButton.TabIndex = 8;
            this.ModifyTeacherButton.Text = "Modifier Prof";
            this.ModifyTeacherButton.UseVisualStyleBackColor = true;
            this.ModifyTeacherButton.Click += new System.EventHandler(this.ModifyTeacherButton_Click);
            // 
            // IdInfoTeacherLabel
            // 
            this.IdInfoTeacherLabel.AutoSize = true;
            this.IdInfoTeacherLabel.Location = new System.Drawing.Point(143, 45);
            this.IdInfoTeacherLabel.Name = "IdInfoTeacherLabel";
            this.IdInfoTeacherLabel.Size = new System.Drawing.Size(0, 15);
            this.IdInfoTeacherLabel.TabIndex = 7;
            // 
            // PhoneTeacherTextBox
            // 
            this.PhoneTeacherTextBox.Location = new System.Drawing.Point(143, 162);
            this.PhoneTeacherTextBox.Name = "PhoneTeacherTextBox";
            this.PhoneTeacherTextBox.Size = new System.Drawing.Size(136, 23);
            this.PhoneTeacherTextBox.TabIndex = 6;
            // 
            // EmailTeacherTextBox
            // 
            this.EmailTeacherTextBox.Location = new System.Drawing.Point(143, 122);
            this.EmailTeacherTextBox.Name = "EmailTeacherTextBox";
            this.EmailTeacherTextBox.Size = new System.Drawing.Size(136, 23);
            this.EmailTeacherTextBox.TabIndex = 5;
            // 
            // NameTeacherTextBox
            // 
            this.NameTeacherTextBox.Location = new System.Drawing.Point(143, 82);
            this.NameTeacherTextBox.Name = "NameTeacherTextBox";
            this.NameTeacherTextBox.Size = new System.Drawing.Size(136, 23);
            this.NameTeacherTextBox.TabIndex = 4;
            // 
            // PhoneTeacherLabel
            // 
            this.PhoneTeacherLabel.AutoSize = true;
            this.PhoneTeacherLabel.Location = new System.Drawing.Point(6, 165);
            this.PhoneTeacherLabel.Name = "PhoneTeacherLabel";
            this.PhoneTeacherLabel.Size = new System.Drawing.Size(123, 15);
            this.PhoneTeacherLabel.TabIndex = 3;
            this.PhoneTeacherLabel.Text = "Numéro de téléphone";
            // 
            // EmailTeacherLabel
            // 
            this.EmailTeacherLabel.AutoSize = true;
            this.EmailTeacherLabel.Location = new System.Drawing.Point(6, 125);
            this.EmailTeacherLabel.Name = "EmailTeacherLabel";
            this.EmailTeacherLabel.Size = new System.Drawing.Size(36, 15);
            this.EmailTeacherLabel.TabIndex = 2;
            this.EmailTeacherLabel.Text = "Email";
            // 
            // NameteacherLabel
            // 
            this.NameteacherLabel.AutoSize = true;
            this.NameteacherLabel.Location = new System.Drawing.Point(6, 85);
            this.NameteacherLabel.Name = "NameteacherLabel";
            this.NameteacherLabel.Size = new System.Drawing.Size(34, 15);
            this.NameteacherLabel.TabIndex = 1;
            this.NameteacherLabel.Text = "Nom";
            // 
            // IdTeacherLabel
            // 
            this.IdTeacherLabel.AutoSize = true;
            this.IdTeacherLabel.Location = new System.Drawing.Point(6, 45);
            this.IdTeacherLabel.Name = "IdTeacherLabel";
            this.IdTeacherLabel.Size = new System.Drawing.Size(18, 15);
            this.IdTeacherLabel.TabIndex = 0;
            this.IdTeacherLabel.Text = "ID";
            // 
            // TeacherDataGridView
            // 
            this.TeacherDataGridView.AllowUserToAddRows = false;
            this.TeacherDataGridView.AllowUserToDeleteRows = false;
            this.TeacherDataGridView.AllowUserToResizeColumns = false;
            this.TeacherDataGridView.AllowUserToResizeRows = false;
            this.TeacherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherDataGridView.Location = new System.Drawing.Point(297, 6);
            this.TeacherDataGridView.Name = "TeacherDataGridView";
            this.TeacherDataGridView.ReadOnly = true;
            this.TeacherDataGridView.RowHeadersVisible = false;
            this.TeacherDataGridView.RowTemplate.Height = 25;
            this.TeacherDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeacherDataGridView.Size = new System.Drawing.Size(479, 324);
            this.TeacherDataGridView.TabIndex = 0;
            this.TeacherDataGridView.Click += new System.EventHandler(this.TeacherDataGridView_Click);
            // 
            // RoomPage
            // 
            this.RoomPage.Controls.Add(this.RoomGroupBox);
            this.RoomPage.Controls.Add(this.RoomDataGridView);
            this.RoomPage.Location = new System.Drawing.Point(4, 24);
            this.RoomPage.Name = "RoomPage";
            this.RoomPage.Padding = new System.Windows.Forms.Padding(3);
            this.RoomPage.Size = new System.Drawing.Size(782, 335);
            this.RoomPage.TabIndex = 1;
            this.RoomPage.Text = "Salles de classe";
            this.RoomPage.UseVisualStyleBackColor = true;
            // 
            // RoomGroupBox
            // 
            this.RoomGroupBox.Controls.Add(this.CapacityRoomNumericUpDown);
            this.RoomGroupBox.Controls.Add(this.AddRoomButton);
            this.RoomGroupBox.Controls.Add(this.DeleteRoomButton);
            this.RoomGroupBox.Controls.Add(this.ModifyRoomButton);
            this.RoomGroupBox.Controls.Add(this.IdInfoRoomLabel);
            this.RoomGroupBox.Controls.Add(this.NameRoomTextBox);
            this.RoomGroupBox.Controls.Add(this.CapacityRoomLabel);
            this.RoomGroupBox.Controls.Add(this.NameRoomLabel);
            this.RoomGroupBox.Controls.Add(this.IdRoomLabel);
            this.RoomGroupBox.Location = new System.Drawing.Point(6, 6);
            this.RoomGroupBox.Name = "RoomGroupBox";
            this.RoomGroupBox.Size = new System.Drawing.Size(285, 324);
            this.RoomGroupBox.TabIndex = 3;
            this.RoomGroupBox.TabStop = false;
            this.RoomGroupBox.Text = "Salle de classe";
            // 
            // CapacityRoomNumericUpDown
            // 
            this.CapacityRoomNumericUpDown.Location = new System.Drawing.Point(143, 163);
            this.CapacityRoomNumericUpDown.Name = "CapacityRoomNumericUpDown";
            this.CapacityRoomNumericUpDown.Size = new System.Drawing.Size(136, 23);
            this.CapacityRoomNumericUpDown.TabIndex = 11;
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(6, 222);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(273, 28);
            this.AddRoomButton.TabIndex = 10;
            this.AddRoomButton.Text = "Ajouter Salle";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Location = new System.Drawing.Point(6, 256);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.Size = new System.Drawing.Size(273, 28);
            this.DeleteRoomButton.TabIndex = 9;
            this.DeleteRoomButton.Text = "Supprimer Salle";
            this.DeleteRoomButton.UseVisualStyleBackColor = true;
            this.DeleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // ModifyRoomButton
            // 
            this.ModifyRoomButton.Location = new System.Drawing.Point(6, 290);
            this.ModifyRoomButton.Name = "ModifyRoomButton";
            this.ModifyRoomButton.Size = new System.Drawing.Size(273, 28);
            this.ModifyRoomButton.TabIndex = 8;
            this.ModifyRoomButton.Text = "Modifier Salle";
            this.ModifyRoomButton.UseVisualStyleBackColor = true;
            this.ModifyRoomButton.Click += new System.EventHandler(this.ModifyRoomButton_Click);
            // 
            // IdInfoRoomLabel
            // 
            this.IdInfoRoomLabel.AutoSize = true;
            this.IdInfoRoomLabel.Location = new System.Drawing.Point(143, 45);
            this.IdInfoRoomLabel.Name = "IdInfoRoomLabel";
            this.IdInfoRoomLabel.Size = new System.Drawing.Size(0, 15);
            this.IdInfoRoomLabel.TabIndex = 7;
            // 
            // NameRoomTextBox
            // 
            this.NameRoomTextBox.Location = new System.Drawing.Point(143, 102);
            this.NameRoomTextBox.Name = "NameRoomTextBox";
            this.NameRoomTextBox.Size = new System.Drawing.Size(136, 23);
            this.NameRoomTextBox.TabIndex = 4;
            // 
            // CapacityRoomLabel
            // 
            this.CapacityRoomLabel.AutoSize = true;
            this.CapacityRoomLabel.Location = new System.Drawing.Point(6, 165);
            this.CapacityRoomLabel.Name = "CapacityRoomLabel";
            this.CapacityRoomLabel.Size = new System.Drawing.Size(53, 15);
            this.CapacityRoomLabel.TabIndex = 3;
            this.CapacityRoomLabel.Text = "Capacité";
            // 
            // NameRoomLabel
            // 
            this.NameRoomLabel.AutoSize = true;
            this.NameRoomLabel.Location = new System.Drawing.Point(6, 105);
            this.NameRoomLabel.Name = "NameRoomLabel";
            this.NameRoomLabel.Size = new System.Drawing.Size(34, 15);
            this.NameRoomLabel.TabIndex = 1;
            this.NameRoomLabel.Text = "Nom";
            // 
            // IdRoomLabel
            // 
            this.IdRoomLabel.AutoSize = true;
            this.IdRoomLabel.Location = new System.Drawing.Point(6, 45);
            this.IdRoomLabel.Name = "IdRoomLabel";
            this.IdRoomLabel.Size = new System.Drawing.Size(18, 15);
            this.IdRoomLabel.TabIndex = 0;
            this.IdRoomLabel.Text = "ID";
            // 
            // RoomDataGridView
            // 
            this.RoomDataGridView.AllowUserToAddRows = false;
            this.RoomDataGridView.AllowUserToDeleteRows = false;
            this.RoomDataGridView.AllowUserToResizeColumns = false;
            this.RoomDataGridView.AllowUserToResizeRows = false;
            this.RoomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomDataGridView.Location = new System.Drawing.Point(297, 6);
            this.RoomDataGridView.Name = "RoomDataGridView";
            this.RoomDataGridView.ReadOnly = true;
            this.RoomDataGridView.RowHeadersVisible = false;
            this.RoomDataGridView.RowTemplate.Height = 25;
            this.RoomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomDataGridView.Size = new System.Drawing.Size(479, 324);
            this.RoomDataGridView.TabIndex = 2;
            this.RoomDataGridView.Click += new System.EventHandler(this.RoomDataGridView_Click);
            // 
            // ClassPage
            // 
            this.ClassPage.Controls.Add(this.ClassesGroupBox);
            this.ClassPage.Controls.Add(this.ClassDataGridView);
            this.ClassPage.Location = new System.Drawing.Point(4, 24);
            this.ClassPage.Name = "ClassPage";
            this.ClassPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassPage.Size = new System.Drawing.Size(782, 335);
            this.ClassPage.TabIndex = 2;
            this.ClassPage.Text = "Cours";
            this.ClassPage.UseVisualStyleBackColor = true;
            // 
            // ClassesGroupBox
            // 
            this.ClassesGroupBox.Controls.Add(this.TeacherClassComboBox);
            this.ClassesGroupBox.Controls.Add(this.DescriptionClassTextBox);
            this.ClassesGroupBox.Controls.Add(this.AddClassButton);
            this.ClassesGroupBox.Controls.Add(this.DeleteClassButton);
            this.ClassesGroupBox.Controls.Add(this.ModifyClassButton);
            this.ClassesGroupBox.Controls.Add(this.IdInfoClassLabel);
            this.ClassesGroupBox.Controls.Add(this.NameClassTextBox);
            this.ClassesGroupBox.Controls.Add(this.TeacherClassLabel);
            this.ClassesGroupBox.Controls.Add(this.DescriptionClassLabel);
            this.ClassesGroupBox.Controls.Add(this.NameClassLabel);
            this.ClassesGroupBox.Controls.Add(this.IdClassLabel);
            this.ClassesGroupBox.Location = new System.Drawing.Point(6, 6);
            this.ClassesGroupBox.Name = "ClassesGroupBox";
            this.ClassesGroupBox.Size = new System.Drawing.Size(285, 324);
            this.ClassesGroupBox.TabIndex = 3;
            this.ClassesGroupBox.TabStop = false;
            this.ClassesGroupBox.Text = "Cours";
            // 
            // TeacherClassComboBox
            // 
            this.TeacherClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherClassComboBox.FormattingEnabled = true;
            this.TeacherClassComboBox.Location = new System.Drawing.Point(143, 182);
            this.TeacherClassComboBox.Name = "TeacherClassComboBox";
            this.TeacherClassComboBox.Size = new System.Drawing.Size(136, 23);
            this.TeacherClassComboBox.TabIndex = 12;
            // 
            // DescriptionClassTextBox
            // 
            this.DescriptionClassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionClassTextBox.Location = new System.Drawing.Point(143, 91);
            this.DescriptionClassTextBox.Name = "DescriptionClassTextBox";
            this.DescriptionClassTextBox.Size = new System.Drawing.Size(136, 84);
            this.DescriptionClassTextBox.TabIndex = 11;
            this.DescriptionClassTextBox.Text = "";
            // 
            // AddClassButton
            // 
            this.AddClassButton.Location = new System.Drawing.Point(6, 222);
            this.AddClassButton.Name = "AddClassButton";
            this.AddClassButton.Size = new System.Drawing.Size(273, 28);
            this.AddClassButton.TabIndex = 10;
            this.AddClassButton.Text = "Ajouter Cours";
            this.AddClassButton.UseVisualStyleBackColor = true;
            this.AddClassButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // DeleteClassButton
            // 
            this.DeleteClassButton.Location = new System.Drawing.Point(6, 256);
            this.DeleteClassButton.Name = "DeleteClassButton";
            this.DeleteClassButton.Size = new System.Drawing.Size(273, 28);
            this.DeleteClassButton.TabIndex = 9;
            this.DeleteClassButton.Text = "Supprimer Cours";
            this.DeleteClassButton.UseVisualStyleBackColor = true;
            this.DeleteClassButton.Click += new System.EventHandler(this.DeleteClassButton_Click);
            // 
            // ModifyClassButton
            // 
            this.ModifyClassButton.Location = new System.Drawing.Point(6, 290);
            this.ModifyClassButton.Name = "ModifyClassButton";
            this.ModifyClassButton.Size = new System.Drawing.Size(273, 28);
            this.ModifyClassButton.TabIndex = 8;
            this.ModifyClassButton.Text = "Modifier Cours";
            this.ModifyClassButton.UseVisualStyleBackColor = true;
            this.ModifyClassButton.Click += new System.EventHandler(this.ModifyClassButton_Click);
            // 
            // IdInfoClassLabel
            // 
            this.IdInfoClassLabel.AutoSize = true;
            this.IdInfoClassLabel.Location = new System.Drawing.Point(143, 35);
            this.IdInfoClassLabel.Name = "IdInfoClassLabel";
            this.IdInfoClassLabel.Size = new System.Drawing.Size(0, 15);
            this.IdInfoClassLabel.TabIndex = 7;
            // 
            // NameClassTextBox
            // 
            this.NameClassTextBox.Location = new System.Drawing.Point(143, 62);
            this.NameClassTextBox.Name = "NameClassTextBox";
            this.NameClassTextBox.Size = new System.Drawing.Size(136, 23);
            this.NameClassTextBox.TabIndex = 4;
            // 
            // TeacherClassLabel
            // 
            this.TeacherClassLabel.AutoSize = true;
            this.TeacherClassLabel.Location = new System.Drawing.Point(6, 185);
            this.TeacherClassLabel.Name = "TeacherClassLabel";
            this.TeacherClassLabel.Size = new System.Drawing.Size(62, 15);
            this.TeacherClassLabel.TabIndex = 3;
            this.TeacherClassLabel.Text = "Professeur";
            // 
            // DescriptionClassLabel
            // 
            this.DescriptionClassLabel.AutoSize = true;
            this.DescriptionClassLabel.Location = new System.Drawing.Point(6, 95);
            this.DescriptionClassLabel.Name = "DescriptionClassLabel";
            this.DescriptionClassLabel.Size = new System.Drawing.Size(67, 15);
            this.DescriptionClassLabel.TabIndex = 2;
            this.DescriptionClassLabel.Text = "Description";
            // 
            // NameClassLabel
            // 
            this.NameClassLabel.AutoSize = true;
            this.NameClassLabel.Location = new System.Drawing.Point(6, 65);
            this.NameClassLabel.Name = "NameClassLabel";
            this.NameClassLabel.Size = new System.Drawing.Size(34, 15);
            this.NameClassLabel.TabIndex = 1;
            this.NameClassLabel.Text = "Nom";
            // 
            // IdClassLabel
            // 
            this.IdClassLabel.AutoSize = true;
            this.IdClassLabel.Location = new System.Drawing.Point(6, 35);
            this.IdClassLabel.Name = "IdClassLabel";
            this.IdClassLabel.Size = new System.Drawing.Size(18, 15);
            this.IdClassLabel.TabIndex = 0;
            this.IdClassLabel.Text = "ID";
            // 
            // ClassDataGridView
            // 
            this.ClassDataGridView.AllowUserToAddRows = false;
            this.ClassDataGridView.AllowUserToDeleteRows = false;
            this.ClassDataGridView.AllowUserToResizeColumns = false;
            this.ClassDataGridView.AllowUserToResizeRows = false;
            this.ClassDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassDataGridView.Location = new System.Drawing.Point(297, 6);
            this.ClassDataGridView.Name = "ClassDataGridView";
            this.ClassDataGridView.ReadOnly = true;
            this.ClassDataGridView.RowHeadersVisible = false;
            this.ClassDataGridView.RowTemplate.Height = 25;
            this.ClassDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassDataGridView.Size = new System.Drawing.Size(479, 324);
            this.ClassDataGridView.TabIndex = 2;
            this.ClassDataGridView.Click += new System.EventHandler(this.ClassDataGridView_Click);
            // 
            // SchedulePage
            // 
            this.SchedulePage.Controls.Add(this.ScheduleGroupBox);
            this.SchedulePage.Controls.Add(this.ScheduleDataGridView);
            this.SchedulePage.Location = new System.Drawing.Point(4, 24);
            this.SchedulePage.Name = "SchedulePage";
            this.SchedulePage.Padding = new System.Windows.Forms.Padding(3);
            this.SchedulePage.Size = new System.Drawing.Size(782, 335);
            this.SchedulePage.TabIndex = 3;
            this.SchedulePage.Text = "Horaires";
            this.SchedulePage.UseVisualStyleBackColor = true;
            // 
            // ScheduleGroupBox
            // 
            this.ScheduleGroupBox.Controls.Add(this.EndScheduleDateTimePicker);
            this.ScheduleGroupBox.Controls.Add(this.StartScheduleDateTimePicker);
            this.ScheduleGroupBox.Controls.Add(this.WeekDayScheduleComboBox);
            this.ScheduleGroupBox.Controls.Add(this.RoomScheduleComboBox);
            this.ScheduleGroupBox.Controls.Add(this.RoomScheduleLabel);
            this.ScheduleGroupBox.Controls.Add(this.EndScheduleLabel);
            this.ScheduleGroupBox.Controls.Add(this.ClassScheduleComboBox);
            this.ScheduleGroupBox.Controls.Add(this.AddScheduleButton);
            this.ScheduleGroupBox.Controls.Add(this.DeleteScheduleButton);
            this.ScheduleGroupBox.Controls.Add(this.ModifyScheduleButton);
            this.ScheduleGroupBox.Controls.Add(this.IdInfoScheduleLabel);
            this.ScheduleGroupBox.Controls.Add(this.ClassScheduleLabel);
            this.ScheduleGroupBox.Controls.Add(this.StartScheduleLabel);
            this.ScheduleGroupBox.Controls.Add(this.WeekDayScheduleLabel);
            this.ScheduleGroupBox.Controls.Add(this.IdScheduleLabel);
            this.ScheduleGroupBox.Location = new System.Drawing.Point(6, 6);
            this.ScheduleGroupBox.Name = "ScheduleGroupBox";
            this.ScheduleGroupBox.Size = new System.Drawing.Size(285, 324);
            this.ScheduleGroupBox.TabIndex = 5;
            this.ScheduleGroupBox.TabStop = false;
            this.ScheduleGroupBox.Text = "Horaire";
            // 
            // EndScheduleDateTimePicker
            // 
            this.EndScheduleDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndScheduleDateTimePicker.Location = new System.Drawing.Point(143, 122);
            this.EndScheduleDateTimePicker.Name = "EndScheduleDateTimePicker";
            this.EndScheduleDateTimePicker.ShowUpDown = true;
            this.EndScheduleDateTimePicker.Size = new System.Drawing.Size(136, 23);
            this.EndScheduleDateTimePicker.TabIndex = 18;
            this.EndScheduleDateTimePicker.Value = new System.DateTime(2023, 9, 8, 8, 0, 0, 0);
            // 
            // StartScheduleDateTimePicker
            // 
            this.StartScheduleDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartScheduleDateTimePicker.Location = new System.Drawing.Point(143, 92);
            this.StartScheduleDateTimePicker.Name = "StartScheduleDateTimePicker";
            this.StartScheduleDateTimePicker.ShowUpDown = true;
            this.StartScheduleDateTimePicker.Size = new System.Drawing.Size(136, 23);
            this.StartScheduleDateTimePicker.TabIndex = 17;
            this.StartScheduleDateTimePicker.Value = new System.DateTime(2023, 9, 8, 8, 0, 0, 0);
            // 
            // WeekDayScheduleComboBox
            // 
            this.WeekDayScheduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeekDayScheduleComboBox.FormattingEnabled = true;
            this.WeekDayScheduleComboBox.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi"});
            this.WeekDayScheduleComboBox.Location = new System.Drawing.Point(143, 62);
            this.WeekDayScheduleComboBox.Name = "WeekDayScheduleComboBox";
            this.WeekDayScheduleComboBox.Size = new System.Drawing.Size(136, 23);
            this.WeekDayScheduleComboBox.TabIndex = 16;
            // 
            // RoomScheduleComboBox
            // 
            this.RoomScheduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomScheduleComboBox.FormattingEnabled = true;
            this.RoomScheduleComboBox.Location = new System.Drawing.Point(143, 152);
            this.RoomScheduleComboBox.Name = "RoomScheduleComboBox";
            this.RoomScheduleComboBox.Size = new System.Drawing.Size(136, 23);
            this.RoomScheduleComboBox.TabIndex = 15;
            // 
            // RoomScheduleLabel
            // 
            this.RoomScheduleLabel.AutoSize = true;
            this.RoomScheduleLabel.Location = new System.Drawing.Point(6, 155);
            this.RoomScheduleLabel.Name = "RoomScheduleLabel";
            this.RoomScheduleLabel.Size = new System.Drawing.Size(81, 15);
            this.RoomScheduleLabel.TabIndex = 14;
            this.RoomScheduleLabel.Text = "Salle de classe";
            // 
            // EndScheduleLabel
            // 
            this.EndScheduleLabel.AutoSize = true;
            this.EndScheduleLabel.Location = new System.Drawing.Point(6, 125);
            this.EndScheduleLabel.Name = "EndScheduleLabel";
            this.EndScheduleLabel.Size = new System.Drawing.Size(72, 15);
            this.EndScheduleLabel.TabIndex = 13;
            this.EndScheduleLabel.Text = "Fin du cours";
            // 
            // ClassScheduleComboBox
            // 
            this.ClassScheduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassScheduleComboBox.FormattingEnabled = true;
            this.ClassScheduleComboBox.Location = new System.Drawing.Point(143, 182);
            this.ClassScheduleComboBox.Name = "ClassScheduleComboBox";
            this.ClassScheduleComboBox.Size = new System.Drawing.Size(136, 23);
            this.ClassScheduleComboBox.TabIndex = 12;
            // 
            // AddScheduleButton
            // 
            this.AddScheduleButton.Location = new System.Drawing.Point(6, 222);
            this.AddScheduleButton.Name = "AddScheduleButton";
            this.AddScheduleButton.Size = new System.Drawing.Size(273, 28);
            this.AddScheduleButton.TabIndex = 10;
            this.AddScheduleButton.Text = "Ajouter Horaire";
            this.AddScheduleButton.UseVisualStyleBackColor = true;
            this.AddScheduleButton.Click += new System.EventHandler(this.AddScheduleButton_Click);
            // 
            // DeleteScheduleButton
            // 
            this.DeleteScheduleButton.Location = new System.Drawing.Point(6, 256);
            this.DeleteScheduleButton.Name = "DeleteScheduleButton";
            this.DeleteScheduleButton.Size = new System.Drawing.Size(273, 28);
            this.DeleteScheduleButton.TabIndex = 9;
            this.DeleteScheduleButton.Text = "Supprimer Horaire";
            this.DeleteScheduleButton.UseVisualStyleBackColor = true;
            this.DeleteScheduleButton.Click += new System.EventHandler(this.DeleteScheduleButton_Click);
            // 
            // ModifyScheduleButton
            // 
            this.ModifyScheduleButton.Location = new System.Drawing.Point(6, 290);
            this.ModifyScheduleButton.Name = "ModifyScheduleButton";
            this.ModifyScheduleButton.Size = new System.Drawing.Size(273, 28);
            this.ModifyScheduleButton.TabIndex = 8;
            this.ModifyScheduleButton.Text = "Modifier Horaire";
            this.ModifyScheduleButton.UseVisualStyleBackColor = true;
            this.ModifyScheduleButton.Click += new System.EventHandler(this.ModifyScheduleButton_Click);
            // 
            // IdInfoScheduleLabel
            // 
            this.IdInfoScheduleLabel.AutoSize = true;
            this.IdInfoScheduleLabel.Location = new System.Drawing.Point(143, 35);
            this.IdInfoScheduleLabel.Name = "IdInfoScheduleLabel";
            this.IdInfoScheduleLabel.Size = new System.Drawing.Size(0, 15);
            this.IdInfoScheduleLabel.TabIndex = 7;
            // 
            // ClassScheduleLabel
            // 
            this.ClassScheduleLabel.AutoSize = true;
            this.ClassScheduleLabel.Location = new System.Drawing.Point(6, 185);
            this.ClassScheduleLabel.Name = "ClassScheduleLabel";
            this.ClassScheduleLabel.Size = new System.Drawing.Size(38, 15);
            this.ClassScheduleLabel.TabIndex = 3;
            this.ClassScheduleLabel.Text = "Cours";
            // 
            // StartScheduleLabel
            // 
            this.StartScheduleLabel.AutoSize = true;
            this.StartScheduleLabel.Location = new System.Drawing.Point(6, 95);
            this.StartScheduleLabel.Name = "StartScheduleLabel";
            this.StartScheduleLabel.Size = new System.Drawing.Size(88, 15);
            this.StartScheduleLabel.TabIndex = 2;
            this.StartScheduleLabel.Text = "Début du cours";
            // 
            // WeekDayScheduleLabel
            // 
            this.WeekDayScheduleLabel.AutoSize = true;
            this.WeekDayScheduleLabel.Location = new System.Drawing.Point(6, 65);
            this.WeekDayScheduleLabel.Name = "WeekDayScheduleLabel";
            this.WeekDayScheduleLabel.Size = new System.Drawing.Size(104, 15);
            this.WeekDayScheduleLabel.TabIndex = 1;
            this.WeekDayScheduleLabel.Text = "Jour de la semaine";
            // 
            // IdScheduleLabel
            // 
            this.IdScheduleLabel.AutoSize = true;
            this.IdScheduleLabel.Location = new System.Drawing.Point(6, 35);
            this.IdScheduleLabel.Name = "IdScheduleLabel";
            this.IdScheduleLabel.Size = new System.Drawing.Size(18, 15);
            this.IdScheduleLabel.TabIndex = 0;
            this.IdScheduleLabel.Text = "ID";
            // 
            // ScheduleDataGridView
            // 
            this.ScheduleDataGridView.AllowUserToAddRows = false;
            this.ScheduleDataGridView.AllowUserToDeleteRows = false;
            this.ScheduleDataGridView.AllowUserToResizeColumns = false;
            this.ScheduleDataGridView.AllowUserToResizeRows = false;
            this.ScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDataGridView.Location = new System.Drawing.Point(297, 6);
            this.ScheduleDataGridView.Name = "ScheduleDataGridView";
            this.ScheduleDataGridView.ReadOnly = true;
            this.ScheduleDataGridView.RowHeadersVisible = false;
            this.ScheduleDataGridView.RowTemplate.Height = 25;
            this.ScheduleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScheduleDataGridView.Size = new System.Drawing.Size(479, 324);
            this.ScheduleDataGridView.TabIndex = 4;
            this.ScheduleDataGridView.Click += new System.EventHandler(this.ScheduleDataGridView_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 362);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendrier";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.TeacherPage.ResumeLayout(false);
            this.TeacherGroupBox.ResumeLayout(false);
            this.TeacherGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGridView)).EndInit();
            this.RoomPage.ResumeLayout(false);
            this.RoomGroupBox.ResumeLayout(false);
            this.RoomGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityRoomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGridView)).EndInit();
            this.ClassPage.ResumeLayout(false);
            this.ClassesGroupBox.ResumeLayout(false);
            this.ClassesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataGridView)).EndInit();
            this.SchedulePage.ResumeLayout(false);
            this.ScheduleGroupBox.ResumeLayout(false);
            this.ScheduleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage TeacherPage;
        private TabPage RoomPage;
        private TabPage ClassPage;
        private TabPage SchedulePage;
        private DataGridView TeacherDataGridView;
        private GroupBox TeacherGroupBox;
        private Label IdTeacherLabel;
        private Label PhoneTeacherLabel;
        private Label EmailTeacherLabel;
        private Label NameteacherLabel;
        private TextBox PhoneTeacherTextBox;
        private TextBox EmailTeacherTextBox;
        private TextBox NameTeacherTextBox;
        private Label IdInfoTeacherLabel;
        private Button AddTeacherButton;
        private Button DeleteTeacherButton;
        private Button ModifyTeacherButton;
        private GroupBox RoomGroupBox;
        private Button AddRoomButton;
        private Button DeleteRoomButton;
        private Button ModifyRoomButton;
        private Label IdInfoRoomLabel;
        private TextBox NameRoomTextBox;
        private Label CapacityRoomLabel;
        private Label NameRoomLabel;
        private Label IdRoomLabel;
        private DataGridView RoomDataGridView;
        private GroupBox ClassesGroupBox;
        private Button AddClassButton;
        private Button DeleteClassButton;
        private Button ModifyClassButton;
        private Label IdInfoClassLabel;
        private TextBox NameClassTextBox;
        private Label TeacherClassLabel;
        private Label DescriptionClassLabel;
        private Label NameClassLabel;
        private Label IdClassLabel;
        private DataGridView ClassDataGridView;
        private NumericUpDown CapacityRoomNumericUpDown;
        private RichTextBox DescriptionClassTextBox;
        private ComboBox TeacherClassComboBox;
        private GroupBox ScheduleGroupBox;
        private ComboBox ClassScheduleComboBox;
        private Button AddScheduleButton;
        private Button DeleteScheduleButton;
        private Button ModifyScheduleButton;
        private Label IdInfoScheduleLabel;
        private Label ClassScheduleLabel;
        private Label StartScheduleLabel;
        private Label WeekDayScheduleLabel;
        private Label IdScheduleLabel;
        private DataGridView ScheduleDataGridView;
        private Label RoomScheduleLabel;
        private Label EndScheduleLabel;
        private ComboBox WeekDayScheduleComboBox;
        private ComboBox RoomScheduleComboBox;
        private DateTimePicker StartScheduleDateTimePicker;
        private DateTimePicker EndScheduleDateTimePicker;
    }
}