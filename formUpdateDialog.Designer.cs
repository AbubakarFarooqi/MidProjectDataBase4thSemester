
namespace MidProject
{
    partial class formUpdateDialog
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tbl = new System.Windows.Forms.TableLayoutPanel();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // tbl
            // 
            this.tbl.ColumnCount = 3;
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.82741F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.61421F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.55838F));
            this.tbl.Controls.Add(this.txtRegNo, 1, 5);
            this.tbl.Controls.Add(this.txtLastName, 1, 2);
            this.tbl.Controls.Add(this.txtContact, 1, 3);
            this.tbl.Controls.Add(this.txtEmail, 1, 4);
            this.tbl.Controls.Add(this.txtFirstName, 1, 1);
            this.tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl.Location = new System.Drawing.Point(0, 0);
            this.tbl.Name = "tbl";
            this.tbl.RowCount = 9;
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.703336F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.766455F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4034F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.19108F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.55414F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.280254F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.821656F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.31423F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.42796F));
            this.tbl.Size = new System.Drawing.Size(394, 471);
            this.tbl.TabIndex = 0;
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
            this.txtFirstName.Location = new System.Drawing.Point(93, 16);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(8);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(210, 30);
            this.txtFirstName.TabIndex = 2;
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
            this.txtEmail.Location = new System.Drawing.Point(93, 159);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "First Name";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(210, 29);
            this.txtEmail.TabIndex = 3;
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
            this.txtContact.Location = new System.Drawing.Point(93, 111);
            this.txtContact.Margin = new System.Windows.Forms.Padding(8);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderText = "First Name";
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(210, 32);
            this.txtContact.TabIndex = 4;
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
            this.txtLastName.Location = new System.Drawing.Point(93, 62);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(8);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "First Name";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(210, 33);
            this.txtLastName.TabIndex = 5;
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
            this.txtRegNo.Location = new System.Drawing.Point(93, 204);
            this.txtRegNo.Margin = new System.Windows.Forms.Padding(8);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.PasswordChar = '\0';
            this.txtRegNo.PlaceholderText = "First Name";
            this.txtRegNo.SelectedText = "";
            this.txtRegNo.Size = new System.Drawing.Size(210, 23);
            this.txtRegNo.TabIndex = 6;
            // 
            // formUpdateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(394, 471);
            this.Controls.Add(this.tbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUpdateDialog";
            this.Text = "formUpdateDialog";
            this.tbl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.TableLayoutPanel tbl;
        private Guna.UI2.WinForms.Guna2TextBox txtRegNo;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
    }
}