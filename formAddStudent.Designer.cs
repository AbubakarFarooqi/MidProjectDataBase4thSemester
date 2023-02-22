
namespace MidProject
{
    partial class formAddStudent
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
            this.components = new System.ComponentModel.Container();
            this.tblView = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRegNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRegNo)).BeginInit();
            this.SuspendLayout();
            // 
            // tblView
            // 
            this.tblView.ColumnCount = 1;
            this.tblView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.125F));
            this.tblView.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblView.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tblView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblView.Location = new System.Drawing.Point(0, 0);
            this.tblView.Name = "tblView";
            this.tblView.RowCount = 2;
            this.tblView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.133059F));
            this.tblView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.86694F));
            this.tblView.Size = new System.Drawing.Size(1153, 666);
            this.tblView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.102877F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.89713F));
            this.tableLayoutPanel1.Controls.Add(this.lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1147, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lbl.Location = new System.Drawing.Point(72, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(1072, 41);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "  ADD STUDENT";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LightGray;
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.45161F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54839F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtFirstName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtLastName, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtContact, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtRegNo, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbxGender, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.tpDOB, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 57);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1133, 599);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnAdd.IndicateFocus = true;
            this.btnAdd.Location = new System.Drawing.Point(686, 259);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 52);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.txtFirstName.BorderRadius = 10;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(267, 89);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(8);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(179, 42);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.txtLastName.BorderRadius = 10;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(462, 89);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(8);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(206, 42);
            this.txtLastName.TabIndex = 2;
            // 
            // txtContact
            // 
            this.txtContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.txtContact.BorderRadius = 10;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContact.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContact.ForeColor = System.Drawing.Color.White;
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.Location = new System.Drawing.Point(684, 89);
            this.txtContact.Margin = new System.Windows.Forms.Padding(8);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderText = "Contact";
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(206, 42);
            this.txtContact.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(267, 147);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(179, 42);
            this.txtEmail.TabIndex = 4;
            // 
            // txtRegNo
            // 
            this.txtRegNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.txtRegNo.BorderRadius = 10;
            this.txtRegNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegNo.DefaultText = "";
            this.txtRegNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.txtRegNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegNo.ForeColor = System.Drawing.Color.White;
            this.txtRegNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegNo.Location = new System.Drawing.Point(462, 147);
            this.txtRegNo.Margin = new System.Windows.Forms.Padding(8);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.PasswordChar = '\0';
            this.txtRegNo.PlaceholderText = "Registration Number";
            this.txtRegNo.SelectedText = "";
            this.txtRegNo.Size = new System.Drawing.Size(206, 42);
            this.txtRegNo.TabIndex = 5;
            // 
            // cbxGender
            // 
            this.cbxGender.BackColor = System.Drawing.Color.Transparent;
            this.cbxGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.cbxGender.BorderRadius = 10;
            this.cbxGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.cbxGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxGender.ForeColor = System.Drawing.Color.White;
            this.cbxGender.ItemHeight = 30;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(679, 142);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(216, 36);
            this.cbxGender.StartIndex = 0;
            this.cbxGender.TabIndex = 6;
            // 
            // tpDOB
            // 
            this.tpDOB.Animated = true;
            this.tpDOB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.tpDOB.BorderRadius = 10;
            this.tpDOB.BorderThickness = 1;
            this.tpDOB.Checked = true;
            this.tpDOB.CustomFormat = "yyyy-mm-dd";
            this.tpDOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpDOB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tpDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tpDOB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tpDOB.IndicateFocus = true;
            this.tpDOB.Location = new System.Drawing.Point(457, 200);
            this.tpDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tpDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tpDOB.Name = "tpDOB";
            this.tpDOB.Size = new System.Drawing.Size(216, 46);
            this.tpDOB.TabIndex = 7;
            this.tpDOB.Value = new System.DateTime(2023, 2, 20, 17, 6, 44, 312);
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.ContainerControl = this;
            // 
            // epLastName
            // 
            this.epLastName.ContainerControl = this;
            // 
            // epContact
            // 
            this.epContact.ContainerControl = this;
            // 
            // epRegNo
            // 
            this.epRegNo.ContainerControl = this;
            // 
            // formAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1153, 666);
            this.Controls.Add(this.tblView);
            this.Name = "formAddStudent";
            this.Text = "formAddStudent";
            this.tblView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRegNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtRegNo;
        private Guna.UI2.WinForms.Guna2ComboBox cbxGender;
        private Guna.UI2.WinForms.Guna2DateTimePicker tpDOB;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epContact;
        private System.Windows.Forms.ErrorProvider epRegNo;
    }
}