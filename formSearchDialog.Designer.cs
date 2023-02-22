
namespace MidProject
{
    partial class formSearchDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.epNotFound = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNotFound)).BeginInit();
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
            this.tbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.tbl.ColumnCount = 1;
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tbl.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl.Location = new System.Drawing.Point(0, 0);
            this.tbl.Name = "tbl";
            this.tbl.RowCount = 2;
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.33334F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.66667F));
            this.tbl.Size = new System.Drawing.Size(360, 180);
            this.tbl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.85311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.9887F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.15819F));
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 125);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnSearch.IndicateFocus = true;
            this.btnSearch.Location = new System.Drawing.Point(236, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnCancel.IndicateFocus = true;
            this.btnCancel.Location = new System.Drawing.Point(10, 10);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseTransparentBackground = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.57627F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.69492F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.44633F));
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.49573F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.00855F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.64103F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(354, 116);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(95, 39);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Registration Number";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(167, 38);
            this.txtSearch.TabIndex = 6;
            // 
            // epNotFound
            // 
            this.epNotFound.ContainerControl = this;
            // 
            // formSearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 180);
            this.Controls.Add(this.tbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSearchDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.tbl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epNotFound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.TableLayoutPanel tbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.ErrorProvider epNotFound;
    }
}