
namespace MidProject
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlSudentSubMenu = new System.Windows.Forms.Panel();
            this.btnManageStudents = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMenuHeader = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            this.pnlSudentSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnlSideBar.Controls.Add(this.pnlSudentSubMenu);
            this.pnlSideBar.Controls.Add(this.btnStudent);
            this.pnlSideBar.Controls.Add(this.btnExit);
            this.pnlSideBar.Controls.Add(this.pnlMenuHeader);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(200, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(200, 691);
            this.pnlSideBar.TabIndex = 0;
            // 
            // pnlSudentSubMenu
            // 
            this.pnlSudentSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.pnlSudentSubMenu.Controls.Add(this.btnManageStudents);
            this.pnlSudentSubMenu.Controls.Add(this.btnAddStudent);
            this.pnlSudentSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSudentSubMenu.Location = new System.Drawing.Point(0, 167);
            this.pnlSudentSubMenu.Name = "pnlSudentSubMenu";
            this.pnlSudentSubMenu.Size = new System.Drawing.Size(200, 61);
            this.pnlSudentSubMenu.TabIndex = 12;
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Animated = true;
            this.btnManageStudents.BackColor = System.Drawing.Color.Transparent;
            this.btnManageStudents.DefaultAutoSize = true;
            this.btnManageStudents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageStudents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageStudents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageStudents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageStudents.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.btnManageStudents.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnManageStudents.ForeColor = System.Drawing.Color.White;
            this.btnManageStudents.IndicateFocus = true;
            this.btnManageStudents.Location = new System.Drawing.Point(0, 27);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(200, 27);
            this.btnManageStudents.TabIndex = 15;
            this.btnManageStudents.Text = "    Manage Students";
            this.btnManageStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageStudents.UseTransparentBackground = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Animated = true;
            this.btnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.DefaultAutoSize = true;
            this.btnAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.IndicateFocus = true;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 0);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(200, 27);
            this.btnAddStudent.TabIndex = 12;
            this.btnAddStudent.Text = "    Add Student";
            this.btnAddStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddStudent.UseTransparentBackground = true;
            this.btnAddStudent.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Animated = true;
            this.btnStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = global::MidProject.Properties.Resources.STDH;
            this.btnStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudent.IndicateFocus = true;
            this.btnStudent.Location = new System.Drawing.Point(0, 120);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(200, 47);
            this.btnStudent.TabIndex = 11;
            this.btnStudent.Text = "Students";
            this.btnStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudent.UseTransparentBackground = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 646);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(200, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMenuHeader
            // 
            this.pnlMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuHeader.Name = "pnlMenuHeader";
            this.pnlMenuHeader.Size = new System.Drawing.Size(200, 120);
            this.pnlMenuHeader.TabIndex = 0;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1150, 691);
            this.pnlChildForm.TabIndex = 1;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSideBar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSudentSubMenu.ResumeLayout(false);
            this.pnlSudentSubMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMenuHeader;
        private Guna.UI2.WinForms.Guna2Button btnStudent;
        private System.Windows.Forms.Panel pnlSudentSubMenu;
        private Guna.UI2.WinForms.Guna2Button btnAddStudent;
        private Guna.UI2.WinForms.Guna2Button btnManageStudents;
        private System.Windows.Forms.Panel pnlChildForm;
    }
}

